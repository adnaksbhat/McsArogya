using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace McsArogya
{
    public partial class arogyaReg : Form
    {
        public arogyaReg()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arogyaReg_Load(object sender, EventArgs e)
        {
            bloodGroup.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, add, rc_type, bg, occ,mc_status;
            long num = -1, con = -1, aadh = -1;

            name = aname.Text;
            add = address.Text;
            bg = bloodGroup.Text;
            occ = occupation.Text;

            if (apl.Checked)
            {
                rc_type = apl.Text;
            }
            else
            {
                rc_type = bpl.Text;
            }

            if (yes.Checked)
            {
                mc_status = yes.Text;
            }
            else
            {
                mc_status = no.Text;
            }
            if (anum.Text.Equals("") || contact.Text.Equals("") || aadhar.Text.Equals("") )
            {
                MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num = long.Parse(anum.Text);
                con = long.Parse(contact.Text);
                aadh = long.Parse(aadhar.Text);
                if (name.Equals("") || add.Equals("") || rc_type.Equals("") || bg.Equals("") || occ.Equals("") || mc_status.Equals(""))
                {
                    MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addToDb(name, add, rc_type, bg, occ, mc_status, num, con, aadh);
                }
            }     
        }

        private void addToDb(string name, string add, string rc_type, string bg, string occ, string mc_status, long num, long con, long aadh)
        {
            int status = -1;
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("INSERT INTO members VALUES (@num,@name,@add,@con,@aadh,@rc_type,@mc_status,@bg,@occ);");
            com.Parameters.AddWithValue("@num", num);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@add", add);
            com.Parameters.AddWithValue("@rc_type", rc_type);
            com.Parameters.AddWithValue("@con", con);
            com.Parameters.AddWithValue("@aadh", aadh);
            com.Parameters.AddWithValue("@mc_status", mc_status);
            com.Parameters.AddWithValue("@bg", bg);
            com.Parameters.AddWithValue("@occ", occ);
            try
            {
                status = db.executeQuery(com);

                if (status > 0)
                {
                    MessageBox.Show("Record Added", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backToInitial();
                }
                else
                {
                    MessageBox.Show("Something went wrong!!", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show("SQL Exception Occured\nPossible Reasons\n1. Entry already exists", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void anum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void aadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void backToInitial()
        {
            aname.Text = "";
            anum.Text = "";
            contact.Text = "";
            address.Text = "";
            aadhar.Text = "";
            occupation.Text = "";
            apl.Checked = true;
            yes.Checked = true;
            bloodGroup.SelectedIndex = 0;
        }
    }
}
