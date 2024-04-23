namespace CertProj.UI
{
    partial class intrariMasterAdd
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
            txtNr = new TextBox();
            cmbPartener = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbGestiune = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 80);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6276642;
            pictureBox1.Location = new Point(291, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 23);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 1;
            label1.Text = "ADAUGA INTRARE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 119);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 1;
            label2.Text = "Nr. Intrare";
            // 
            // txtNr
            // 
            txtNr.BackColor = Color.FromArgb(74, 79, 99);
            txtNr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNr.ForeColor = Color.White;
            txtNr.Location = new Point(47, 153);
            txtNr.Name = "txtNr";
            txtNr.Size = new Size(231, 34);
            txtNr.TabIndex = 2;
            txtNr.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbPartener
            // 
            cmbPartener.BackColor = Color.FromArgb(74, 79, 99);
            cmbPartener.FlatStyle = FlatStyle.Flat;
            cmbPartener.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPartener.ForeColor = Color.White;
            cmbPartener.FormattingEnabled = true;
            cmbPartener.Location = new Point(47, 242);
            cmbPartener.Name = "cmbPartener";
            cmbPartener.Size = new Size(231, 36);
            cmbPartener.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(108, 208);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 6;
            label4.Text = "Partener";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(108, 297);
            label5.Name = "label5";
            label5.Size = new Size(104, 31);
            label5.TabIndex = 7;
            label5.Text = "Gestiune";
            // 
            // cmbGestiune
            // 
            cmbGestiune.BackColor = Color.FromArgb(74, 79, 99);
            cmbGestiune.FlatStyle = FlatStyle.Flat;
            cmbGestiune.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGestiune.ForeColor = Color.White;
            cmbGestiune.FormattingEnabled = true;
            cmbGestiune.Location = new Point(47, 331);
            cmbGestiune.Name = "cmbGestiune";
            cmbGestiune.Size = new Size(231, 36);
            cmbGestiune.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 30, 54);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 397);
            button1.Name = "button1";
            button1.Size = new Size(231, 76);
            button1.TabIndex = 9;
            button1.Text = "SALVEAZA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 30, 54);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(64, 479);
            button2.Name = "button2";
            button2.Size = new Size(198, 55);
            button2.TabIndex = 10;
            button2.Text = "RENUNTA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // intrariMasterAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(342, 574);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbGestiune);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbPartener);
            Controls.Add(txtNr);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "intrariMasterAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "intrariMasterAdd";
            Load += intrariMasterAdd_Load;
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
        private TextBox txtNr;
        private ComboBox cmbPartener;
        private Label label4;
        private Label label5;
        private ComboBox cmbGestiune;
        private Button button1;
        private Button button2;
    }
}