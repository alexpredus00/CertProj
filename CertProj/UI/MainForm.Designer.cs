namespace CertProj.UI
{
    partial class MainForm
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
            lblMainForm = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblMainForm
            // 
            lblMainForm.AutoSize = true;
            lblMainForm.BackColor = Color.FromArgb(24, 30, 54);
            lblMainForm.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainForm.ForeColor = Color.White;
            lblMainForm.Location = new Point(16, 138);
            lblMainForm.Name = "lblMainForm";
            lblMainForm.Padding = new Padding(5);
            lblMainForm.Size = new Size(204, 38);
            lblMainForm.TabIndex = 0;
            lblMainForm.Text = "Cert. Project";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Unispace", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 190);
            button1.Name = "button1";
            button1.Size = new Size(102, 44);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(232, 269);
            Controls.Add(button1);
            Controls.Add(lblMainForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMainForm;
        private Button button1;
    }
}