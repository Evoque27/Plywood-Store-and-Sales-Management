﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value >= 100)
            {
                progressBar1.Value = 100;
                timer1.Stop();
                this.Visible = false;
                frmSignIn fsignin = new frmSignIn();
                fsignin.Show();
                this.Hide();
                fsignin.Visible = true;
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
