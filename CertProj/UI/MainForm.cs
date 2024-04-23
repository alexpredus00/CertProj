using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CertProj.UI
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            addMenuStrip();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            // Identificati elementul apasat din meniu
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            // Actioneaza în funcție de numele elementului de meniu
            switch (menuItem.Text)
            {
                case "Produse":
                    frmProduse frmProduse = new frmProduse();
                    frmProduse.Show();
                    break;
                case "Gestiuni":
                    frmGestiuni frmGestiuni = new frmGestiuni();
                    frmGestiuni.Show();
                    break;
                case "Parteneri":
                    frmParteneri frmParteneri = new frmParteneri();
                    frmParteneri.Show();
                    break;
                case "Intrari":
                    formIntrari formIntrari = new formIntrari();
                    formIntrari.Show();
                    break;
                case "Iesiri":
                    frmIesiri frmIesiri = new frmIesiri();
                    frmIesiri.Show();
                    break;
                case "Rapoarte":
                    Rapoarte rapoarte = new Rapoarte();
                    rapoarte.Show();
                    break;
            }
        }

        private void addMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);

            // Adăugați elementele de meniu
            ToolStripMenuItem nomenclatoare = new ToolStripMenuItem("Nomenclatoare");
            ToolStripMenuItem operatiuni = new ToolStripMenuItem("Operatiuni");

            nomenclatoare.DropDownItems.Add("Produse");
            nomenclatoare.DropDownItems.Add("Gestiuni");
            nomenclatoare.DropDownItems.Add("Parteneri");

            operatiuni.DropDownItems.Add("Intrari");
            operatiuni.DropDownItems.Add("Iesiri");
            operatiuni.DropDownItems.Add("Rapoarte");

            menuStrip.Items.Add(nomenclatoare);
            menuStrip.Items.Add(operatiuni);

            foreach (ToolStripMenuItem item in nomenclatoare.DropDownItems)
            {
                item.Click += Item_Click;
            }

            // Evenimentul de clic pentru elementele de meniu din operatiuni
            foreach (ToolStripMenuItem item in operatiuni.DropDownItems)
            {
                item.Click += Item_Click;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
