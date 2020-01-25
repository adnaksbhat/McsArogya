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
    public partial class viewclaim : Form
    {
        public static int db_age;
        public static double db_a_card, db_contact, db_anum;
        public static string db_address,db_name, db_d_desc, db_hosp_name;
        DataTable dt = new DataTable();
        public viewclaim()
        {
            InitializeComponent();
        }

        private void viewclaim_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = dt;
            DbAccess db = new DbAccess();
            string query = " SELECT * from claimants; ";
            db.readDatathroughAdapter(query, dt);
        }

        private void search()
        {
            string query = "";
            if (sbi.Text.Equals("Search By Account Number") && sbn.Text.Equals("Search By Name"))
            {
                query = "SELECT * FROM claimants";
            }
            if (!sbn.Text.Equals("Search By Name"))
            {
                query = "SELECT * FROM claimants WHERE name LIKE '" + sbn.Text + "%';";
            }
            else if (!sbi.Text.Equals("Search By Account Number"))
            {
                query = "SELECT * FROM claimants WHERE anum LIKE '" + sbi.Text + "%';";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void sbn_Enter(object sender, EventArgs e)
        {
            sbn.Text = "";
            sbn.ForeColor = Color.Black;
            sbi.Text = "Search By Account Number";
            sbi.ForeColor = Color.Gray;
            sbi.ReadOnly = true;
        }

        private void sbn_Leave(object sender, EventArgs e)
        {
            sbi.ReadOnly = false;
        }

        private void sbi_Enter(object sender, EventArgs e)
        {
            sbi.Text = "";
            sbi.ForeColor = Color.Black;
            sbn.ForeColor = Color.Gray;
            sbn.Text = "Search By Name";
            sbn.ReadOnly = true;
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db_anum = Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[1].Value);
                db_name = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                db_age = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[3].Value);
                db_address = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                db_a_card = Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[5].Value);
                db_contact = Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[6].Value);
                db_d_desc = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                db_hosp_name = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();

                claimcell cc = new claimcell();
                cc.Show();
            }catch(Exception ex)
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Claimants Summary";
                // storing header part in Excel  
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            catch(Exception ex)
            {

            }
        }

        private void sbi_Leave(object sender, EventArgs e)
        {
            sbn.ReadOnly = false;
        }

        private void sbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
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

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
