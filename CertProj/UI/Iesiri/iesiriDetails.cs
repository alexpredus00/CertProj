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
    public partial class iesiriDetails : Form
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


        int idGestiune;
        int idNumar;
        int isUpdate;
        int idIesire;
        int idIesireDetaliu;
        decimal idCantitate;
        int idProdus;
        int idIntrare;
        public iesiriDetails(int idIntr, int idIesir, int idIesirDetaliu, int idGesti, int idNr, decimal idCant, int idPrds, int isUp)
        {
            InitializeComponent();
            idGestiune = idGesti;
            idNumar = idNr;
            isUpdate = isUp;
            idIesire = idIesir;
            idIesireDetaliu = idIesirDetaliu;
            idCantitate = idCant;
            idProdus = idPrds;
            idIntrare = idIntr;
        }

        // Initializam datacontext
        sampleDataContext dc = new sampleDataContext();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh datagrid intraridetaliu
        public void Select()
        {   // Afisam toate randurile
            if (isUpdate == 0)
            {
                var selectQuery = from detaliu in dc.GetTable<intrari_detaliu>()
                                  join intrare in dc.GetTable<intrari>() on detaliu.id_intrari equals intrare.id
                                  where intrare.gestiune == idGestiune
                                  select detaliu;

                dgvIntrariDetaliu.DataSource = selectQuery.ToList();
            }
            // Daca e update afisam doar randul selectat de user
            else
            {
                IncarcaCombobox();
                cmbProdus.SelectedValue = idProdus;
                var selectQuery = from detaliu in dc.GetTable<intrari_detaliu>()
                                  join intrare in dc.GetTable<intrari>() on detaliu.id_intrari equals intrare.id
                                  where intrare.gestiune == idGestiune && detaliu.id == idIntrare
                                  select detaliu;
                dgvIntrariDetaliu.DataSource = selectQuery.ToList();
            }
        }

        private void iesiriDetails_Load(object sender, EventArgs e)
        {
            Select();

            // Valoarea produsului poate fi modificata doar apasand pe datagrid
            cmbProdus.Enabled = false;

            dgvIntrariDetaliu.Columns["id"].Visible = false;
            dgvIntrariDetaliu.Columns["intrari"].Visible = false;
            dgvIntrariDetaliu.Columns["produse"].Visible = false;
        }

        decimal cantitate;
        string produs;
        decimal valoare;

        // Updatam live pretul cand se schimba cantitatea
        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValoare.Text = (FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0) * decimal.Parse(txtCantitate.Text)).ToString();
            }
            catch { }
        }

        // Updatam live pretul cand se schimba produsul
        private void cmbProdus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtValoare.Text = (FindPretUnitar(int.TryParse(cmbProdus.SelectedValue?.ToString(), out int selectedProductId) ? selectedProductId : 0) * decimal.Parse(txtCantitate.Text)).ToString();
            }
            catch
            {

            }
        }

        // Gasim pretul dupa codul produsului
        public decimal? FindPretUnitar(int codProdus)
        {
            var produsCautat = dc.produses.FirstOrDefault(p => p.id == int.Parse(cmbProdus.SelectedValue.ToString()));

            if (produsCautat != null)
            {
                return produsCautat.pret_unitar;
            }
            else
            {
                throw new Exception("Produsul nu a fost găsit în baza de date.");
            }
        }

        // Incarcam combobox
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

                // Daca e update punem produsul din randul selectat in combobox
                if (isUpdate == 1)
                {
                    cmbProdus.SelectedValue = idProdus;
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }

        }

        private void dgvIntrariDetaliu_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            produs = dgvIntrariDetaliu.Rows[rowIndex].Cells[1].Value.ToString();
            cantitate = (decimal)dgvIntrariDetaliu.Rows[rowIndex].Cells[2].Value;
            valoare = (decimal)dgvIntrariDetaliu.Rows[rowIndex].Cells[3].Value / cantitate;

            IncarcaCombobox();
            if (isUpdate == 0)
            {

                cmbProdus.SelectedValue = int.Parse(produs);
                txtCantitate.Text = cantitate.ToString();
                txtValoare.Text = (valoare * cantitate).ToString();
                idIntrare = (int)dgvIntrariDetaliu.Rows[rowIndex].Cells[4].Value;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Verificam daca campurile sunt completate
            if (cmbProdus.Text != "" && txtCantitate.Text != "" && decimal.Parse(txtCantitate.Text) > 0)
            {
                try
                {   
                    if (idIesire > 0 && isUpdate == 1)
                    {
                        intrari_detaliu updateIntrareDetaliu = dc.intrari_detalius.FirstOrDefault(nmr => nmr.id == idIntrare);

                        // Luam cantitatea din intrare
                        decimal intrareCantitate = updateIntrareDetaliu.cantitate;
                        cantitate = decimal.Parse(txtCantitate.Text) - idCantitate;

                        // Verificam daca cantitatea ramasa da sub zero sau peste cantitatea originala
                        if (intrareCantitate >= cantitate && intrareCantitate - cantitate >= 0)
                        {
                            // Calculam cat mai ramane din cantitate si updatam intrarea
                            updateIntrareDetaliu.cantitate = intrareCantitate - cantitate;
                            updateIntrareDetaliu.valoare = (intrareCantitate - cantitate) * (updateIntrareDetaliu.valoare / intrareCantitate);

                            iesiri_detaliu updateIesireDetaliu = dc.iesiri_detalius.FirstOrDefault(isr => isr.id == int.Parse(idIesireDetaliu.ToString()));

                            // updatam iesirea_detaliu
                            updateIesireDetaliu.cantitate = int.Parse(txtCantitate.Text);
                            updateIesireDetaliu.valoare = decimal.Parse(txtCantitate.Text) * FindPretUnitar(idProdus);

                            dc.SubmitChanges();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cantitate invalida.");
                        }
                    }
                    // Adaugam iesire_detaliu noua
                    else if (isUpdate == 0)
                    {
                        intrari_detaliu updateIntrareDetaliu = dc.intrari_detalius.FirstOrDefault(nmr => nmr.id == idIntrare);

                        // Luam cantitatea din intrarea selectata de user
                        decimal intrareCantitate = updateIntrareDetaliu.cantitate;
                        cantitate = decimal.Parse(txtCantitate.Text);

                        // Verificam daca cantitatea ramase nu e sub 0 sau peste valoarea maxima
                        if (intrareCantitate >= cantitate && intrareCantitate - cantitate >= 0)
                        {
                            // Updatam intrarea cu cantitatea ramasa
                            updateIntrareDetaliu.cantitate = intrareCantitate - cantitate;
                            updateIntrareDetaliu.valoare = (intrareCantitate - cantitate) * (updateIntrareDetaliu.valoare / intrareCantitate);

                            // Cream o iesire_detaliu noua
                            iesiri_detaliu newIesireDetaliu = new iesiri_detaliu();
                            newIesireDetaliu.id_iesiri = idIesire;
                            newIesireDetaliu.produs = (int)cmbProdus.SelectedValue;
                            newIesireDetaliu.cantitate = decimal.Parse(txtCantitate.Text);
                            newIesireDetaliu.valoare = decimal.Parse(txtValoare.Text);
                            newIesireDetaliu.id_intrare = idIntrare;

                            dc.iesiri_detalius.InsertOnSubmit(newIesireDetaliu);
                            dc.SubmitChanges();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cantitate invalida.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr! \n \n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Campurile nu pot sa ramana goale.");
            }
        }
    }
}
