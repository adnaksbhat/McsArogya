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
    public partial class memcell : Form
    {
        public memcell()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void memcell_Load(object sender, EventArgs e)
        {
            aname.Text = viewmem.db_name;
            anum.Text = viewmem.db_anum.ToString();
            contact.Text = viewmem.db_contact.ToString();
            age.Text = viewmem.db_age.ToString();
            address.Text = viewmem.db_address;
            aadhar.Text = viewmem.db_aadhar.ToString();
            rc_type.Text = viewmem.db_rc_type;
            mc.Text = viewmem.db_mc_status;
            b_group.Text = viewmem.db_blood_group;
            occupation.Text = viewmem.db_occuptaion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mudbidri Co-Operative Service Bank Ltd.", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 250, 50);
            e.Graphics.DrawString("Aarogya Card", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 350, 80);
            e.Graphics.DrawString("Registration Form", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 335, 110);

            e.Graphics.DrawString(" Line1 " , new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 200);
            e.Graphics.DrawString(" Line2 " , new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 225);
            e.Graphics.DrawString(" Line3 " , new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 250);

            e.Graphics.DrawString("Applicant Name : " + viewmem.db_name, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 300);

            e.Graphics.DrawString("Application Number : " + viewmem.db_anum, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 350);
            e.Graphics.DrawString("Contact : " + viewmem.db_contact, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 550, 350);

            e.Graphics.DrawString("Age : " + viewmem.db_age, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 400);
            e.Graphics.DrawString("Aadhar Card Number : " + viewmem.db_aadhar, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 450, 400);

            e.Graphics.DrawString("Address : " + viewmem.db_address, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 450);

            e.Graphics.DrawString("Ration Card : " + viewmem.db_rc_type, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 550);

            e.Graphics.DrawString("Medical Certificate : " + viewmem.db_mc_status, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 600);

            e.Graphics.DrawString("Blood Group : " + viewmem.db_blood_group, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 650);
            e.Graphics.DrawString("Occupation : " + viewmem.db_occuptaion, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 550, 650);

            e.Graphics.DrawString(" Line1  " , new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 20, 700);
            e.Graphics.DrawString(" Line2 " , new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 20, 725);
            e.Graphics.DrawString(" Line3 " , new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 20, 750);

            e.Graphics.DrawString("Place : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 850);
            e.Graphics.DrawString("Date : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 875);
            e.Graphics.DrawString("Signature ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 650, 875);




        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want To Delete Application Number : " + viewmem.db_anum, "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                DbAccess db = new DbAccess();
                SqlCommand comm = new SqlCommand("DELETE FROM MEMBERS WHERE anum = " + viewmem.db_anum);
                int res = db.executeQuery(comm);
                if (res > 0)
                {
                    MessageBox.Show("Application number : "+ viewmem.db_anum +" removed from database", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                viewmem vm = new viewmem();
                this.Hide();
                vm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button4.Visible = false;
            button1.Visible = false;
            button3.Visible = false;

            aname.ReadOnly = false;
            contact.ReadOnly = false;
            age.ReadOnly = false;
            address.ReadOnly = false;
            aadhar.ReadOnly = false;
            rc_type.Visible = false;
            mc.Visible = false;
            b_group.Visible = false;
            occupation.ReadOnly = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            apl.Visible = true;
            bpl.Visible = true;
            yes.Visible = true;
            no.Visible = true;
            bloodGroup.Visible = true;

            string rcard, medc;
            rcard = rc_type.Text;
            medc = mc.Text;

            if (rcard.Equals("APL"))
            {
                apl.Checked = true;
            }
            else
            {
                bpl.Checked = true;
            }

            if(medc.Equals("yes"))
            {
                yes.Checked = true;
            }
            else
            {
                no.Checked = true;
            }

            string bdgrp;
            bdgrp = b_group.Text;
            bloodGroup.SelectedItem = bdgrp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login.tcount < 0)
            {
                MessageBox.Show("Software under test: Max Record Limit Reached", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            login.tcount--;
            string name, add, rc_type, bg, occ, mc_status;
            long num = -1, con = -1, aadh = -1;
            int ag = -1;

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
            if (anum.Text.Equals("") || contact.Text.Equals("") || aadhar.Text.Equals("") || age.Text.Equals(""))
            {
                MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num = long.Parse(anum.Text);
                con = long.Parse(contact.Text);
                aadh = long.Parse(aadhar.Text);
                ag = int.Parse(age.Text);
                if (name.Equals("") || add.Equals("") || rc_type.Equals("") || bg.Equals("") || occ.Equals("") || mc_status.Equals(""))
                {
                    MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    editDb(name, add, rc_type, bg, occ, mc_status, num, con, ag, aadh);
                }
            }
        }

        public void editDb(string name,string add,string rc_type,string bg,string occ,string mc_status, long num,long con,int ag,long aadh)
        {
            DbAccess db = new DbAccess();
            DataTable dt = new DataTable();
            string query = "UPDATE members set name = @name, address = @add, contact = @con, age = @ag, aadhar = @aadh, rc_type = @rc_type, mc_status = @mc_status, blood_group = @bg, occupation = @occ WHERE anum = @anum";
            SqlCommand comm = new SqlCommand(query);
            comm.Parameters.AddWithValue("@anum",num);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@add", add);
            comm.Parameters.AddWithValue("@rc_type",rc_type);
            comm.Parameters.AddWithValue("@bg", bg);
            comm.Parameters.AddWithValue("@occ", occ);
            comm.Parameters.AddWithValue("@mc_status", mc_status);
            comm.Parameters.AddWithValue("@con", con);
            comm.Parameters.AddWithValue("@ag", ag);
            comm.Parameters.AddWithValue("@aadh", aadh);
            try
            {
                db.executeQuery(comm);
                MessageBox.Show("Updation Successfull", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!!", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
