﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI1_3a
{
    public partial class frmDetails : Form
    {

        public frmDetails()
        {
        
            InitializeComponent();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.btnReset.Text = "Reset";
            this.btnReset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(200, 200);


        }

        private void frmDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye Bye");
        }
    }
}
