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
    public partial class arogyaClaim : Form
    {
        public arogyaClaim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_name, s_add, s_dis, s_hosp;
            int s_age = -1;
            long s_anum = -1, s_acard = -1, s_contact = -1;

            s_name = aname.Text;
            s_add = add.Text;
            s_dis = ddesc.Text;
            s_hosp = thospital.Text;

            if ( s_name.Equals("") || s_add.Equals("") || s_dis.Equals("") || s_hosp.Equals(""))
            {
                MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if( age.Text.Equals("") || anum.Text.Equals("") || arcard.Text.Equals("") || contact.Text.Equals(""))
                {
                    MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    s_age = int.Parse(age.Text);
                    s_anum = long.Parse(anum.Text);
                    s_acard = long.Parse(arcard.Text);
                    s_contact = long.Parse(contact.Text);
                    addToDb(s_name, s_age, s_anum, s_acard, s_add, s_contact, s_dis, s_hosp);
                }
            }




        }

        private void addToDb(string s_name,int s_age,long s_num,long s_acard,string s_add,long s_contact,string s_dis,string s_hosp)
        {
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("INSERT INTO claimants VALUES(@s_num,@s_name,@s_age,@s_add,@s_acard,@s_contact,@s_dis,@s_hosp);");
            com.Parameters.AddWithValue("@s_num",s_num);
            com.Parameters.AddWithValue("@s_name", s_name);
            com.Parameters.AddWithValue("@s_age", s_age);
            com.Parameters.AddWithValue("@s_add", s_add);
            com.Parameters.AddWithValue("@s_acard", s_acard);
            com.Parameters.AddWithValue("@s_contact", s_contact);
            com.Parameters.AddWithValue("@s_dis", s_dis);
            com.Parameters.AddWithValue("@s_hosp", s_hosp);

            int res = db.executeQuery(com);

            if(res > 0)
            {
                MessageBox.Show("Record Added", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearAll()
        {
            aname.Text = "";
            age.Text = "";
            anum.Text = "";
            arcard.Text = "";
            add.Text = "";
            contact.Text = "";
            ddesc.Text = "";
            thospital.Text = "";
        }
        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void anum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void arcard_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
