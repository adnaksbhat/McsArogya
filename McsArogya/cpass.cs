using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class cpass : Form
    {
        public cpass()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            curpass.Text = "";
            npass.Text = "";
            confpass.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string curp, newp, confp;
            curp = curpass.Text.ToString();
            newp = npass.Text.ToString();
            confp = confpass.Text.ToString();
            if(curp.Equals("") || newp.Equals("") || confp.Equals(""))
            {
                MessageBox.Show("Empty fields detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( newp != confp )
            {
                MessageBox.Show("Passwords dont match", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearAll();
            }
            else
            {
                DbAccess db = new DbAccess();
                string pass;
                SqlDataReader reader = db.readDatathroughReader("Select password from users where username = 'user';");
                reader.Read();
                pass = reader.GetString(0);
                reader.Close();
                if(pass != curp)
                {
                    MessageBox.Show("Incorrect Password", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearAll();
                }
                else
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("Update users set password = '" + npass.Text.ToString() + "' where username = 'user';");
                        db.executeQuery(com);
                        MessageBox.Show("Password changed successfully", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("SQL Exception occured\n"+ex.ToString(), "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearAll();
                    }
                }
            }
        }
    }
}
