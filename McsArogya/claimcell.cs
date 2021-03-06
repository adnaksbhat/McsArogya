﻿using System;
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
            viewclaim vc = new viewclaim();
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
            gender.Text = viewclaim.db_gender;
            aadhar.Text = viewclaim.db_aadhar.ToString();
            amount.Text = viewclaim.db_amt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ªÀÄÆqÀÄ©¢æ PÉÆÃ-D¥ÀgÉÃnÃªï ¸À«ð¸ï ¨ÁåAPï °.", new Font("Nudi 01 e", 20, FontStyle.Bold), Brushes.Black, 200, 50);
            e.Graphics.DrawString("PÀ®àªÀÈPÀë DgÉÆÃUÀå ¸ÀÄgÀPÀëvÁ PÁqÀÄð", new Font("Nudi 01 e", 14, FontStyle.Bold), Brushes.Black, 300, 80);
            e.Graphics.DrawString("PÉèÃªÀiï £ÀªÀÄÆ£É", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 360, 110);
            e.Graphics.DrawString("CzsÀåPÀëgÀÄ/ªÀÄÄRå PÁAiÀÄð¤ªÀðºÀuÁ¢üPÁj", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 200);
            e.Graphics.DrawString("JA.¹.J¸ï.¨ÁåAPï °.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 225);
            e.Graphics.DrawString("ªÀÄÆqÀÄ©¢gÉ EªÀjUÉ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 250);

            e.Graphics.DrawString("ªÀiÁ£ÀågÉÃ,", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 300);
            e.Graphics.DrawString("£Á£ÀÄ JA.¹.J¸ï.¨ÁåAQ£À°ègÀÄªÀ PÀ®àªÀÈPÀë DgÉÆÃUÀå AiÉÆÃd£ÉAiÀÄ ¸Ë®¨sÀå PÁqïð£ÀÄß ºÉÆA¢gÀÄvÉÛÃ£É. £Á£ÀÄ £À£Àß", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 70, 325);
            e.Graphics.DrawString("C£ÁgÉÆÃUÀåzÀ PÁgÀt ±À¸ÀÛçaQvÉìUÉ M¼À¥ÀnÖgÀÄvÉÛÃ£É. CzÀPÉÌ vÀUÀ°zÀ ªÉÊzÀåQÃAiÀÄ ªÉZÀÑUÀ¼À ©®è£ÀÄß FUÁUÀ¯ÉÃ ¥ÁªÀw¹gÀÄvÉÛÃ£É.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 350);
            e.Graphics.DrawString("AiÀÄ±À¹é AiÉÆÃd£ÉAiÀÄ°è ¸ÀÆa¸À®àlÖAvÉ aQvÉìUÉ vÀUÀ°zÀ ªÉÆ§®UÀ£ÀÄß AiÉÆÃd£ÉAiÀÄ ¤AiÀÄªÀÄzÀ ¥ÀæPÁgÀ £À£ÀUÉ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 375);
            e.Graphics.DrawString("»AwgÀÄV¸À¨ÉÃPÁV ¤ªÀÄä°è «£ÀAw¹PÉÆ¼ÀÄîwÛzÉÝÃ£É. aQvÉìUÉ ¸ÀA§AzsÀ¥ÀlÖ J¯Áè zÁR¯ÉUÀ¼À£ÀÄß ªÀÄvÀÄÛ ªÉÊzÁå¢üPÁjUÀ¼À", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 400);
            e.Graphics.DrawString("ªÀgÀ¢AiÀÄ£ÀÄß EzÀgÉÆA¢UÉ ®VÛÃPÀj¹zÉÝÃ£É.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 425);
            

            e.Graphics.DrawString("ºÉ¸ÀgÀÄ  : " + viewclaim.db_name, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 500);

            e.Graphics.DrawString("¥ÁæAiÀÄ  : " + viewclaim.db_age, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 530);
            e.Graphics.DrawString("¸ÀzÀ¸ÀåvÀé ¸ÀASÉå :  " + viewclaim.db_anum, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 600, 530);

            e.Graphics.DrawString("DgÉÆÃUÀå PÁqïð£À ¸ÀASÉå  : " + viewclaim.db_a_card, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 560);

            e.Graphics.DrawString("«¼Á¸À  : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 590);
            e.Graphics.DrawString("" + viewclaim.db_address, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 120, 590);
            
            e.Graphics.DrawString("zÀÆgÀªÁtÂ ¸ÀASÉå  : " + viewclaim.db_contact, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 650);
            
            e.Graphics.DrawString("PÁ¬Ä¯ÉAiÀÄ «ªÀgÀ : " + viewclaim.db_d_desc, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 680);
            
            e.Graphics.DrawString("aQvÉì ¥ÀqÉzÀÄPÉÆAqÀ D¸ÀàvÉæAiÀÄ «ªÀgÀ : " + viewclaim.db_hosp_name, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 710);
            
            e.Graphics.DrawString("F ªÉÄÃ°£À J¯Áè ªÀiÁ»wUÀ¼ÀÄ £À£Àß w¼ÀÄªÀ½PÉ ªÉÄÃgÉUÉ ¸ÀjAiÀiÁVzÉ JAzÀÄ zÀÈrüÃPÀj¸ÀÄvÉÛÃ£É.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 130, 800);

            e.Graphics.DrawString("¢£ÁAPÀ : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 950);
            e.Graphics.DrawString("vÀªÀÄä «±Áé", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 700, 950);
            e.Graphics.DrawString("¸ÀÜ¼À : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 1000);
            e.Graphics.DrawString("CfðzÁgÀ ¸ÀzÀ¸Àå", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 700, 1050);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want To Delete Application Number : " + viewclaim.db_anum, "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                DbAccess db = new DbAccess();
                SqlCommand comm = new SqlCommand("DELETE FROM CLAIMANTS WHERE anum = '" + viewclaim.db_anum+"';");
                SqlCommand com2 = new SqlCommand("UPDATE members set insurance_amt = insurance_amt + " + int.Parse(amount.Text.ToString()) + " where anum = '" + anum.Text.ToString() + "';");
                int res = db.executeQuery(comm);
                int res2 = db.executeQuery(com2);
                if (res > 0 && res2 > 0)
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
            thospital.ReadOnly = false;
            gender.ReadOnly = false;
            aadhar.ReadOnly = false;
            amount.ReadOnly = false;

            button5.Visible = true;
            button6.Visible = true;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button7.Visible = true;
            dinfo.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login.tcount < 0)
            {
                MessageBox.Show("Software under test: Max Record Limit Reached", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Windows.Forms.Application.Exit();
            }
            login.tcount--;
            string s_anum,s_name, s_add, s_dis, s_hosp,gdr;
            int s_age = -1,s_amt = -1;
            long s_acard = -1, s_contact = -1, s_aadhar = -1;

            s_name = aname.Text;
            s_add = add.Text;
            s_dis = ddesc.Text;
            s_hosp = thospital.Text;
            gdr = gender.Text;

            if (ddesc.Text.Equals("") && dinfo.Text.Equals(""))
            {
                MessageBox.Show("Please input disease information", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (s_name.Equals("") || s_add.Equals("") || s_dis.Equals("") || s_hosp.Equals("") || gdr.Equals(""))
                {
                    MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (age.Text.Equals("") || anum.Text.Equals("") || arcard.Text.Equals("") || contact.Text.Equals("") || aadhar.Text.Equals("") || amount.Text.Equals(""))
                    {
                        MessageBox.Show("Empty Fields Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        s_aadhar = long.Parse(aadhar.Text);
                        s_age = int.Parse(age.Text);
                        s_anum = anum.Text;
                        s_acard = long.Parse(arcard.Text);
                        s_contact = long.Parse(contact.Text);
                        s_amt = int.Parse(amount.Text);
                        updateDb(s_name, s_age, s_anum, s_acard, s_add, s_contact, s_dis, s_hosp, gdr, s_aadhar, s_amt);
                    }
                }
            }
           

        }

        private void updateDb(string s_name, int s_age, string s_anum, long s_acard, string s_add, long s_contact, string s_dis, string s_hosp,string gdr,long s_aadhar,int s_amt)
        {
            DbAccess db = new DbAccess();
            DataTable dt = new DataTable();
            int final_amt;
            string query = "UPDATE claimants set name = @name, age = @age, address = @add, a_card = @ac, contact = @con, d_desc = @ddes, hosp_name = @hname,gender = @gdr,aadhar = @adhr,amount = @amt WHERE anum = @anum";
            SqlCommand comm = new SqlCommand(query);
            string qry = "SELECT amount from claimants where anum = '" + s_anum + "';";
            SqlDataReader reader = db.readDatathroughReader(qry);
            reader.Read();
            int result = reader.GetInt32(0);
            final_amt = result - s_amt;
            SqlCommand com2 = new SqlCommand("UPDATE members set insurance_amt = insurance_amt + " + final_amt + " where anum = '" + s_anum + "';");
            reader.Close();
            comm.Parameters.AddWithValue("@name", s_name);
            comm.Parameters.AddWithValue("@age", s_age);
            comm.Parameters.AddWithValue("@add", s_add);
            comm.Parameters.AddWithValue("@ac", s_acard);
            comm.Parameters.AddWithValue("@con", s_contact);
            comm.Parameters.AddWithValue("@ddes", s_dis);
            comm.Parameters.AddWithValue("@hname", s_hosp);
            comm.Parameters.AddWithValue("@anum", s_anum);
            comm.Parameters.AddWithValue("@gdr", gdr);
            comm.Parameters.AddWithValue("@adhr", s_aadhar);
            comm.Parameters.AddWithValue("@amt", s_amt);
            try
            {
                db.executeQuery(comm);
                db.executeQuery(com2);
                MessageBox.Show("Updation Successfull", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                this.Hide();
                viewclaim vc = new viewclaim();
                vc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!!", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aname.ReadOnly = true;
            age.ReadOnly = true;
            arcard.ReadOnly = true;
            add.ReadOnly = true;
            contact.ReadOnly = true;
            ddesc.ReadOnly = true;
            thospital.ReadOnly = true;
            gender.ReadOnly = true;

            button5.Visible = false;
            button6.Visible = false;
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            disease ds = new disease("claimcell");
            ds.ShowDialog();
        }
    }
}
