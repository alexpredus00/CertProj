using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CertProj.UI
{
    public partial class frmGestiuni : Form
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
        public frmGestiuni()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh datagrid
        private void SelectTable()
        {
            var selectQuery = from a in dc.GetTable<gestiuni>()
                              select a;

            dgvGestiuni.DataSource = selectQuery.ToList();
        }


        private void frmGestiuni_Load(object sender, EventArgs e)
        {
            SelectTable();
        }

        // Goleste campurile
        private void clear()
        {
            txtCod.Text = "";
            txtDenumire.Text = "";
        }

        // Luam datele din randul selectat
        private void dgvGestiuni_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the index of particular row
            int rowIndex = e.RowIndex;
            txtCod.Text = dgvGestiuni.Rows[rowIndex].Cells[0].Value.ToString();
            txtDenumire.Text = dgvGestiuni.Rows[rowIndex].Cells[1].Value.ToString();

            rowSelectedCod = txtCod.Text;
        }

        // codul randului selectat
        string rowSelectedCod;

        // Gaseste valoarea maxima din coloana cod
        public int GetMaxCod()
        {
            try
            {
                int? maxCod = dc.gestiunis.Max(row => (int?)row.cod);
                return maxCod ?? 0; // Return 0 if maxCod is null
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0; // Return 0 in case of an exception
            }
        }

        // Cauta daca codul exista deja in coloana
        public bool CodFinder(int numberToCheck)
        {
            try
            {
                bool exists = dc.gestiunis.Any(row => row.cod == numberToCheck);
                return exists;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Initializare DataContext
        sampleDataContext dc = new sampleDataContext();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gestiuni newGestiune = new gestiuni();

            // Verificam daca campul este completat
            if (txtDenumire.Text != "")
            {
                try
                {
                    int maxCod = GetMaxCod();
                    int.TryParse(txtCod.Text, out int numberToCheck);

                    if (maxCod > 0 || txtCod.Text != "" || maxCod == 0)
                    {
                        // Adaugam codul din textbox daca nu exista deja
                        if (CodFinder(numberToCheck) == false && txtCod.Text != "")
                        {
                            newGestiune.cod = int.Parse(txtCod.Text);
                        }
                        // Daca exista sau e gol adaugam valoarea maxima din coloana + 1
                        else
                        {
                            newGestiune.cod = maxCod + 1;
                        }
                        newGestiune.denumire = txtDenumire.Text;

                        dc.gestiunis.InsertOnSubmit(newGestiune);
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
            if (txtCod.Text != "" && txtDenumire.Text != "")
            {
                try
                {
                    gestiuni gestiune = dc.gestiunis.FirstOrDefault(prds => prds.cod.Equals(rowSelectedCod));

                    if (CodFinder(int.Parse(txtCod.Text)) == false || int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                    {
                        // Codul ramane la fel daca este egal cu cel selectat
                        if (int.Parse(txtCod.Text) == int.Parse(rowSelectedCod))
                        {
                            gestiune.denumire = txtDenumire.Text;
                        }
                        // Daca nu e egal il updatam
                        else
                        {
                            gestiune.cod = int.Parse(txtCod.Text);
                            gestiune.denumire = txtDenumire.Text;
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
                // Gasim randul
                gestiuni gestiune = dc.gestiunis.FirstOrDefault(prds => prds.cod.Equals(txtCod.Text));

                dc.gestiunis.DeleteOnSubmit(gestiune);
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


