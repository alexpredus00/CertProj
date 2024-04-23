namespace CertProj.UI.Iesiri
{
    partial class iesiriDetails
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCantitate = new TextBox();
            txtValoare = new TextBox();
            btnSave = new Button();
            btnQuit = new Button();
            cmbProdus = new ComboBox();
            dgvIntrariDetaliu = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIntrariDetaliu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 26);
            label1.Name = "label1";
            label1.Size = new Size(274, 31);
            label1.TabIndex = 0;
            label1.Text = "ADAUGA IESIRE DETALIU";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 74);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6276642;
            pictureBox1.Location = new Point(566, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 352);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 2;
            label2.Text = "Cantitate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(454, 352);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 3;
            label3.Text = "Valoare";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 352);
            label4.Name = "label4";
            label4.Size = new Size(87, 31);
            label4.TabIndex = 4;
            label4.Text = "Produs";
            // 
            // txtCantitate
            // 
            txtCantitate.BackColor = Color.White;
            txtCantitate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantitate.ForeColor = Color.Black;
            txtCantitate.Location = new Point(280, 386);
            txtCantitate.Name = "txtCantitate";
            txtCantitate.Size = new Size(125, 34);
            txtCantitate.TabIndex = 6;
            txtCantitate.TextAlign = HorizontalAlignment.Center;
            txtCantitate.TextChanged += txtCantitate_TextChanged;
            // 
            // txtValoare
            // 
            txtValoare.BackColor = Color.White;
            txtValoare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtValoare.ForeColor = Color.Black;
            txtValoare.Location = new Point(436, 386);
            txtValoare.Name = "txtValoare";
            txtValoare.Size = new Size(125, 34);
            txtValoare.TabIndex = 7;
            txtValoare.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 30, 54);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(175, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(266, 68);
            btnSave.TabIndex = 8;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(24, 30, 54);
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.FlatStyle = FlatStyle.Popup;
            btnQuit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(229, 532);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(149, 56);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // cmbProdus
            // 
            cmbProdus.BackColor = Color.White;
            cmbProdus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdus.FlatStyle = FlatStyle.Popup;
            cmbProdus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbProdus.ForeColor = Color.Black;
            cmbProdus.FormattingEnabled = true;
            cmbProdus.Location = new Point(56, 386);
            cmbProdus.Name = "cmbProdus";
            cmbProdus.Size = new Size(189, 36);
            cmbProdus.TabIndex = 10;
            cmbProdus.TextChanged += cmbProdus_TextChanged;
            // 
            // dgvIntrariDetaliu
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvIntrariDetaliu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIntrariDetaliu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIntrariDetaliu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIntrariDetaliu.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgvIntrariDetaliu.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvIntrariDetaliu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIntrariDetaliu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIntrariDetaliu.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvIntrariDetaliu.DefaultCellStyle = dataGridViewCellStyle3;
            dgvIntrariDetaliu.EnableHeadersVisualStyles = false;
            dgvIntrariDetaliu.GridColor = Color.FromArgb(74, 79, 99);
            dgvIntrariDetaliu.Location = new Point(34, 95);
            dgvIntrariDetaliu.Name = "dgvIntrariDetaliu";
            dgvIntrariDetaliu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvIntrariDetaliu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvIntrariDetaliu.RowHeadersWidth = 51;
            dgvIntrariDetaliu.RowTemplate.Height = 29;
            dgvIntrariDetaliu.Size = new Size(544, 241);
            dgvIntrariDetaliu.TabIndex = 23;
            dgvIntrariDetaliu.RowHeaderMouseClick += dgvIntrariDetaliu_RowHeaderMouseClick_1;
            // 
            // iesiriDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(618, 618);
            Controls.Add(dgvIntrariDetaliu);
            Controls.Add(cmbProdus);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            Controls.Add(txtValoare);
            Controls.Add(txtCantitate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "iesiriDetails";
            Text = "iesiriDetails";
            Load += iesiriDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIntrariDetaliu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCantitate;
        private TextBox txtValoare;
        private Button btnSave;
        private Button btnQuit;
        private ComboBox cmbProdus;
        private DataGridView dgvIntrariDetaliu;
    }
}