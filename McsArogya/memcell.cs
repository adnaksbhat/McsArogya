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
            viewmem vm = new viewmem();
            this.Hide();
            vm.Show();
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
    }
}
