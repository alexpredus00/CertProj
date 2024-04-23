namespace CertProj.UI.Iesiri
{
    partial class iesiriMaster
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
            cmbGestiune = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            btnRenunta = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 62);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6276642;
            pictureBox1.Location = new Point(263, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 0;
            label1.Text = "ADAUGA IESIRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 106);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 2;
            label2.Text = "Numar iesire";
            // 
            // txtNr
            // 
            txtNr.BackColor = Color.FromArgb(74, 79, 99);
            txtNr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNr.ForeColor = Color.White;
            txtNr.Location = new Point(59, 137);
            txtNr.Name = "txtNr";
            txtNr.Size = new Size(194, 34);
            txtNr.TabIndex = 3;
            txtNr.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGestiune
            // 
            cmbGestiune.BackColor = Color.FromArgb(74, 79, 99);
            cmbGestiune.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbGestiune.ForeColor = Color.White;
            cmbGestiune.FormattingEnabled = true;
            cmbGestiune.Location = new Point(59, 210);
            cmbGestiune.Name = "cmbGestiune";
            cmbGestiune.Size = new Size(194, 36);
            cmbGestiune.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(110, 179);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 6;
            label4.Text = "Gestiune";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 30, 54);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(71, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 60);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRenunta
            // 
            btnRenunta.BackColor = Color.FromArgb(24, 30, 54);
            btnRenunta.FlatStyle = FlatStyle.Flat;
            btnRenunta.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRenunta.ForeColor = Color.White;
            btnRenunta.Location = new Point(87, 357);
            btnRenunta.Name = "btnRenunta";
            btnRenunta.Size = new Size(129, 60);
            btnRenunta.TabIndex = 8;
            btnRenunta.Text = "QUIT";
            btnRenunta.UseVisualStyleBackColor = false;
            btnRenunta.Click += btnRenunta_Click;
            // 
            // iesiriMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(309, 450);
            Controls.Add(btnRenunta);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtNr);
            Controls.Add(cmbGestiune);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "iesiriMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iesiriMaster";
            Load += iesiriMaster_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNr;
        private ComboBox cmbGestiune;
        private Label label4;
        private Button btnSave;
        private Button btnRenunta;
    }
}