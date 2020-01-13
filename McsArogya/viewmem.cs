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
    public partial class viewmem : Form
    {
        DataTable dt = new DataTable();
        public viewmem()
        {
            InitializeComponent();
        }

        private void viewmem_Load(object sender, EventArgs e)
        {
            /*dt.Columns.Add("id");
            dt.Columns.Add("Application Number");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Contact");
            dt.Columns.Add("Aadhar number");
            dt.Columns.Add("Ration Card Type");
            dt.Columns.Add("Medical Certificate");
            dt.Columns.Add("Blood Group");
            dt.Columns.Add("Occupation"); */
            dataGrid.DataSource = dt;
            DbAccess db = new DbAccess();
            string query = " SELECT * from members; ";
            db.readDatathroughAdapter(query, dt);
            DataGridViewColumn dc = dataGrid.Columns[3];
            dc.Width = 185;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home hm = new home();
            hm.Show();
        }

        private void sbn_Enter(object sender, EventArgs e)
        {
            sbn.Text = "";
            sbi.Text = "Search By Account Number";
            sbi.ReadOnly = true;
        }

        private void sbn_Leave(object sender, EventArgs e)
        {
            sbi.ReadOnly = false;
        }

        private void sbi_Enter(object sender, EventArgs e)
        {
            sbi.Text = "";
            sbn.Text = "Search By Name";
            sbn.ReadOnly = true;
        }

        private void sbi_Leave(object sender, EventArgs e)
        {
            sbn.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void sbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void search()
        {
            string query = "";
            if (sbi.Text.Equals("Search By Account Number") && sbn.Text.Equals("Search By Name"))
            {
                query = "SELECT * FROM members";
            }
            if (!sbn.Text.Equals("Search By Name"))
            {
                query = "SELECT * FROM members WHERE name LIKE '" + sbn.Text + "%';";
            }
            else if (!sbi.Text.Equals("Search By Account Number"))
            {
                query = "SELECT * FROM members WHERE anum LIKE '" + sbi.Text + "%';";
            }

            if (!query.Equals(""))
            {
                dt.Clear();
                DbAccess db = new DbAccess();
                db.readDatathroughAdapter(query, dt);
                DataGridViewColumn dc = dataGrid.Columns[3];
                dc.Width = 185;
            }
        }

        private void sbn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                search();
            }
        }

        private void sbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                search();
            }
        }
    }
}
