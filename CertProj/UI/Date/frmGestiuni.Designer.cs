namespace CertProj.UI
{
    partial class frmGestiuni
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
            txtDenumire = new TextBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dgvGestiuni = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestiuni).BeginInit();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCod.ForeColor = Color.White;
            lblCod.Location = new Point(385, 47);
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
            txtCod.Location = new Point(334, 81);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(159, 30);
            txtCod.TabIndex = 2;
            txtCod.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDenumire
            // 
            txtDenumire.BackColor = Color.FromArgb(74, 79, 99);
            txtDenumire.BorderStyle = BorderStyle.FixedSingle;
            txtDenumire.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDenumire.ForeColor = Color.White;
            txtDenumire.Location = new Point(542, 81);
            txtDenumire.Name = "txtDenumire";
            txtDenumire.Size = new Size(159, 30);
            txtDenumire.TabIndex = 4;
            txtDenumire.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(560, 47);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 3;
            label1.Text = "DENUMIRE";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(74, 79, 99);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = SystemColors.ScrollBar;
            txtSearch.Location = new Point(398, 154);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(354, 38);
            txtSearch.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 58);
            btnAdd.TabIndex = 8;
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
            btnDelete.Location = new Point(30, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 58);
            btnDelete.TabIndex = 9;
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
            btnUpdate.Location = new Point(30, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 58);
            btnUpdate.TabIndex = 10;
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
            panel1.Size = new Size(230, 490);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 146);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(51, 100);
            label2.Name = "label2";
            label2.Size = new Size(143, 33);
            label2.TabIndex = 18;
            label2.Text = "GESTIUNI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview__1_;
            pictureBox1.Location = new Point(67, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(752, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 17;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvGestiuni
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvGestiuni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestiuni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGestiuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestiuni.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvGestiuni.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvGestiuni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGestiuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGestiuni.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGestiuni.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGestiuni.EnableHeadersVisualStyles = false;
            dgvGestiuni.GridColor = Color.FromArgb(74, 79, 99);
            dgvGestiuni.Location = new Point(279, 208);
            dgvGestiuni.Name = "dgvGestiuni";
            dgvGestiuni.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvGestiuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvGestiuni.RowHeadersWidth = 51;
            dgvGestiuni.RowTemplate.Height = 29;
            dgvGestiuni.Size = new Size(473, 243);
            dgvGestiuni.TabIndex = 18;
            dgvGestiuni.RowHeaderMouseClick += dgvGestiuni_RowHeaderMouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(293, 153);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 19;
            label3.Text = "SEARCH";
            // 
            // frmGestiuni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(827, 490);
            Controls.Add(label3);
            Controls.Add(dgvGestiuni);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(txtDenumire);
            Controls.Add(label1);
            Controls.Add(txtCod);
            Controls.Add(lblCod);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestiuni";
            Text = "frmGestiuni";
            Load += frmGestiuni_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGestiuni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCod;
        private TextBox txtCod;
        private TextBox txtDenumire;
        private Label label1;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private DataGridView dgvGestiuni;
        private Label label3;
    }
}