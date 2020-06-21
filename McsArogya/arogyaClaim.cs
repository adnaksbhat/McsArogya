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
            if (login.tcount < 0)
            {
                MessageBox.Show("Software under test: Max Record Limit Reached", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            login.tcount--;
            string s_name, s_add, s_dis, s_hosp, s_anum,gdr;
            int s_age = -1,s_amt = -1;
            long s_acard = -1, s_contact = -1,s_aadhar = -1;

            s_name = aname.Text;
            s_add = add.Text;
            s_dis = ddesc.Text;
            s_hosp = thospital.Text;

            if(ddesc.Text.Equals("") && dinfo.Text.Equals(""))
            {
                MessageBox.Show("Please input disease information", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (s_name.Equals("") || s_add.Equals("") || s_dis.Equals("") || s_hosp.Equals(""))
                {
                    MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (amount.Text.Equals("") | age.Text.Equals("") || anum.Text.Equals("") || arcard.Text.Equals("") || contact.Text.Equals("") || gender.Text.Equals("") || aadhar.Text.Equals(""))
                    {
                        MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        s_amt = int.Parse(amount.Text);
                        s_age = int.Parse(age.Text);
                        s_anum = anum.Text;
                        s_acard = long.Parse(arcard.Text);
                        s_aadhar = long.Parse(aadhar.Text);
                        s_contact = long.Parse(contact.Text);
                        gdr = gender.Text;
                        addToDb(s_name, s_age, s_anum, s_acard, s_add, s_contact, s_dis, s_hosp, gdr, s_aadhar,s_amt);
                    }
                }
            }
        }

        private void addToDb(string s_name,int s_age,string s_num,long s_acard,string s_add,long s_contact,string s_dis,string s_hosp,string gdr,long s_aadhar,int s_amt)
        {
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("INSERT INTO claimants VALUES(@s_num,@s_name,@s_age,@s_add,@s_acard,@s_contact,@s_dis,@s_hosp,@gdr,@aadh,@amt);");
            com.Parameters.AddWithValue("@s_num",s_num);
            com.Parameters.AddWithValue("@s_name", s_name);
            com.Parameters.AddWithValue("@s_age", s_age);
            com.Parameters.AddWithValue("@s_add", s_add);
            com.Parameters.AddWithValue("@s_acard", s_acard);
            com.Parameters.AddWithValue("@s_contact", s_contact);
            com.Parameters.AddWithValue("@s_dis", s_dis);
            com.Parameters.AddWithValue("@s_hosp", s_hosp);
            com.Parameters.AddWithValue("@gdr", gdr);
            com.Parameters.AddWithValue("@aadh", s_aadhar);
            com.Parameters.AddWithValue("@amt", s_amt);
            SqlCommand com2 = new SqlCommand("UPDATE members set insurance_amt = insurance_amt - "+s_amt+" where anum = '"+s_num+"';");
            try
            {
                int res = db.executeQuery(com);
                int res2 = db.executeQuery(com2);
                if (res > 0 && res2 > 0)
                {
                    MessageBox.Show("Record Added", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                string s = e.ToString();
                MessageBox.Show("SQL Exception Occured\nPossible Reasons\n1. Entry already exists", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gender.Text = "";
            aadhar.Text = "";
            dinfo.Text = "";
            amount.Text = "";
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
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/

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

        private void arogyaClaim_Load(object sender, EventArgs e)
        {
            anum.Focus();
            if(login.tcount < 0)
            {
                MessageBox.Show("Software is in protected mode", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
        }

        private void anum_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    System.Console.WriteLine("Enter pressed");
                    DbAccess db = new DbAccess();
                    string id = anum.Text.ToString();
                    System.Console.WriteLine("id = " + id);
                    string qry = "Select * from members where anum = '" + id + "';";
                    DataTable dt = new DataTable();
                    db.readDatathroughAdapter(qry, dt);
                    if(dt.Rows.Count != 0)
                    {
                        anum.Text = dt.Rows[0]["anum"].ToString();
                        aname.Text = dt.Rows[0]["name"].ToString();
                        //age.Text = dt.Rows[0]["age"].ToString();
                        add.Text = dt.Rows[0]["address"].ToString();
                        contact.Text = dt.Rows[0]["contact"].ToString();
                        gender.Text = dt.Rows[0]["gender"].ToString();
                        arcard.Text = dt.Rows[0]["ar_card"].ToString();
                        aadhar.Text = dt.Rows[0]["aadhar"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Account number not registered", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine(ex);
                MessageBox.Show("SQL exception occured. Check logs", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disease ds = new disease("arogyaClaim");
            //ds.TopMost = true;
            ds.ShowDialog();
        }
    }
}
