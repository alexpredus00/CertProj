using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Cmp;

namespace CertProj.UI
{
    public partial class Rapoarte : Form
    {
        #region Make form draggable
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        #endregion

        // Initializam valorile din radiobutton-uri
        string tipLista = "intrari";
        int idGestiune = -1;

        public Rapoarte()
        {
            InitializeComponent();
        }

        // Initializam datacontext
        sampleDataContext dc = new sampleDataContext();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Incarcam combobox-ul
        private void IncarcaCombobox()
        {
            try
            {
                var gestiuni = from g in dc.gestiunis
                               select new
                               {
                                   id = g.id,
                                   Denumire = g.denumire
                               };

                cmbGestiune.DataSource = gestiuni.ToList();
                cmbGestiune.DisplayMember = "Denumire";
                cmbGestiune.ValueMember = "id";
                //cmbGestiune.SelectedValue = 0;
            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea gestiunilor: " + z.Message);
            }
        }

        private void Rapoarte_Load(object sender, EventArgs e)
        {
            IncarcaCombobox();

            // Ascundem combobox-ul gestiune
            lblGestiune.Visible = !lblGestiune.Visible;
            cmbGestiune.Visible = lblGestiune.Visible;

            // Get first and last day of month
            DateTime currentDate = DateTime.Today;
            int lastDayOfMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime EndOfMonth = new DateTime(currentDate.Year, currentDate.Month, lastDayOfMonth);

            // Set the Value property of your DateTimePickers
            dtpInceput.Value = firstDayOfMonth;
            dtpSfarsit.Value = EndOfMonth;

        }

        // Afisam/Ascundem gestiunea in functie de radiobutton-ul selectat
        private void rdGestiuni_CheckedChanged(object sender, EventArgs e)
        {
            lblGestiune.Visible = !lblGestiune.Visible;
            cmbGestiune.Visible = lblGestiune.Visible;
            idGestiune = (idGestiune == -1) ? int.Parse(cmbGestiune.SelectedValue.ToString()) : -1;
        }

        // Luam valoarea radiobutton-ului selectat pentru lista
        private void rdListaIntrari_CheckedChanged(object sender, EventArgs e)
        {
            tipLista = (tipLista == "intrari") ? "iesiri" : "intrari";
        }

