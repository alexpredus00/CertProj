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
    public partial class intrariMasterAdd : Form
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

        // Variabile pentru verificari 
        int partenerClicked;
        int gestiuneClicked;
        int numarClicked;
        int isUpdate;
        public intrariMasterAdd(string partener, string gestiune, string numarClick, int IsUp)
        {
            InitializeComponent();
            partenerClicked = int.Parse(partener);
            gestiuneClicked = int.Parse(gestiune);
            numarClicked = int.Parse(numarClick);
            isUpdate = IsUp;
        }

        // Initializam datacontext
        sampleDataContext dc = new sampleDataContext();

        // Incarcam valorile im combobox
        private void IncarcaCombobox()
        {
            try
            {

                // Query LINQ pentru a selecta codul și denumirea partenerilor
                var parteneri = from p in dc.parteneris
                                select new
                                {
                                    id = p.id,
                                    Denumire = p.denumire
                                };

                // Ataseaza rezultatul query-ului la sursa de date a ComboBox-ului
                cmbPartener.DataSource = parteneri.ToList();
                cmbPartener.DisplayMember = "Denumire"; // Afiseaza denumirea partenerului în ComboBox
                cmbPartener.ValueMember = "id"; // Returneaza codul partenerului atunci cand este selectat

                // Incarcam partenerul pentru UPDATE daca este selectat  
                if (partenerClicked != 0)
                {
                    cmbPartener.SelectedValue = partenerClicked;
                }

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

                if(numarClicked > 0)
                {
                    txtNr.Text = numarClicked.ToString(); 
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }
        }

        private void intrariMasterAdd_Load(object sender, EventArgs e)
        {
            IncarcaCombobox();
        }

        // Cautam daca numarul exista in coloana
        public bool numarFinder(int numberToCheck)
        {
            try
            {
                MessageBox.Show(numberToCheck.ToString());
                bool exists = dc.intraris.Any(row => row.numar == numberToCheck);
                return exists;
            }
            catch (Exception z)
            {
                Console.WriteLine("Error: " + z.Message);
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Verificam daca campurile sunt completate
            if (cmbGestiune.Text != "" && cmbPartener.Text != "" && txtNr.Text != "")
            {
                try
                {
                    int numarTextbox = int.Parse(txtNr.Text);

                    // Daca numarul din textbox este egal cu codul randului selectat updatam doar celelalte date
                    if (numarClicked == numarTextbox && numarFinder(numarTextbox))
                    {
                        intrari updateIntrare = dc.intraris.FirstOrDefault(nmr => nmr.numar == numarTextbox);
                        if (numarClicked == numarTextbox)
                        {
                            updateIntrare.data = DateTime.Now;
                            updateIntrare.partener = (int)cmbPartener.SelectedValue;
                            updateIntrare.gestiune = (int)cmbGestiune.SelectedValue;
                        }

                        dc.SubmitChanges();
                        this.Close();
                    }

                    // Daca numarul nu este acelasi updatam randul selectat cu valoarea din textbox
                    else if (numarTextbox != numarClicked && isUpdate > 0)
                    {
                        // Verificam daca numarul nou exista deja in coloana
                        if (numarFinder(numarTextbox) == false)
                        {
                            intrari updateIntrare = dc.intraris.FirstOrDefault(nmr => nmr.numar == numarClicked);
                            updateIntrare.data = DateTime.Now;
                            updateIntrare.numar = int.Parse(txtNr.Text);
                            updateIntrare.partener = (int)cmbPartener.SelectedValue;
                            updateIntrare.gestiune = (int)cmbGestiune.SelectedValue;

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
                            intrari newIntrare = new intrari();

                            newIntrare.data = DateTime.Now;
                            newIntrare.partener = (int)cmbPartener.SelectedValue;
                            newIntrare.gestiune = (int)cmbGestiune.SelectedValue;
                            newIntrare.numar = int.Parse(txtNr.Text);

                            dc.intraris.InsertOnSubmit(newIntrare);
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
