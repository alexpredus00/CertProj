namespace CertProj.UI
{
    partial class intrariDetailsAdd
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cmbProdus = new ComboBox();
            label3 = new Label();
            txtCantitate = new TextBox();
            btnSave = new Button();
            button1 = new Button();
            txtValoare = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 69);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6276642;
            pictureBox1.Location = new Point(260, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 22);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "Intrare Detaliu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 117);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 1;
            label2.Text = "Produs";
            // 
            // cmbProdus
            // 
            cmbProdus.BackColor = Color.FromArgb(46, 51, 73);
            cmbProdus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdus.FlatStyle = FlatStyle.Flat;
            cmbProdus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbProdus.ForeColor = Color.White;
            cmbProdus.FormattingEnabled = true;
            cmbProdus.Location = new Point(49, 151);
            cmbProdus.Name = "cmbProdus";
            cmbProdus.Size = new Size(217, 36);
            cmbProdus.TabIndex = 2;
            cmbProdus.TextChanged += cmbProdus_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(106, 201);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 3;
            label3.Text = "Cantitate";
            // 
            // txtCantitate
            // 
            txtCantitate.BackColor = Color.FromArgb(46, 51, 73);
            txtCantitate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantitate.ForeColor = Color.White;
            txtCantitate.Location = new Point(49, 235);
            txtCantitate.Name = "txtCantitate";
            txtCantitate.Size = new Size(217, 34);
            txtCantitate.TabIndex = 4;
            txtCantitate.TextAlign = HorizontalAlignment.Center;
            txtCantitate.TextChanged += txtCantitate_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 51, 73);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(49, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 66);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVEAZA";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(71, 447);
            button1.Name = "button1";
            button1.Size = new Size(170, 54);
            button1.TabIndex = 8;
            button1.Text = "RENUNTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtValoare
            // 
            txtValoare.BackColor = Color.FromArgb(46, 51, 73);
            txtValoare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtValoare.ForeColor = Color.White;
            txtValoare.Location = new Point(49, 315);
            txtValoare.Name = "txtValoare";
            txtValoare.ReadOnly = true;
            txtValoare.Size = new Size(217, 34);
            txtValoare.TabIndex = 10;
            txtValoare.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(106, 281);
            label5.Name = "label5";
            label5.Size = new Size(92, 31);
            label5.TabIndex = 9;
            label5.Text = "Valoare";
            // 
            // intrariDetailsAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 79, 99);
            ClientSize = new Size(316, 530);
            Controls.Add(txtValoare);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(txtCantitate);
            Controls.Add(label3);
            Controls.Add(cmbProdus);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "intrariDetailsAdd";
            Text = "intrariDetailsAdd";
            Load += intrariDetailsAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cmbProdus;
        private Label label3;
        private TextBox txtCantitate;
        private Button btnSave;
        private Button button1;
        private TextBox txtValoare;
        private Label label5;
    }
}