using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertProj.UI
{
    public partial class frmProduse : Form
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
        public frmProduse()
        {
            InitializeComponent();
        }

        // Incarca datele in DataGrid
        private void frmProduse_Load(object sender, EventArgs e)
        {
            SelectTable();
        }

        // Inchide macheta
        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh DataGrid
        private void SelectTable()
        {
            sampleDataContext dC = new sampleDataContext();
            var selectQuery = from a in dC.GetTable<produse>()
                              select a;

            dgvProduse.DataSource = selectQuery.ToList();

            // afisam doar campurile care il intereseaza pe utilizator
            dgvProduse.Columns["id"].Visible = false;
        }

        // Goleste textbox-urile
        private void clear()
        {
            txtDenumire.Text = "";
            txtPretUnitar.Text = "";
            txtCod.Text = "";
        }

        // Ia codul din randul selectat
        string rowSelectedCod;

        // Initializam DataContext
        sampleDataContext dc = new sampleDataContext();

        // Gaseste cel mai mare cod din coloana
        public int GetMaxCod()
        {
            try
            {
                int? maxCod = dc.produses.Max(row => (int?)row.cod);
                return maxCod ?? 0; // Return 0 if maxCod is null
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0; // Return 0 in case of an exception
            }
        }

        // Cauta daca codul exista in coloana
        public bool CodFinder(int numberToCheck)
        {
            try
            {
                bool exists = dc.produses.Any(row => row.cod == numberToCheck);
                return exists;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Ia datele din radul selectat
        private void dgvProduse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            txtCod.Text = dgvProduse.Rows[rowIndex].Cells[0].Value.ToString();
            txtDenumire.Text = dgvProduse.Rows[rowIndex].Cells[1].Value.ToString();
            txtPretUnitar.Text = dgvProduse.Rows[rowIndex].Cells[2].Value.ToString();

            rowSelectedCod = txtCod.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produse newProdus = new produse();

            // Verificam daca coloanele sunt goale
            if (txtDenumire.Text != "" && txtPretUnitar.Text != "")
            {
                try
                {
                    int maxCod = GetMaxCod();
                    int.TryParse(txtCod.Text, out int numberToCheck);

                    if (maxCod > 0 || txtCod.Text != "" || maxCod == 0)
                    {
                        // Se adauga numarul din textbox daca nu este deja in database sau este null
                        if (CodFinder(numberToCheck) == false && txtCod.Text != "")
                        {
                            newProdus.cod = int.Parse(txtCod.Text);
                        }
                        // daca exista deja se ia cel mai mare numar din coloana + 1
                        else
                        {
                            newProdus.cod = GetMaxCod() + 1;
                        }

                        newProdus.denumire = txtDenumire.Text;
                        newProdus.pret_unitar = decimal.Parse(txtPretUnitar.Text);

                        dc.produses.InsertOnSubmit(newProdus);
                        dc.SubmitChanges();
                        SelectTable();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error when generating Cod.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Please enter data in the correct format. \n\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Campurile nu pot sa ramana goale!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "" && txtDenumire.Text != "" && txtPretUnitar.Text != "")
            {
                try
                {
                    // Cautam randul
                    produse produs = dc.produses.FirstOrDefault(prds => prds.cod.Equals(rowSelectedCod));


                    if (CodFinder(int.Parse(txtCod.Text)) == false || int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                    {
                        //  Numarul ramane acelasi daca exista deja
                        if (int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                        {
                            produs.denumire = txtDenumire.Text;
                            produs.pret_unitar = decimal.Parse(txtPretUnitar.Text);
                        }
                        // Daca nu exista se schimba in cel selectat cu rowHeaderClick
                        else
                        {
                            produs.cod = int.Parse(txtCod.Text);
                            produs.denumire = txtDenumire.Text;
                            produs.pret_unitar = decimal.Parse(txtPretUnitar.Text);
                        }

                        dc.SubmitChanges();
                        clear();
                        SelectTable();
                    }
                    else
                    {
                        MessageBox.Show("Codul este deja folosit.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Actualizarea a esuat. Campurile nu pot sa ramana goale.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Gasim randul
                produse produs = dc.produses.FirstOrDefault(prds => prds.cod.Equals(txtCod.Text));

                dc.produses.DeleteOnSubmit(produs);
                dc.SubmitChanges();
                clear();
                SelectTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}