namespace CertProj
{
    partial class test
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
            dgvTest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTest).BeginInit();
            SuspendLayout();
            // 
            // dgvTest
            // 
            dgvTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTest.Location = new Point(370, 158);
            dgvTest.Name = "dgvTest";
            dgvTest.RowHeadersWidth = 51;
            dgvTest.RowTemplate.Height = 29;
            dgvTest.Size = new Size(300, 188);
            dgvTest.TabIndex = 0;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTest);
            Name = "test";
            Text = "test";
            Load += test_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTest;
    }
}