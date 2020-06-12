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
    public partial class viewmem : Form
    {
        public static double db_contact;
        public static long db_aadhar;
        public static string db_anum,db_name, db_address, db_rc_type, db_mc_status, db_blood_group, db_occuptaion;
        public static int db_age;
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
            string query =  "SELECT anum as Application_Number,name as Name,address as Address,contact as Contact,age as Age,aadhar as Aadhar,rc_type as Ration_Card,mc_Status as Medical_Certificate,blood_group as Blood_Group,occupation as Occupation from members; ";
            db.readDatathroughAdapter(query, dt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sbn_Enter(object sender, EventArgs e)
        {
            sbn.Text = "";
            sbi.Text = "Search By Account Number";
            sbn.ForeColor = Color.Black;
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
            sbn.Text = "Search By Name";
            sbi.ForeColor = Color.Black;
            sbn.ForeColor = Color.Gray;
            sbn.ReadOnly = true;
        }

        private void sbi_Leave(object sender, EventArgs e)
        {
            sbn.ReadOnly = false;
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
                worksheet.Name = "Members Summary";
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
            }catch(Exception ex)
            {
                
            }
           
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
                query = "SELECT anum as Application_Number,name as Name,address as Address,contact as Contact,age as Age,aadhar as Aadhar,rc_type as Ration_Card,mc_Status as Medical_Certificate,blood_group as Blood_Group,occupation as Occupation FROM members";
            }
            if (!sbn.Text.Equals("Search By Name"))
            {
                query = "SELECT anum as Application_Number,name as Name,address as Address,contact as Contact,age as Age,aadhar as Aadhar,rc_type as Ration_Card,mc_Status as Medical_Certificate,blood_group as Blood_Group,occupation as Occupation FROM members WHERE name LIKE '" + sbn.Text + "%';";
            }
            else if (!sbi.Text.Equals("Search By Account Number"))
            {
                query = "SELECT anum as Application_Number,name as Name,address as Address,contact as Contact,age as Age,aadhar as Aadhar,rc_type as Ration_Card,mc_Status as Medical_Certificate,blood_group as Blood_Group,occupation as Occupation FROM members WHERE anum LIKE '" + sbi.Text + "%';";
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

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db_anum = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                db_name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                db_address = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                db_contact = Convert.ToDouble(dataGrid.Rows[e.RowIndex].Cells[3].Value);
                db_age = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[4].Value);
                db_aadhar = Convert.ToInt64(dataGrid.Rows[e.RowIndex].Cells[5].Value);
                db_rc_type = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                db_mc_status = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                db_blood_group = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                db_occuptaion = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();

                memcell mc = new memcell();
                mc.Show();
            }
            catch(Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }

            
        }
    }
}
