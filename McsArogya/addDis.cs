using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class addDis : Form
    {
        public addDis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("INSERT into disease values (@name,@info);");
            if(dname.Text.Equals("") || dinfo.Text.Equals(""))
            {
                MessageBox.Show("Empty fields detected", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com.Parameters.AddWithValue("@name", dname.Text.ToString());
                com.Parameters.AddWithValue("@info", dinfo.Text.ToString());
                try
                {
                    db.executeQuery(com);
                    MessageBox.Show("Disease information added to database", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL exception occured\n"+ex.ToString(), "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }
    }
}
