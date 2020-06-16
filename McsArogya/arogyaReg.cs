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
            groupBox1.TabStop = false;
            groupBox2.TabStop = false;
            if (login.tcount < 0)
            {
                MessageBox.Show("Software is in protected mode", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
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
            string name, add, rc_type, bg, occ,mc_status,num,gdr;
            long con = -1, aadh = -1, acard = -1;
            int ag = -1,pd;

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
            if (anum.Text.Equals("") || contact.Text.Equals("") || aadhar.Text.Equals("") || age.Text.Equals("") || paid.Text.Equals("") || gender.Text.Equals("") || ar_card.Text.Equals("") )
            {
                MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                num = anum.Text;
                con = long.Parse(contact.Text);
                aadh = long.Parse(aadhar.Text);
                ag = int.Parse(age.Text);
                pd = int.Parse(paid.Text);
                gdr = gender.Text;
                acard = int.Parse(ar_card.Text);
                if (name.Equals("") || add.Equals("") || rc_type.Equals("") || bg.Equals("") || occ.Equals("") || mc_status.Equals("") )
                {
                    MessageBox.Show("Empty field detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(bg.Equals("--"))
                {
                    MessageBox.Show("Please select the blood group", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    addToDb(name, add, rc_type, bg, occ, mc_status, num, con,ag, aadh,gdr,pd,acard);
                }
            }     
        }

        private void addToDb(string name, string add, string rc_type, string bg, string occ, string mc_status, string num, long con,int ag, long aadh,string gdr,int pd,long acard)
        {
            int status = -1;
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("INSERT INTO members VALUES (@num,@name,@add,@con,@age,@aadh,@rc_type,@mc_status,@bg,@occ,@gdr,@pd,DEFAULT,@ac);");
            com.Parameters.AddWithValue("@num", num);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@add", add);
            com.Parameters.AddWithValue("@rc_type", rc_type);
            com.Parameters.AddWithValue("@con", con);
            com.Parameters.AddWithValue("@age", ag);
            com.Parameters.AddWithValue("@aadh", aadh);
            com.Parameters.AddWithValue("@mc_status", mc_status);
            com.Parameters.AddWithValue("@bg", bg);
            com.Parameters.AddWithValue("@occ", occ);
            com.Parameters.AddWithValue("@gdr", gdr);
            com.Parameters.AddWithValue("@pd", pd);
            com.Parameters.AddWithValue("@ac", acard);
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
                string s = e.ToString();
                System.Console.WriteLine(s);
                MessageBox.Show("SQL Exception Occured\nPossible Reasons\n1. Entry already exists\n", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void anum_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                System.Console.WriteLine("Numeric");
                e.Handled = true;
            }*/
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
            age.Text = "";
            apl.Checked = true;
            yes.Checked = true;
            bloodGroup.SelectedIndex = 0;
        }

        private void anum_TextChanged(object sender, EventArgs e)
        {

        }

        private void anum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                System.Console.WriteLine("Enter pressed");
                DbAccess db = new DbAccess();
                string id = anum.Text.ToString();
                System.Console.WriteLine("id = "+id);
                string qry = "Select * from memdata where reg_no = '"+id+"';";
                DataTable dt = new DataTable();
                db.readDatathroughAdapter(qry, dt);
                if(dt.Rows.Count != 0)
                {
                    aname.Text = dt.Rows[0]["name"].ToString();
                    address.Text = dt.Rows[0]["address"].ToString();
                    occupation.Text = dt.Rows[0]["occupation"].ToString();
                    gender.Text = dt.Rows[0]["gender"].ToString();
                    bloodGroup.Text = "--";
                }
                else
                {
                    aname.Text = "";
                    address.Text = "";
                    occupation.Text = "";
                    gender.Text = "";
                    bloodGroup.Text = "--";
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void aadhar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
