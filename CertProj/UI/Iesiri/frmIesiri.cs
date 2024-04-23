using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertProj.UI.Iesiri;

namespace CertProj.UI
{
    public partial class frmIesiri : Form
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
        public frmIesiri()
        {
            InitializeComponent();
        }

        // Initalizam datacontext
        sampleDataContext dc = new sampleDataContext();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh MASTER datagrid
        public void SelectMaster()
        {
            dc = new sampleDataContext();
            var selectQuery = from a in dc.GetTable<iesiri>()
                              select a;
            dgvMaster.DataSource = selectQuery.ToList();

            dgvMaster.Columns["id"].Visible = false;
            dgvMaster.Columns["gestiuni"].Visible = false;
        }

        // Refresh DETAILS datagrid
        private void SelectDetails(int id)
        {
            if (id != 0)
            {
                dc = new sampleDataContext();
                var selectQuery = from a in dc.GetTable<iesiri_detaliu>()
                                  where a.id_iesiri == id
                                  select a;

                dgvDetails.DataSource = selectQuery.ToList();

                // afisam doar campurile care il intereseaza pe utilizator
                dgvDetails.Columns["id"].Visible = false;
                dgvDetails.Columns["id_intrare"].Visible = false;
                dgvDetails.Columns["iesiri"].Visible = false;
                dgvDetails.Columns["produse"].Visible = false;
                dgvDetails.Columns["intrari_detaliu"].Visible = false;
            }
        }

        // Luam datele din randul MASTER selectat
        private void dgvMaster_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            rowIndexClicked = (int)dgvMaster.Rows[rowIndex].Cells[0].Value;

            // Variables used for add/update buttons
            idGestiune = (int)dgvMaster.Rows[rowIndex].Cells[2].Value;
            idNumar = rowIndexClicked;
            idIesire = (int)dgvMaster.Rows[rowIndex].Cells[3].Value;
            txtNumarIesire.Text = idNumar.ToString();

            // Fill comboboxes
            cmbGestiune.SelectedValue = idGestiune;
            cmbProdus.SelectedValue = 0;

            // Refresh DETAILS datagrid
            SelectDetails(idIesire);
        }

        // Luam datele din campul DETAILS selectat
        private void dgvDetails_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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

            idIesireDetaliu = (int)dgvDetails.Rows[rowIndex].Cells[4].Value;
            idProdus = cmbProdus.SelectedValue != null ? (int)cmbProdus.SelectedValue : 0;
            idCantitate = (decimal)dgvDetails.Rows[rowIndex].Cells[2].Value;
            idIntrare = (int)dgvDetails.Rows[rowIndex].Cells[5].Value;
        }


        private void frmIesiri_Load(object sender, EventArgs e)
        {
            SelectMaster();
            IncarcaCombobox();
        }

        // Incarcam datele in combobox-uri
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
                cmbGestiune.SelectedValue = 0;
            }
            catch (Exception z)
            {
                MessageBox.Show("Eroare la încarcarea partenerilor: " + z.Message);
            }
        }

        // Variabile folosite pentru verificari
        int rowIndexClicked;
        int idGestiune;
        int idNumar;
        int idIesire;
        int idIesireDetaliu = 0;
        int idProdus;
        int idIntrare;
        decimal idCantitate = 0;

        private void frmIesiri_Activated(object sender, EventArgs e)
        {
            SelectMaster();
            SelectDetails(idIesire);
        }

        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            iesiriMaster iesiriMaster = new iesiriMaster(idGestiune.ToString(), idNumar.ToString(), 0);
            idNumar = 0;
            iesiriMaster.Show();
        }

        private void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            if (idNumar != 0)
            {
                iesiriMaster iesiriMaster = new iesiriMaster(idGestiune.ToString(), idNumar.ToString(), 1);
                idNumar = 0;
                idGestiune = 0;
                iesiriMaster.Show();
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati un rand.");
            }
        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            try
            {
                // Gasim randul
                iesiri deleteIesire = dc.iesiris.FirstOrDefault(intr => intr.numar.Equals(rowIndexClicked));
                dc.iesiris.DeleteOnSubmit(deleteIesire);

                idNumar = 0;

                dc.SubmitChanges();
                SelectMaster();
                SelectDetails(idIesire);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (txtNumarIesire.Text != "")
            {
                iesiriDetails iesiriDetails = new iesiriDetails(idIntrare, idIesire, idIesireDetaliu, idGestiune, idNumar, idCantitate, idProdus, 0);
                iesiriDetails.Show();
                idNumar = 0;
                //idGestiune = 0;
                idProdus = 0;
                idIesireDetaliu = 0;
                idCantitate = 0;
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati o iesire.");
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (txtNumarIesire.Text != "" && idIesireDetaliu != 0)
            {
                iesiriDetails iesiriDetails = new iesiriDetails(idIntrare, idIesire, idIesireDetaliu, idGestiune, idNumar, idCantitate, idProdus, 1);
                iesiriDetails.Show();

                SelectDetails(idIesire);
                idNumar = 0;
                idProdus = 0;
                idIesireDetaliu = 0;
                idCantitate = 0;
            }
            else
            {
                MessageBox.Show("Trebuie sa selectati o iesire.");
            }
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                iesiri_detaliu deleteIesire_detaliu = dc.iesiri_detalius.FirstOrDefault(intr => intr.id.Equals(idIesireDetaliu));

                dc.iesiri_detalius.DeleteOnSubmit(deleteIesire_detaliu);
                dc.SubmitChanges();
                SelectDetails(idIesire);
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
