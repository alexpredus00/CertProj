using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertProj.UI
{
    public partial class frmParteneri : Form
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

        public frmParteneri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pune data in datagrid
        private void SelectTable()
        {

            var selectQuery = from a in dc.GetTable<parteneri>()
                              select a;

            dgvParteneri.DataSource = selectQuery.ToList();
        }

        private void frmParteneri_Load(object sender, EventArgs e)
        {
            SelectTable();

            // afisam doar campurile care il intereseaza pe utilizator
            dgvParteneri.Columns["id"].Visible = false;

        }

        // Curata textbox-urile
        private void clear()
        {
            txtCod.Text = "";
            txtDenumire.Text = "";
            txtCui.Text = "";
            txtAdresa.Text = "";
        }

        // codul randului selectat
        string rowSelectedCod;

        // Ia datele din randul selectat
        private void dgvParteneri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            txtCod.Text = dgvParteneri.Rows[rowIndex].Cells[0].Value.ToString();
            txtDenumire.Text = dgvParteneri.Rows[rowIndex].Cells[1].Value.ToString();
            txtCui.Text = dgvParteneri.Rows[rowIndex].Cells[2].Value.ToString();
            txtAdresa.Text = dgvParteneri.Rows[rowIndex].Cells[3].Value.ToString();

            rowSelectedCod = txtCod.Text;
        }


        // Initializare DataContext
        sampleDataContext dc = new sampleDataContext();

        // cauta cel mai mare numar din coloana cod
        public int GetMaxCod()
        {
            try
            {
                int? maxCod = dc.parteneris.Max(row => (int?)row.cod);
                return maxCod ?? 0; // Return 0 if maxCod is null
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0; // Return 0 in case of an exception
            }
        }

        // cauta daca un numar exista in coloana cod
        public bool CodFinder(int numberToCheck)
        {
            try
            {
                bool exists = dc.parteneris.Any(row => row.cod == numberToCheck);
                return exists;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            parteneri newPartener = new parteneri();
            
            // Verificam daca campurile sunt completate
            if (txtDenumire.Text != "" && txtCui.Text != "" && txtAdresa.Text != "")
            {
                try
                {
                    int maxCod = GetMaxCod();
                    int.TryParse(txtCod.Text, out int numberToCheck);

                    if (maxCod > 0 || txtCod.Text != "" || maxCod == 0)
                    {
                        // Daca numarul din textbox nu este deja in coloana se adauga
                        if (CodFinder(numberToCheck) == false && txtCod.Text != "")
                        {
                            newPartener.cod = int.Parse(txtCod.Text);
                        }
                        // Daca este deja sau nu a fost introdus nimic se ia numarul maxim din coloana + 1
                        else
                        {
                            newPartener.cod = maxCod + 1;
                        }

                        newPartener.denumire = txtDenumire.Text;
                        newPartener.cui = txtCui.Text;
                        newPartener.adresa = txtAdresa.Text;
                        dc.parteneris.InsertOnSubmit(newPartener);
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
                    MessageBox.Show("Error! Please enter data in the correct format.");
                }
            }
            else
            {
                MessageBox.Show("Campurile nu pot sa ramana goale!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "" && txtDenumire.Text != "" && txtCui.Text != "" && txtAdresa.Text != "")
            {
                try
                {
                    // Gaseste randul
                    parteneri partener = dc.parteneris.FirstOrDefault(prds => prds.cod.Equals(rowSelectedCod));

                    if (CodFinder(int.Parse(txtCod.Text)) == false || int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                    {
                        // Daca codul introdus este la fel cu cel selectat atunci ramane la fel
                        if (int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                        {
                            partener.denumire = txtDenumire.Text;
                            partener.cui = txtCui.Text;
                            partener.adresa = txtAdresa.Text;
                        }
                        // Daca nu este la fel se schimba codul randului selectat in cel din textbox
                        else
                        {
                            partener.cod = int.Parse(txtCod.Text);
                            partener.denumire = txtDenumire.Text;
                            partener.cui = txtCui.Text;
                            partener.adresa = txtAdresa.Text;
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
                MessageBox.Show("Campurile nu pot sa ramana goale.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Gaseste randul
                parteneri partener = dc.parteneris.FirstOrDefault(prds => prds.cod.Equals(txtCod.Text));

                dc.parteneris.DeleteOnSubmit(partener);
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

