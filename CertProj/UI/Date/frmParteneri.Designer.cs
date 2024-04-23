namespace CertProj.UI
{
    partial class frmParteneri
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
            txtAdresa = new TextBox();
            lblAdresa = new Label();
            txtCui = new TextBox();
            lblCui = new Label();
            txtDenumire = new TextBox();
            lblDenumire = new Label();
            txtSearch = new TextBox();
            dgvParteneri = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParteneri).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = Color.White;
            lblCod.Location = new Point(400, 26);
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
            txtCod.Location = new Point(340, 60);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(177, 30);
            txtCod.TabIndex = 1;
            txtCod.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.FromArgb(74, 79, 99);
            txtAdresa.BorderStyle = BorderStyle.FixedSingle;
            txtAdresa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdresa.ForeColor = Color.White;
            txtAdresa.Location = new Point(571, 142);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(177, 30);
            txtAdresa.TabIndex = 4;
            txtAdresa.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdresa.ForeColor = Color.White;
            lblAdresa.Location = new Point(604, 108);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(100, 31);
            lblAdresa.TabIndex = 3;
            lblAdresa.Text = "ADRESA";
            // 
            // txtCui
            // 
            txtCui.BackColor = Color.FromArgb(74, 79, 99);
            txtCui.BorderStyle = BorderStyle.FixedSingle;
            txtCui.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCui.ForeColor = SystemColors.Window;
            txtCui.Location = new Point(571, 60);
            txtCui.Name = "txtCui";
            txtCui.Size = new Size(177, 30);
            txtCui.TabIndex = 3;
            txtCui.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCui
            // 
            lblCui.AutoSize = true;
            lblCui.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCui.ForeColor = Color.White;
            lblCui.Location = new Point(642, 26);
            lblCui.Name = "lblCui";
            lblCui.Size = new Size(51, 31);
            lblCui.TabIndex = 5;
            lblCui.Text = "CUI";
            // 
            // txtDenumire
            // 
            txtDenumire.BackColor = Color.FromArgb(74, 79, 99);
            txtDenumire.BorderStyle = BorderStyle.FixedSingle;
            txtDenumire.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDenumire.ForeColor = Color.White;
            txtDenumire.Location = new Point(340, 142);
            txtDenumire.Name = "txtDenumire";
            txtDenumire.Size = new Size(177, 30);
            txtDenumire.TabIndex = 2;
            txtDenumire.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDenumire
            // 
            lblDenumire.AutoSize = true;
            lblDenumire.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDenumire.ForeColor = Color.White;
            lblDenumire.Location = new Point(371, 108);
            lblDenumire.Name = "lblDenumire";
            lblDenumire.Size = new Size(131, 31);
            lblDenumire.TabIndex = 7;
            lblDenumire.Text = "DENUMIRE";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(74, 79, 99);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(376, 205);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(455, 38);
            txtSearch.TabIndex = 5;
            // 
            // dgvParteneri
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvParteneri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvParteneri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParteneri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParteneri.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvParteneri.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvParteneri.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvParteneri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvParteneri.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvParteneri.DefaultCellStyle = dataGridViewCellStyle3;
            dgvParteneri.EnableHeadersVisualStyles = false;
            dgvParteneri.GridColor = Color.FromArgb(74, 79, 99);
            dgvParteneri.Location = new Point(271, 249);
            dgvParteneri.Name = "dgvParteneri";
            dgvParteneri.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvParteneri.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvParteneri.RowHeadersWidth = 51;
            dgvParteneri.RowTemplate.Height = 29;
            dgvParteneri.Size = new Size(560, 273);
            dgvParteneri.TabIndex = 11;
            dgvParteneri.RowHeaderMouseClick += dgvParteneri_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(23, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 55);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(46, 51, 73);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(23, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 55);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 51, 73);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(23, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 55);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 561);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 154);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(120, 102);
            label1.Name = "label1";
            label1.Size = new Size(79, 33);
            label1.TabIndex = 21;
            label1.Text = "NERI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._361056;
            pictureBox1.Location = new Point(54, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(34, 102);
            label2.Name = "label2";
            label2.Size = new Size(95, 33);
            label2.TabIndex = 19;
            label2.Text = "PARTE";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(823, 20);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(271, 205);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 19;
            label3.Text = "SEARCH";
            // 
            // frmParteneri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(894, 561);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dgvParteneri);
            Controls.Add(txtSearch);
            Controls.Add(txtDenumire);
            Controls.Add(lblDenumire);
            Controls.Add(txtCui);
            Controls.Add(lblCui);
            Controls.Add(txtAdresa);
            Controls.Add(lblAdresa);
            Controls.Add(txtCod);
            Controls.Add(lblCod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmParteneri";
            Text = "frmParteneri";
            Load += frmParteneri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParteneri).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCod;
        private TextBox txtCod;
        private TextBox txtAdresa;
        private Label lblAdresa;
        private TextBox txtCui;
        private Label lblCui;
        private TextBox txtDenumire;
        private Label lblDenumire;
        private TextBox txtSearch;
        private DataGridView dgvParteneri;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}