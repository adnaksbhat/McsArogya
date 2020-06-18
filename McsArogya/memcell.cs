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
            viewmem vm = new viewmem();
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
            gender.Text = viewmem.db_gender;
            paid.Text = viewmem.db_paid.ToString();
            ar_card.Text = viewmem.db_acard.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ªÀÄÆqÀÄ©¢æ PÉÆÃ-D¥ÀgÉÃnÃªï ¸À«ð¸ï ¨ÁåAPï °.", new Font("Nudi 01 e", 20, FontStyle.Bold), Brushes.Black, 200, 50);
            e.Graphics.DrawString("PÀ®àªÀÈPÀë DgÉÆÃUÀå ¸ÀÄgÀPÀëvÁ PÁqÀÄð", new Font("Nudi 01 e", 14, FontStyle.Bold), Brushes.Black, 300, 80);
            e.Graphics.DrawString("Cfð £ÀªÀÄÆ£É", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 360, 110);

            e.Graphics.DrawString("CzsÀåPÀëgÀÄ/ªÀÄÄRå PÁAiÀÄð¤ªÀðºÀuÁ¢üPÁj", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 175);
            e.Graphics.DrawString("JA.¹.J¸ï.¨ÁåAPï °.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 200);
            e.Graphics.DrawString("ªÀÄÆqÀÄ©¢gÉ EªÀjUÉ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 225);

            e.Graphics.DrawString("CfðzÁgÀ ¸ÀzÀ¸ÀågÀ ºÉ¸ÀgÀÄ : " + viewmem.db_name, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 300);

            e.Graphics.DrawString("¸ÀzÀ¸ÀåvÀé ¸ÀASÉå : " + viewmem.db_anum, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 340);
            e.Graphics.DrawString("zÀÆgÀªÁtÂ ¸ÀASÉå : " + viewmem.db_contact, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 500, 340);

            e.Graphics.DrawString("CfðzÁgÀgÀ ¥ÁæAiÀÄ : " + viewmem.db_age, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 380);
            e.Graphics.DrawString("DzsÁgï PÁqÀÄð ¸ÀASÉå : " + viewmem.db_aadhar, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 500, 380);

            e.Graphics.DrawString("«¼Á¸À  : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 420);
            e.Graphics.DrawString("" + viewmem.db_address, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 120, 420);

            e.Graphics.DrawString("CfðzÁgÀgÀÄ ©.¦.J¯ï./J.¦.J¯ï. PÁqÀÄðzÁgÀgÉÃ : " + viewmem.db_rc_type, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 480);

            e.Graphics.DrawString("ªÉÄrPÉèÃªÀiï EvÁå¢ ¸Ë®¨sÀå FUÁUÀ¯ÉÃ ºÉÆA¢zÁÝgÉAiÉÄÃ : " + viewmem.db_mc_status, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 520);

            e.Graphics.DrawString("gÀPÀÛzÀ UÀÄA¥ÀÄ : " + viewmem.db_blood_group, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 560);
            e.Graphics.DrawString("ªÀÈwÛ : " + viewmem.db_occuptaion, new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 500, 560);

            e.Graphics.DrawString("F ªÉÄÃ°£À J¯Áè ªÀiÁ»wUÀ¼ÀÄ £À£Àß w¼ÀÄªÀ½PÉ ªÉÄÃgÉUÉ ¸ÀjAiÀiÁVzÉ JAzÀÄ zÀÈrüÃPÀj¹ F §UÉÎ ¨ÁåAQ£ÀªÀgÀÄ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 105, 620);
            e.Graphics.DrawString("PÁ®PÁ®PÉÌ ¸ÀÆa¸ÀÄªÀ J¯Áè ±ÀgÀvÀÄÛUÀ¼ÀUÉ £Á£ÀÄ §zÀÞ£ÁVgÀÄvÉÃ£É JAzÀÄ w½¸ÀÄvÁÛ PÀ®àªÀÈPÀë DgÉÆÃUÀå ¸ÀÄgÀPÀëvÁ AiÉÆÃd£ÉAiÀÄ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 650);
            e.Graphics.DrawString("¸Ë®¨sÀå PÁqÀð£ÀÄß £À£ÀUÉ ¤ÃqÀ¨ÉÃPÁV «£ÀAw¸ÀÄvÉÛÃ£É.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 680);

            e.Graphics.DrawString("¢£ÁAPÀ : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 750);
            e.Graphics.DrawString("vÀªÀÄä «±Áé", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 700, 730);
            e.Graphics.DrawString("¸ÀÜ¼À : ", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 780);
            e.Graphics.DrawString("(CfðzÁgÀ ¸ÀzÀ¸Àå)", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 700, 800);

            e.Graphics.DrawString("¸À¢æAiÀÄªÀgÀ ¢£ÁAPÀ ................................. gÀAzÀÄ gÀ²Ã¢ £ÀA§æ ............................... ¥ÀæPÁgÀ gÀÆ ...................................", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 850);
            e.Graphics.DrawString("¥ÁªÀw¹zÀÄÝ ¢£ÁAPÀ ......................................... jAzÀ PÀ®àªÀÈPÀë DgÉÆÃUÀå ¸ÀÄgÀPÀëvÁ  ¸Ë®¨sÀå ¥ÀqÉAiÀÄ®Ä CºÀðgÁVgÀÄvÁÛgÉ.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 880);
            e.Graphics.DrawString("DqÀ½vÀ ªÀÄAqÀ½ ¤tðAiÀÄ £ÀA§æ ......................................... ¢£ÁAPÀ ........................... gÀAvÉ CfðAiÀÄ£ÀÄß M¥Àà¯ÁVzÉ.", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 20, 910);

            e.Graphics.DrawString("CzsÀåPÀëgÀÄ/ªÀÄÄRå PÁAiÀÄð¤ªÀðºÀuÁ¢üPÁj", new Font("Nudi 01 e", 14, FontStyle.Regular), Brushes.Black, 555, 1025);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want To Delete Application Number : " + viewmem.db_anum, "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                DbAccess db = new DbAccess();
                SqlCommand comm = new SqlCommand("DELETE FROM MEMBERS WHERE anum = '" + viewmem.db_anum+"';");
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
            button6.Visible = true;
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
            gender.ReadOnly = false;
            paid.ReadOnly = false;
            ar_card.ReadOnly = false;

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
            string name, add, rc_type, bg, occ, mc_status,num,gdr;
            long con = -1, aadh = -1,ar = -1;
            int ag = -1, pd = -1;

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
            if (anum.Text.Equals("") || contact.Text.Equals("") || aadhar.Text.Equals("") || age.Text.Equals("") || gender.Text.Equals("") || paid.Text.Equals("") || ar_card.Text.Equals("") )
            {
                MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num = anum.Text;
                con = long.Parse(contact.Text);
                aadh = long.Parse(aadhar.Text);
                ag = int.Parse(age.Text);
                gdr = gender.Text;
                ar = int.Parse(ar_card.Text);
                pd = int.Parse(paid.Text);
                if (name.Equals("") || add.Equals("") || rc_type.Equals("") || bg.Equals("") || occ.Equals("") || mc_status.Equals(""))
                {
                    MessageBox.Show("Empty Field Detected", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    editDb(name, add, rc_type, bg, occ, mc_status, num, con, ag, aadh, gdr, pd, ar);
                }
            }
        }

        public void editDb(string name,string add,string rc_type,string bg,string occ,string mc_status, string num,long con,int ag,long aadh,string gdr, int pd, long acard)
        {
            DbAccess db = new DbAccess();
            DataTable dt = new DataTable();
            string query = "UPDATE members set name = @name, address = @add, contact = @con, age = @ag, aadhar = @aadh, rc_type = @rc_type, mc_status = @mc_status, blood_group = @bg, occupation = @occ, gender = @gdr, paid = @pd, ar_card = @ac WHERE anum = @anum";
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
            comm.Parameters.AddWithValue("@gdr", gdr);
            comm.Parameters.AddWithValue("@pd", pd);
            comm.Parameters.AddWithValue("@ac", acard);
            try
            {
                db.executeQuery(comm);
                MessageBox.Show("Updation Successfull", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                viewmem vm = new viewmem();
                vm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!!", "Mcs-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void paid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            button4.Visible = true;
            button1.Visible = true;
            button3.Visible = true;

            aname.ReadOnly = true;
            contact.ReadOnly = true;
            age.ReadOnly = true;
            address.ReadOnly = true;
            aadhar.ReadOnly = true;
            rc_type.Visible = true;
            mc.Visible = true;
            b_group.Visible = true;
            occupation.ReadOnly = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            apl.Visible = false;
            bpl.Visible = false;
            yes.Visible = false;
            no.Visible = false;
            bloodGroup.Visible = false;
            gender.ReadOnly = true;
            paid.ReadOnly = true;
            ar_card.ReadOnly = true;

            /*
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

            if (medc.Equals("yes"))
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
            */
        }
    }
}
