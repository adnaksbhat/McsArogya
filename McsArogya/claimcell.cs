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

            viewclaim vc = new viewclaim();
            this.Hide();
            vc.Show();
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
    }
}
