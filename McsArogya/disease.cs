using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class disease : Form
    {
        DataTable dt;
        string ctxt;
        public disease()
        {
            InitializeComponent();
        }
        public disease(string c)
        {
            InitializeComponent();
            this.ctxt = c;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void disease_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGrid.DataSource = dt;
            DbAccess db = new DbAccess();
            string query = "SELECT id as ID, name as Disease_Name, description as Description from disease; ";
            db.readDatathroughAdapter(query, dt);
            DataGridViewColumn dc = dataGrid.Columns[0];
            dc.Width = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string query = "";
            if (sbn.Text.Equals(""))
            {
                query = "SELECT id as ID, name as Disease_Name, description as Description from disease;";
            }
            else
            {
                query = "SELECT id as ID, name as Disease_Name, description as Description from disease where name LIKE '%" + sbn.Text + "%';";
            }
            dt.Clear();
            DbAccess db = new DbAccess();
            db.readDatathroughAdapter(query, dt);
            DataGridViewColumn dc = dataGrid.Columns[0];
            dc.Width = 50;
        }

        private void sbn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                search();
            }
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name, info;
            name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            info = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.Hide();

            if(ctxt == "arogyaClaim")
            {
                arogyaClaim ac = (arogyaClaim)Application.OpenForms["arogyaClaim"];
                ac.ddesc.Text = name;
                ac.dinfo.Text = info;
            }
            else if(ctxt == "claimcell")
            {
                claimcell c = (claimcell)Application.OpenForms["claimcell"];
                c.ddesc.Text = name;
                c.dinfo.Text = info;
                c.amount.Text = "";
            }
        }
    }
}
