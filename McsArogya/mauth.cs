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
    public partial class mauth : Form
    {
        public mauth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            string u = "user";
            string p = pass.Text;
            DataTable dt = new DataTable();
            string query = "Select * from users where username = '" + u + "' and password = '" + p + "'";
            db.readDatathroughAdapter(query, dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                management m = new management();
                m.TopMost = true;
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
