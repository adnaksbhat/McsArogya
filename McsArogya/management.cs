using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
        }

        private void management_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mdis md = new mdis();
            md.ShowDialog();        
        }
    }
}
