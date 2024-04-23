using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CertProj.UI
{
    public partial class intrariDetailsAdd : Form
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
        int idNumar;
        int idDetaliu;
        int isUpdate;
        int idProdus;
        decimal idCantitate;
        public intrariDetailsAdd(string id, int idIntrareDetaliu, int produs, decimal cantitate, int update)
        {
            InitializeComponent();
            idNumar = int.Parse(id);
            idDetaliu = idIntrareDetaliu;
            idProdus = produs;
            idCantitate = cantitate;
            isUpdate = update;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Initializam datacontext
        sampleDataContext dc = new sampleDataContext();

        // Incarcam combobox-ul
        private void IncarcaCombobox()
        {
            try
            {
                // Query LINQ pentru a selecta codul și denumirea partenerilor
                var produse = from p in dc.produses
                              select new
                              {
                                  id = p.id,
                                  Denumire = p.denumire
                              };

                // Ataseaza rezultatul query-ului la sursa de date a ComboBox-ului
                cmbProdus.DataSource = produse.ToList();
                cmbProdus.DisplayMember = "Denumire"; // A fișeaza denumirea partenerului în ComboBox
                cmbProdus.ValueMember = "id"; // Returneaza codul partenerului atunci când este selectat

                // Incarcam combobox-ul cu valoarea randului selectat daca este UPDATE
                if(isUpdate == 1) {
                    cmbProdus.SelectedValue = idProdus;
                    txtCantitate.Text = idCantitate.ToString();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }

        }

        private void intrariDetailsAdd_Load(object sender, EventArgs e)
        {
            IncarcaCombobox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            // Verificam daca campurile sunt completate
            if (cmbProdus.Text != "" && txtCantitate.Text != "")
            {
                try
                {   // Daca isUpdate > 0 updatam randul dupa id-ul randului selectat 
                    if (idDetaliu > 0 && isUpdate == 1) //
                    {
                        intrari_detaliu updateIntrareDetaliu = dc.intrari_detalius.FirstOrDefault(nmr => nmr.id == idDetaliu);
                        updateIntrareDetaliu.produs = (int)cmbProdus.SelectedValue;
                        updateIntrareDetaliu.cantitate = int.Parse(txtCantitate.Text);
                        updateIntrareDetaliu.valoare = decimal.Parse(updateIntrareDetaliu.cantitate.ToString()) * FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0);

                        dc.SubmitChanges();
                        this.Close();
                    }
                    // Adaugam rand nou
                    else if (isUpdate == 0)
                    {
                        intrari_detaliu newIntrare_detaliu = new intrari_detaliu();

                        newIntrare_detaliu.id_intrari = idNumar;
                        newIntrare_detaliu.produs = int.TryParse(cmbProdus.SelectedValue?.ToString(), out int produsId) ? produsId : 0;
                        newIntrare_detaliu.cantitate = int.Parse(txtCantitate.Text);

                        // Calculam valoare = cantitate * pret_unitar
                        newIntrare_detaliu.valoare = FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0) * decimal.Parse(txtCantitate.Text);

                        dc.intrari_detalius.InsertOnSubmit(newIntrare_detaliu);
                        dc.SubmitChanges();
                        this.Close();
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

        // Gasim pretul unitar dupa codul produsului din intrari_detaliu
        public decimal? FindPretUnitar(int codProdus)
        {
            var produsCautat = dc.produses.FirstOrDefault(p => p.id == codProdus);

            if (produsCautat != null)
            {
                return produsCautat.pret_unitar;
            }
            else
            {
                throw new Exception("Produsul nu a fost găsit în baza de date.");
            }
        }

        // Updateaza live pretul dupa cantitatea selectat
        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValoare.Text = (FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0) * decimal.Parse(txtCantitate.Text)).ToString();
            }
            catch
            {
                txtValoare.Text = "0";
            }
        }

        // Updateaza live pretul dupa produsul selectat
        private void cmbProdus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValoare.Text = (FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0) * decimal.Parse(txtCantitate.Text)).ToString();
            }
            catch
            {
                txtValoare.Text = "0";
            }
        }
    }
}

