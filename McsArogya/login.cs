using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace McsArogya
{
    
    public partial class login : Form
    {
        public static int tcount = 5;
        DbAccess db = new DbAccess();
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            makeAuth();
        }

        private void makeAuth()
        {
            string u = txtUser.Text;
            string p = txtPassword.Text;
            DataTable dt = new DataTable();
            string query = "Select * from users where username = '" + u + "' and password = '" + p + "'";
            db.readDatathroughAdapter(query, dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                home h = new home();
                h.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials\n Enter valid username and password", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                makeAuth();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
