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
    public partial class claimcell : Form
    {
        public claimcell()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void claimcell_Load(object sender, EventArgs e)
        {
            anum.Text = viewclaim.db_anum.ToString();
            aname.Text = viewclaim.db_name;
            age.Text = viewclaim.db_age.ToString();
            arcard.Text = viewclaim.db_a_card.ToString();
            add.Text = viewclaim.db_address;
            contact.Text = viewclaim.db_contact.ToString();
            ddesc.Text = viewclaim.db_d_desc;
            thospital.Text = viewclaim.db_hosp_name;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mudbidri Co-Operative Service Bank Ltd.", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 250, 50);
            e.Graphics.DrawString("Aarogya Card", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 350, 80);
            e.Graphics.DrawString("Claim Form", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 360, 110);
            e.Graphics.DrawString(" Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has\n been the industry's standard dummy text ever since the 1500s, when an unknown printer took\n a galley of type and scrambled it to make a type specimen book. It has survived not only five\n centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It\n was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum \npassages, and more recently with desktop publishing software like Aldus PageMaker \nincluding versions of Lorem Ipsum.", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 200);

            e.Graphics.DrawString("Name : "+viewclaim.db_name, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 400);
            e.Graphics.DrawString("Age : " + viewclaim.db_age, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 700, 400);

            e.Graphics.DrawString("Application Number : " + viewclaim.db_anum, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 450);
            e.Graphics.DrawString("Aarogya Card Number : " + viewclaim.db_a_card, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 543, 450);

            e.Graphics.DrawString("Address : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 500);
            e.Graphics.DrawString("" + viewclaim.db_address, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 500);

            e.Graphics.DrawString("Contact : "+viewclaim.db_contact, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 580);

            e.Graphics.DrawString("Disease Name : " + viewclaim.db_d_desc, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 630);

            e.Graphics.DrawString("Hospital Name : " + viewclaim.db_hosp_name, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 680);

            e.Graphics.DrawString("The above details filled are correct as per my knowledge ", new Font("Arial", 14, FontStyle.Regular), Brushes.Red, 175, 730);

            e.Graphics.DrawString("Date : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 950);
            e.Graphics.DrawString("Place : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 20, 1000);
            e.Graphics.DrawString("Signature", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 700, 1000);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want To Delete Application Number : " + viewclaim.db_anum, "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                DbAccess db = new DbAccess();
                SqlCommand comm = new SqlCommand("DELETE FROM CLAIMANTS WHERE anum = " + viewclaim.db_anum);
                int res = db.executeQuery(comm);
                if (res > 0)
                {
                    MessageBox.Show("Application number : " + viewclaim.db_anum + " removed from database", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                viewclaim vc = new viewclaim();
                this.Hide();
                vc.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aname.ReadOnly = false;
            age.ReadOnly = false;
            arcard.ReadOnly = false;
            add.ReadOnly = false;
            contact.ReadOnly = false;
            ddesc.ReadOnly = false;
            thospital.ReadOnly = false;

            button5.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login.tcount < 0)
            {
                MessageBox.Show("Software under test: Max Record Limit Reached", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            login.tcount--;
            string s_name, s_add, s_dis, s_hosp;
            int s_age = -1;
            long s_anum = -1, s_acard = -1, s_contact = -1;

            s_name = aname.Text;
            s_add = add.Text;
            s_dis = ddesc.Text;
            s_hosp = thospital.Text;

            if (s_name.Equals("") || s_add.Equals("") || s_dis.Equals("") || s_hosp.Equals(""))
            {
                MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (age.Text.Equals("") || anum.Text.Equals("") || arcard.Text.Equals("") || contact.Text.Equals(""))
                {
                    MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    s_age = int.Parse(age.Text);
                    s_anum = long.Parse(anum.Text);
                    s_acard = long.Parse(arcard.Text);
                    s_contact = long.Parse(contact.Text);
                    updateDb(s_name, s_age, s_anum, s_acard, s_add, s_contact, s_dis, s_hosp);
                }
            }

        }

        private void updateDb(string s_name, int s_age, long s_anum, long s_acard, string s_add, long s_contact, string s_dis, string s_hosp)
        {
            DbAccess db = new DbAccess();
            DataTable dt = new DataTable();
            string query = "UPDATE claimants set name = @name, age = @age, address = @add, a_card = @ac, contact = @con, d_desc = @ddes, hosp_name = @hname WHERE anum = @anum";
            SqlCommand comm = new SqlCommand(query);
            comm.Parameters.AddWithValue("@name", s_name);
            comm.Parameters.AddWithValue("@age", s_age);
            comm.Parameters.AddWithValue("@add", s_add);
            comm.Parameters.AddWithValue("@ac", s_acard);
            comm.Parameters.AddWithValue("@con", s_contact);
            comm.Parameters.AddWithValue("@ddes", s_dis);
            comm.Parameters.AddWithValue("@hname", s_hosp);
            comm.Parameters.AddWithValue("@anum", s_anum);

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