        private void btnAccepta_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object for the stored procedure
                using (SqlCommand command = new SqlCommand("get" + tipLista, connection))
                {
                    // Set the command type to stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    command.Parameters.Add("@dataInceput", SqlDbType.Date).Value = dtpInceput.Value;
                    command.Parameters.Add("@dataSfarsit", SqlDbType.Date).Value = dtpSfarsit.Value;

                    // Daca idGestiune este -1 atunci luam toate gestiunile
                    if (idGestiune == -1)
                    {
                        command.Parameters.Add("@idGestiune", SqlDbType.Int).Value = idGestiune;
                    }
                    else
                    {
                        command.Parameters.Add("@idGestiune", SqlDbType.Int).Value = cmbGestiune.SelectedValue;
                    }

                    // Open the connection
                    connection.Open();

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Execute the command and load the result into the DataTable
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    // Bind the DataTable to the DataGridView
                    dgv.DataSource = dataTable;

                    // Ascundem campurile pe care nu ar trebui sa le vada user-ul
                    dgv.Columns["id"].Visible = false;
                }
            }
        }


        private void btnListeaza_Click(object sender, EventArgs e)
        {
            try
            {
                string currentDateTimeString = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

                // Calea si numele fisierului PDF
                string folderPath = Path.Combine(Environment.CurrentDirectory, "Rapoarte");
                string outputFile = Path.Combine(folderPath, "raport_" + tipLista + "_" + currentDateTimeString + ".pdf");

                // Crearea documentului PDF
                Document doc = new Document();

                // Crearea unui obiect PdfWriter pentru a scrie în fisierul PDF
                PdfWriter.GetInstance(doc, new FileStream(outputFile, FileMode.Create));

                // Deschide documentul pentru editare
                doc.Open();

                // Adauga un titlu în document
                Paragraph title = new Paragraph("Raport " + tipLista);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 10f;
                doc.Add(title);

                // Adauga un paragraf pentru perioada selectată
                Paragraph period = new Paragraph($"Perioada selectata: {dtpInceput.Value.ToString("dd.MM.yyyy")} - {dtpSfarsit.Value.ToString("dd.MM.yyyy")}");
                period.Alignment = Element.ALIGN_CENTER;
                period.SpacingAfter = 10f;
                doc.Add(period);

                // Adauga un paragraf pentru gestiunea selectată (dacă este cazul)
                if (idGestiune != -1)
                {
                    Paragraph gestiune = new Paragraph($"Gestiune selectata: {cmbGestiune.Text}");
                    gestiune.Alignment = Element.ALIGN_CENTER;
                    gestiune.SpacingAfter = 10f;
                    doc.Add(gestiune);
                }

                // Crează un obiect PdfPTable pentru tabel
                PdfPTable pdfTable = new PdfPTable(7);


                // Adăugați coloanele necesare
                pdfTable.AddCell("Gestiune");
                pdfTable.AddCell("Numar");
                pdfTable.AddCell("Data");
                pdfTable.AddCell("Denumire Produs");
                pdfTable.AddCell("Pret Unitar");
                pdfTable.AddCell("Cantitate");
                pdfTable.AddCell("Valoare");

                // Liste folosite pentru sortare
                List<object[]> allDataList = new List<object[]>();
                List<object[]> numarList = new List<object[]>();
                List<object[]> emptyRow = new List<object[]>();
                List<string> currentRow = new List<string>();
                List<object[]> dataList = new List<object[]>();
                emptyRow.Add(new object[] { " ", " ", " ", " ", " ", " ", " ", });

                // Parcurgeți fiecare rând din DataGridView și adăugați valorile relevante la tabelul PDF
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string codDetaliu;
                    List<object[]> gestiuneDataList = new List<object[]>();
                    IEnumerable<dynamic> intrariDetaliu = Enumerable.Empty<dynamic>();

                    // daca lista este de intrari atunci id-ul este pe coloana 4
                    if (tipLista == "intrari")
                    {
                        codDetaliu = row.Cells[4].Value?.ToString() ?? "";
                        intrariDetaliu = from detaliu in dc.intrari_detalius
                                         join produs in dc.produses on detaliu.produs equals produs.id
                                         where detaliu.id_intrari == int.Parse(codDetaliu)
                                         select new
                                         {
                                             Detaliu = detaliu,
                                             Produs = produs
                                         };
                    }
                    // daca lista este de iesiri atunci id-ul este pe coloana 3
                    else
                    {
                        codDetaliu = row.Cells[3].Value?.ToString() ?? "";
                        intrariDetaliu = from detaliu in dc.iesiri_detalius
                                         join produs in dc.produses on detaliu.produs equals produs.id
                                         where detaliu.id_iesiri == int.Parse(codDetaliu)
                                         select new
                                         {
                                             Detaliu = detaliu,
                                             Produs = produs
                                         };
                    }

                    try
                    {   // Pentru fiecare intrare/iesire adaugam fiecare intrare_detaliu/iesire_detaliu
                        foreach (var detaliu in intrariDetaliu)
                        {
                            string gestiune = "";
                            string numar = row.Cells[0].Value?.ToString() ?? "";
                            string data = row.Cells[1].Value?.ToString() ?? "";

                            // Extrage valorile pentru coloanele "Gestiune" și "Denumire"
                            if (tipLista == "intrari")
                            {
                                gestiune = findGestiuneDupaCod(row.Cells[3].Value?.ToString() ?? "");
                            }
                            else
                            {
                                gestiune = findGestiuneDupaCod(row.Cells[2].Value?.ToString() ?? "");
                            }

                            string denumire = detaliu.Produs.denumire;
                            string pret = detaliu.Produs.pret_unitar.ToString();
                            string cantitate = detaliu.Detaliu.cantitate.ToString();
                            string valoare = detaliu.Detaliu.valoare.ToString();

                            // Adaugă valorile in lista cu toate randurile
                            allDataList.Add(new object[] { gestiune, numar, data, denumire, pret, cantitate, valoare });
                        }
                    }
                    catch { }
                }

                // Lista cu spatiu gol pentru formatarea documentului
                PdfPCell emptyCell = new PdfPCell(new Phrase(" "));
                emptyCell.Border = PdfPCell.NO_BORDER; // Se elimină marginile celulei
                string emptySpace = "\n";
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                // Sortam lista cu toate randurile
                allDataList = allDataList.OrderBy(row => row[0]).ToList();
                allDataList.Add(new object[] { "", "", "", "", "", "", "" });

                // Initalizam variabile pentru calcularea valoarile totale a produselor
                decimal valoareTotala = 0;

                // Trecem prin toate randurile
                for (int i = 0; i < allDataList.Count - 1; i++)
                {
                    // Adaugam randul la lista numarList
                    numarList.Add(allDataList[i]);

                    valoareTotala += decimal.Parse(allDataList[i][6].ToString());

                    // Daca numele gestiunei se schimba afisam datele, calculam totalul valorii gestiunii si lasam spatiu liber pentru urmatoarea gestiune
                    if (allDataList[i][0] != allDataList[i + 1][0])
                    {
                        decimal valoareGestiune = 0;
                        numarList.Add(new object[] { "", "", "", "", "", "", "" });

                        // Sortam randurile din gestiune dupa numarul intrarii/iesirii
                        numarList = numarList.OrderByDescending(row => row[1]).ToList();
                        for (int x = 0; x < numarList.Count - 1; x++)
                        {
                            valoareGestiune += decimal.Parse(numarList[x][6].ToString());
                            foreach (var cellData in numarList[x])
                            {
                                // Adaugam randurile in pdf
                                pdfTable.AddCell(cellData.ToString());
                            }

                            // Daca ajungem la finalul gestiunii adaugam valoarea
                            if (x == numarList.Count - 2)
                            {
                                for (int z = 0; z < 4; z++)
                                {
                                    pdfTable.AddCell(emptyCell);
                                }
                                PdfPCell cell = new PdfPCell(new Phrase("Valoare Gestiune: " + valoareGestiune.ToString(), boldFont));
                                cell.Colspan = 3;
                                pdfTable.AddCell(cell);

                            }

                        }

                        // Curatam lista cu gestiuni pentru urmatoarea gestiune
                        numarList.Clear();

                        // Daca ajungem la final punem valoarea totala
                        if (i == allDataList.Count - 2)
                        {
                            for (int z = 0; z < 4; z++)
                            {
                                pdfTable.AddCell(emptyCell);
                            }
                            PdfPCell cell = new PdfPCell(new Phrase("Valoare Totala: " + valoareTotala.ToString(), boldFont));
                            cell.Colspan = 3;
                            pdfTable.AddCell(cell);

                        }
                        else
                        {
                            for (int z = 0; z < 7; z++)
                            {
                                pdfTable.AddCell(emptyCell);
                                pdfTable.AddCell(emptyCell);
                            }
                        }
                    }

                }

                // Adaugă tabelul în document
                doc.Add(pdfTable);

                // Închide documentul
                doc.Close();

                MessageBox.Show("Fișierul PDF a fost generat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o excepție: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string findGestiuneDupaCod(string codGestiune)
        {
            var gestiuneCautata = dc.gestiunis.FirstOrDefault(p => p.id == int.Parse(codGestiune.ToString()));

            if (gestiuneCautata != null)
            {
                return gestiuneCautata.denumire;
            }
            else
            {
                return "";
            }
        }

        public string findIntrareDupaCod(string idIntrare)
        {
            var intrareCautata = dc.intrari_detalius.FirstOrDefault(p => p.id_intrari == int.Parse(idIntrare.ToString()));

            if (intrareCautata != null)
            {
                return intrareCautata.id.ToString();
            }
            else
            {
                return "";
            }
        }

        // Returneaza cantitatea, valoarea, denumirea si pretul produsului dupa cod
        public string[] findDetaliiProdusDupaCod(string idDetaliu)
        {
            var produsCautat = dc.intrari_detalius.FirstOrDefault(p => p.id == int.Parse(idDetaliu.ToString()));
            var cantitate = produsCautat.cantitate;
            var valoare = produsCautat.valoare;

            if (produsCautat != null)
            {
                string codProdus = produsCautat.produs.ToString();
                var denumireCautata = dc.produses.FirstOrDefault(p => p.id == int.Parse(produsCautat.produs.ToString()));
                var pret = denumireCautata.pret_unitar;
                var denumire = denumireCautata.denumire;

                return new string[] { denumire, pret.ToString(), cantitate.ToString(), valoare.ToString() };
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
