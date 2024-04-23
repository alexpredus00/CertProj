using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertProj.UI.Iesiri
{
    public partial class iesiriMaster : Form
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

        int gestiuneClicked;
        int numarClicked;
        int isUpdate;
        public iesiriMaster(string gestiune, string numarClick, int isUp)
        {
            InitializeComponent();
            gestiuneClicked = int.Parse(gestiune);
            numarClicked = int.Parse(numarClick);
            isUpdate = isUp;
        }

        // Initializam datacontext
        sampleDataContext dc = new sampleDataContext();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Incarcam valorile in combobox
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
                if (gestiuneClicked != 0)
                {
                    cmbGestiune.SelectedValue = gestiuneClicked;
                }

                if (numarClicked > 0)
                {
                    txtNr.Text = numarClicked.ToString();
                }

            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }
        }

        private void iesiriMaster_Load(object sender, EventArgs e)
        {
            IncarcaCombobox();
        }

        // Cautam daca numarul exista in coloana dupa cod
        public bool numarFinder(int numberToCheck)
        {
            try
            {
                bool exists = dc.iesiris.Any(row => row.numar == numberToCheck);
                return exists;
            }
            catch (Exception z)
            {
                Console.WriteLine("Error: " + z.Message);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Verificam daca campurile sunt completate
            if (cmbGestiune.Text != "" && txtNr.Text != "")
            {
                try
                {
                    int numarTextbox = int.Parse(txtNr.Text);

                    // Updatam doar celelalte date daca numarul din textbox este la fel cu numarul randului selectat
                    if (numarClicked == numarTextbox && numarFinder(numarTextbox))
                    {
                        iesiri updateIesire = dc.iesiris.FirstOrDefault(nmr => nmr.numar == numarTextbox);
                        if (numarClicked == numarTextbox)
                        {
                            updateIesire.data = DateTime.Now;
                            updateIesire.gestiune = (int)cmbGestiune.SelectedValue;
                        }

                        dc.SubmitChanges();
                        this.Close();
                    }
                    // Updatam toate datele daca randul din textbox este diferit de cel selectat si isUpdate > 0
                    else if (numarTextbox != numarClicked && isUpdate > 0)
                    {
                        if (numarFinder(numarTextbox) == false)
                        {
                            iesiri updateIesire = dc.iesiris.FirstOrDefault(nmr => nmr.numar == numarClicked);
                            updateIesire.data = DateTime.Now;
                            updateIesire.numar = int.Parse(txtNr.Text);
                            updateIesire.gestiune = (int)cmbGestiune.SelectedValue;

                            dc.SubmitChanges();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Numarul este deja folosit.");
                        }
                    }
                    // Adaugam rand nou
                    else
                    {   // Verificam daca numarul exista deja in coloana
                        if (numarFinder(numarTextbox) == false)
                        {
                            iesiri newIesire = new iesiri();

                            newIesire.data = DateTime.Now;
                            newIesire.gestiune = (int)cmbGestiune.SelectedValue;
                            newIesire.numar = int.Parse(txtNr.Text);

                            dc.iesiris.InsertOnSubmit(newIesire);
                            dc.SubmitChanges();
                            this.Close();
                            }
                        else
                        {
                            MessageBox.Show("Numarul este deja folosit.");
                        }
                    }
                }
                catch (Exception z)
                {
                    MessageBox.Show("Error! Please enter data in the correct format. " + z);
                }
            }
            else
            {
                MessageBox.Show("Campurile nu pot sa ramana goale!");
            }
        }
    }
}
