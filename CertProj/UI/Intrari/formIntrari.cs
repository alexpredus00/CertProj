using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CertProj.UI
{
    public partial class formIntrari : Form
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
        public formIntrari()
        {
            InitializeComponent();

        }

        // Initialize DataContext
        sampleDataContext dc = new sampleDataContext();

        // Exit button
        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh master table
        public void SelectMaster()
        {
            dc = new sampleDataContext();
            var selectQuery = from a in dc.GetTable<intrari>()
                              select a;
            dgvMaster.DataSource = selectQuery.ToList();

            dgvMaster.Columns["gestiuni"].Visible = false;
            dgvMaster.Columns["parteneri"].Visible = false;
            dgvMaster.Columns["id"].Visible = false;

        }

        // Refresh Details Table
        private void SelectDetails(int id)
        {
            dc = new sampleDataContext();
            var selectQuery = from a in dc.GetTable<intrari_detaliu>()
                              where a.id_intrari == id // Filter the query based on the id
                              select a;

            dgvDetails.DataSource = selectQuery.ToList();

            // afisam doar campurile care il intereseaza pe utilizator
            dgvDetails.Columns["intrari"].Visible = false;
            dgvDetails.Columns["produse"].Visible = false;
            dgvDetails.Columns["id"].Visible = false;
        }

        // Ia datele din datagrid Master
        private void dgvMaster_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            rowIndexClicked = (int)dgvMaster.Rows[rowIndex].Cells[0].Value;

            // Variables used for add/update buttons
            idPartener = (int)dgvMaster.Rows[rowIndex].Cells[2].Value;
            idGestiune = (int)dgvMaster.Rows[rowIndex].Cells[3].Value;
            idNumar = rowIndexClicked;
            idIntrare = (int)dgvMaster.Rows[rowIndex].Cells[4].Value;
            txtNrIntrare.Text = idNumar.ToString();

            // Fill comboboxes
            cmbPartener.SelectedValue = idPartener;
            cmbGestiune.SelectedValue = idGestiune;
            cmbProdus.SelectedValue = 0;

            // Refresh DETAILS datagrid
            SelectDetails(idIntrare);

        }

        // Ia datele din datagrid DETAILS
        private void dgvDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var produse = from g in dc.produses
                          select new
                          {
                              id = g.id,
                              Denumire = g.denumire
                          };

            cmbProdus.DataSource = produse.ToList();
            cmbProdus.DisplayMember = "Denumire";
            cmbProdus.ValueMember = "id";
            cmbProdus.SelectedValue = (int)dgvDetails.Rows[rowIndex].Cells[1].Value;

            idIntrareDetaliu = (int)dgvDetails.Rows[rowIndex].Cells[4].Value;
            idProdus = cmbProdus.SelectedValue != null ? (int)cmbProdus.SelectedValue : 0;
            idCantitate = (decimal)dgvDetails.Rows[rowIndex].Cells[2].Value;

        }
        // Load table and comboboxes
        private void intrari_Load(object sender, EventArgs e)
        {
            SelectMaster();
            IncarcaCombobox();
        }

        // Master Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            intrariMasterAdd intrariMasterAdd = new intrariMasterAdd(idPartener.ToString(), idGestiune.ToString(), idNumar.ToString(), 0);
            idNumar = 0;
            intrariMasterAdd.Show();
        }

        // Master update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idNumar != 0)
            {
                intrariMasterAdd intrariMasterAdd = new intrariMasterAdd(idPartener.ToString(), idGestiune.ToString(), idNumar.ToString(), 1);
                idNumar = 0;
                idGestiune = 0;
                intrariMasterAdd.Show();
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati un rand.");
            }
        }

        // Master Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                intrari deleteIntrare = dc.intraris.FirstOrDefault(intr => intr.numar.Equals(rowIndexClicked));
                dc.intraris.DeleteOnSubmit(deleteIntrare);

                var deleteIntrari_detaliu = dc.intrari_detalius.Where(intr => intr.id_intrari == deleteIntrare.id).ToList();
                dc.intrari_detalius.DeleteAllOnSubmit(deleteIntrari_detaliu);
                idNumar = 0;

                dc.SubmitChanges();
                SelectMaster();
                SelectDetails(idIntrare);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Refresh datagrids when changes are made
        private void formIntrari_Activated(object sender, EventArgs e)
        {
            SelectMaster();
            SelectDetails(idIntrare);
        }

        // Variables used in frmMasterAdd and frmDetailsAdd
        int rowIndexClicked;
        int idPartener;
        int idGestiune;
        int idNumar;
        int idIntrare;
        int idIntrareDetaliu = 0;
        int idProdus = 0;
        decimal idCantitate = 0;


        // Fill comboboxes on load
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
                cmbPartener.DisplayMember = "Denumire"; // A fișeaza denumirea partenerului în ComboBox
                cmbPartener.ValueMember = "id"; // Returneaza codul partenerului atunci când este selectat
                cmbPartener.SelectedValue = 0;

                var gestiuni = from g in dc.gestiunis
                               select new
                               {
                                   id = g.id,
                                   Denumire = g.denumire
                               };

                cmbGestiune.DataSource = gestiuni.ToList();
                cmbGestiune.DisplayMember = "Denumire";
                cmbGestiune.ValueMember = "id";
                cmbGestiune.SelectedValue = 0;

            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }
        }

        // Getting data from DETAILS datagrid

        // Add DETAILS button
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (txtNrIntrare.Text != "")
            {
                intrariDetailsAdd intrariDetails = new intrariDetailsAdd(idIntrare.ToString(), idIntrareDetaliu, idProdus, idCantitate, 0);
                intrariDetails.Show();
                idIntrareDetaliu = 0;
                idGestiune = 0;
                idProdus = 0;
                idCantitate = 0;
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati o intrare.");
            }
        }

        // Update DETAILS 
        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (txtNrIntrare.Text != "" && idIntrareDetaliu != 0)
            {
                intrariDetailsAdd intrariDetails = new intrariDetailsAdd(idIntrare.ToString(), idIntrareDetaliu, idProdus, idCantitate, 1);
                idIntrareDetaliu = 0;
                idGestiune = 0;
                idProdus = 0;
                idCantitate = 0;
                intrariDetails.Show();
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati o intrare.");
            }
        }

        // Delete DETAILS
        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                intrari_detaliu deleteIntrare_detaliu = dc.intrari_detalius.FirstOrDefault(intr => intr.id.Equals(idIntrareDetaliu));

                dc.intrari_detalius.DeleteOnSubmit(deleteIntrare_detaliu);
                dc.SubmitChanges();
                SelectDetails(idIntrare);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trebuie sa selectati o intrare_detaliu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
