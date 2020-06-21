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
    public partial class mdis : Form
    {
        DataTable dt;
        public mdis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void reload()
        {
            this.reload();
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

        private void mdis_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataGrid.DataSource = dt;
            DbAccess db = new DbAccess();
            string query = "SELECT id as ID, name as Disease_Name, description as Description from disease; ";
            db.readDatathroughAdapter(query, dt);
            DataGridViewColumn dc = dataGrid.Columns[0];
            dc.Width = 50;
        }

        private void sbn_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDis ad = new addDis();
            ad.ShowDialog();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name, info;
            int id;
            name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            info = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            id = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            System.Console.WriteLine(name);
            System.Console.WriteLine(info);
            System.Console.WriteLine(id);
            disCell ds = new disCell(name,info,id);
            ds.ShowDialog();
        }
    }
}
