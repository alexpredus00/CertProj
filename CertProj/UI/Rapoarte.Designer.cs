namespace CertProj.UI
{
    partial class Rapoarte
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
            rdListaIntrari = new RadioButton();
            rdListaIesiri = new RadioButton();
            dtpInceput = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpSfarsit = new DateTimePicker();
            cmbGestiune = new ComboBox();
            lblGestiune = new Label();
            rdGestiuni = new RadioButton();
            rdGestiune = new RadioButton();
            btnAccepta = new Button();
            btnListeaza = new Button();
            gbLista = new GroupBox();
            gbGestiune = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgv = new DataGridView();
            button1 = new Button();
            gbLista.SuspendLayout();
            gbGestiune.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // rdListaIntrari
            // 
            rdListaIntrari.AutoSize = true;
            rdListaIntrari.Checked = true;
            rdListaIntrari.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdListaIntrari.ForeColor = Color.White;
            rdListaIntrari.Location = new Point(6, 17);
            rdListaIntrari.Name = "rdListaIntrari";
            rdListaIntrari.Size = new Size(151, 35);
            rdListaIntrari.TabIndex = 1;
            rdListaIntrari.TabStop = true;
            rdListaIntrari.Text = "Lista intrari";
            rdListaIntrari.UseVisualStyleBackColor = true;
            rdListaIntrari.CheckedChanged += rdListaIntrari_CheckedChanged;
            // 
            // rdListaIesiri
            // 
            rdListaIesiri.AutoSize = true;
            rdListaIesiri.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdListaIesiri.ForeColor = Color.White;
            rdListaIesiri.Location = new Point(6, 58);
            rdListaIesiri.Name = "rdListaIesiri";
            rdListaIesiri.Size = new Size(137, 35);
            rdListaIesiri.TabIndex = 2;
            rdListaIesiri.Text = "Lista iesiri";
            rdListaIesiri.UseVisualStyleBackColor = true;
            // 
            // dtpInceput
            // 
            dtpInceput.CalendarForeColor = Color.FromArgb(74, 79, 99);
            dtpInceput.Location = new Point(301, 235);
            dtpInceput.Name = "dtpInceput";
            dtpInceput.Size = new Size(250, 27);
            dtpInceput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 201);
            label2.Name = "label2";
            label2.Size = new Size(147, 31);
            label2.TabIndex = 2;
            label2.Text = "Data Inceput";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(649, 201);
            label3.Name = "label3";
            label3.Size = new Size(135, 31);
            label3.TabIndex = 4;
            label3.Text = "Data Sfarsit";
            // 
            // dtpSfarsit
            // 
            dtpSfarsit.CalendarForeColor = Color.FromArgb(74, 79, 99);
            dtpSfarsit.Location = new Point(585, 235);
            dtpSfarsit.Name = "dtpSfarsit";
            dtpSfarsit.Size = new Size(256, 27);
            dtpSfarsit.TabIndex = 5;
            // 
            // cmbGestiune
            // 
            cmbGestiune.BackColor = Color.FromArgb(74, 79, 99);
            cmbGestiune.FlatStyle = FlatStyle.Flat;
            cmbGestiune.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGestiune.ForeColor = Color.White;
            cmbGestiune.FormattingEnabled = true;
            cmbGestiune.Location = new Point(690, 91);
            cmbGestiune.Name = "cmbGestiune";
            cmbGestiune.Size = new Size(188, 36);
            cmbGestiune.TabIndex = 6;
            // 
            // lblGestiune
            // 
            lblGestiune.AutoSize = true;
            lblGestiune.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestiune.ForeColor = Color.White;
            lblGestiune.Location = new Point(737, 59);
            lblGestiune.Name = "lblGestiune";
            lblGestiune.Size = new Size(104, 31);
            lblGestiune.TabIndex = 2;
            lblGestiune.Text = "Gestiune";
            // 
            // rdGestiuni
            // 
            rdGestiuni.AutoSize = true;
            rdGestiuni.Checked = true;
            rdGestiuni.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdGestiuni.ForeColor = Color.White;
            rdGestiuni.Location = new Point(6, 14);
            rdGestiuni.Name = "rdGestiuni";
            rdGestiuni.Size = new Size(198, 35);
            rdGestiuni.TabIndex = 8;
            rdGestiuni.TabStop = true;
            rdGestiuni.Text = "Toate Gestiunile";
            rdGestiuni.UseVisualStyleBackColor = true;
            rdGestiuni.CheckedChanged += rdGestiuni_CheckedChanged;
            // 
            // rdGestiune
            // 
            rdGestiune.AutoSize = true;
            rdGestiune.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdGestiune.ForeColor = Color.White;
            rdGestiune.Location = new Point(6, 55);
            rdGestiune.Name = "rdGestiune";
            rdGestiune.Size = new Size(148, 35);
            rdGestiune.TabIndex = 9;
            rdGestiune.Text = "O Gestiune";
            rdGestiune.UseVisualStyleBackColor = true;
            // 
            // btnAccepta
            // 
            btnAccepta.BackColor = Color.FromArgb(46, 51, 73);
            btnAccepta.FlatStyle = FlatStyle.Popup;
            btnAccepta.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccepta.ForeColor = Color.White;
            btnAccepta.Location = new Point(22, 347);
            btnAccepta.Name = "btnAccepta";
            btnAccepta.Size = new Size(175, 51);
            btnAccepta.TabIndex = 10;
            btnAccepta.Text = "ACCEPTA";
            btnAccepta.UseVisualStyleBackColor = false;
            btnAccepta.Click += btnAccepta_Click;
            // 
            // btnListeaza
            // 
            btnListeaza.BackColor = Color.FromArgb(46, 51, 73);
            btnListeaza.FlatStyle = FlatStyle.Popup;
            btnListeaza.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnListeaza.ForeColor = Color.White;
            btnListeaza.Location = new Point(22, 404);
            btnListeaza.Name = "btnListeaza";
            btnListeaza.Size = new Size(175, 51);
            btnListeaza.TabIndex = 11;
            btnListeaza.Text = "LISTEAZA";
            btnListeaza.UseVisualStyleBackColor = false;
            btnListeaza.Click += btnListeaza_Click;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(rdListaIntrari);
            gbLista.Controls.Add(rdListaIesiri);
            gbLista.Location = new Point(256, 36);
            gbLista.Name = "gbLista";
            gbLista.Size = new Size(165, 96);
            gbLista.TabIndex = 12;
            gbLista.TabStop = false;
            // 
            // gbGestiune
            // 
            gbGestiune.Controls.Add(rdGestiune);
            gbGestiune.Controls.Add(rdGestiuni);
            gbGestiune.Location = new Point(441, 36);
            gbGestiune.Name = "gbGestiune";
            gbGestiune.Size = new Size(214, 96);
            gbGestiune.TabIndex = 13;
            gbGestiune.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAccepta);
            panel1.Controls.Add(btnListeaza);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 637);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 175);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.business_report_icon_vector_10473600;
            pictureBox1.Location = new Point(70, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 127);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 19;
            label1.Text = "RAPOARTE";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 79, 99);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(74, 79, 99);
            dgv.Location = new Point(262, 283);
            dgv.Name = "dgv";
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(616, 319);
            dgv.TabIndex = 21;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(833, 27);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 22;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Rapoarte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(931, 637);
            Controls.Add(button1);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Controls.Add(gbGestiune);
            Controls.Add(gbLista);
            Controls.Add(lblGestiune);
            Controls.Add(cmbGestiune);
            Controls.Add(label3);
            Controls.Add(dtpSfarsit);
            Controls.Add(label2);
            Controls.Add(dtpInceput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rapoarte";
            Text = "Rapoarte";
            Load += Rapoarte_Load;
            gbLista.ResumeLayout(false);
            gbLista.PerformLayout();
            gbGestiune.ResumeLayout(false);
            gbGestiune.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdListaIntrari;
        private RadioButton rdListaIesiri;
        private DateTimePicker dtpInceput;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpSfarsit;
        private ComboBox cmbGestiune;
        private Label lblGestiune;
        private RadioButton rdGestiuni;
        private RadioButton rdGestiune;
        private Button btnAccepta;
        private Button btnListeaza;
        private GroupBox gbLista;
        private GroupBox gbGestiune;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dgv;
        private Button button1;
        private PictureBox pictureBox1;
    }
}