namespace CertProj.UI
{
    partial class frmProduse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblCod = new Label();
            txtCod = new TextBox();
            txtPretUnitar = new TextBox();
            lblPretUnitar = new Label();
            txtDenumire = new TextBox();
            lblDenumire = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dgvProduse = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduse).BeginInit();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = SystemColors.ButtonHighlight;
            lblCod.Location = new Point(448, 16);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(62, 31);
            lblCod.TabIndex = 1;
            lblCod.Text = "COD";
            // 
            // txtCod
            // 
            txtCod.BackColor = Color.FromArgb(74, 79, 99);
            txtCod.BorderStyle = BorderStyle.FixedSingle;
            txtCod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.ForeColor = Color.White;
            txtCod.Location = new Point(413, 50);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(125, 30);
            txtCod.TabIndex = 1;
            txtCod.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPretUnitar
            // 
            txtPretUnitar.BackColor = Color.FromArgb(74, 79, 99);
            txtPretUnitar.BorderStyle = BorderStyle.FixedSingle;
            txtPretUnitar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPretUnitar.ForeColor = Color.White;
            txtPretUnitar.Location = new Point(583, 50);
            txtPretUnitar.Name = "txtPretUnitar";
            txtPretUnitar.Size = new Size(125, 30);
            txtPretUnitar.TabIndex = 3;
            txtPretUnitar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPretUnitar
            // 
            lblPretUnitar.AutoSize = true;
            lblPretUnitar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPretUnitar.ForeColor = Color.White;
            lblPretUnitar.Location = new Point(616, 16);
            lblPretUnitar.Name = "lblPretUnitar";
            lblPretUnitar.Size = new Size(66, 31);
            lblPretUnitar.TabIndex = 3;
            lblPretUnitar.Text = "PRET";
            // 
            // txtDenumire
            // 
            txtDenumire.BackColor = Color.FromArgb(74, 79, 99);
            txtDenumire.BorderStyle = BorderStyle.FixedSingle;
            txtDenumire.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDenumire.ForeColor = Color.White;
            txtDenumire.Location = new Point(413, 130);
            txtDenumire.Name = "txtDenumire";
            txtDenumire.Size = new Size(295, 30);
            txtDenumire.TabIndex = 2;
            txtDenumire.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDenumire
            // 
            lblDenumire.AutoSize = true;
            lblDenumire.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDenumire.ForeColor = SystemColors.ButtonHighlight;
            lblDenumire.Location = new Point(497, 96);
            lblDenumire.Name = "lblDenumire";
            lblDenumire.Size = new Size(131, 31);
            lblDenumire.TabIndex = 5;
            lblDenumire.Text = "DENUMIRE";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(32, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(228, 65);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(46, 51, 73);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(32, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(228, 64);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 51, 73);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(32, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(228, 64);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(74, 79, 99);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(458, 205);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(326, 31);
            txtSearch.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 569);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 160);
            panel2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(82, 105);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 16;
            label2.Text = "PRODUSE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PngItem_3256236;
            pictureBox1.Location = new Point(93, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(800, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProduse
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvProduse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProduse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduse.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvProduse.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProduse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduse.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProduse.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProduse.EnableHeadersVisualStyles = false;
            dgvProduse.GridColor = Color.FromArgb(74, 79, 99);
            dgvProduse.Location = new Point(338, 253);
            dgvProduse.Name = "dgvProduse";
            dgvProduse.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProduse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduse.RowHeadersWidth = 51;
            dgvProduse.RowTemplate.Height = 29;
            dgvProduse.Size = new Size(446, 273);
            dgvProduse.TabIndex = 17;
            dgvProduse.RowHeaderMouseClick += dgvProduse_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(353, 202);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 18;
            label1.Text = "SEARCH";
            // 
            // frmProduse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(871, 569);
            Controls.Add(label1);
            Controls.Add(dgvProduse);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(txtPretUnitar);
            Controls.Add(txtSearch);
            Controls.Add(lblCod);
            Controls.Add(txtCod);
            Controls.Add(lblPretUnitar);
            Controls.Add(lblDenumire);
            Controls.Add(txtDenumire);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduse";
            Text = "MainForm";
            Load += frmProduse_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCod;
        private TextBox txtCod;
        private TextBox txtPretUnitar;
        private Label lblPretUnitar;
        private TextBox txtDenumire;
        private Label lblDenumire;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dgvProduse;
        private Label label1;
    }
}