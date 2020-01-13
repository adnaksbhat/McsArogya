﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arogyaReg ar = new arogyaReg();
            this.Hide();
            ar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("You are about to logout", "MCS-Arogya", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                login l = new login();
                l.Show();
                MessageBox.Show("Logged Out Successfully", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arogyaClaim ac = new arogyaClaim();
            this.Hide();
            ac.Show();
        }
    }
}
