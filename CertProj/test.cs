﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertProj
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            sampleDataContext dbContext = new sampleDataContext();
            var selectQuery = from a in dbContext.GetTable<produse>()
                              select a;

            dgvTest.DataSource = selectQuery;

        }
    }
}
