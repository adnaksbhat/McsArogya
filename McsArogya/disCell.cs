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
    public partial class disCell : Form
    {
        string name, info;
        int id;
        public disCell()
        {
            
        }

        public disCell(string n,string i,int id)
        {
            InitializeComponent();
            this.name = n;
            this.info = i;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            SqlCommand com = new SqlCommand("UPDATE disease set name = @name, description = @desc where id = @id;");
            com.Parameters.AddWithValue("@name", dname.Text.ToString());
            com.Parameters.AddWithValue("@desc", dinfo.Text.ToString());
            com.Parameters.AddWithValue("@id", id);
            if (dname.Text.Equals("") || dinfo.Text.Equals(""))
            {
                MessageBox.Show("Empty fields detected", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res = db.executeQuery(com);
                    
                    MessageBox.Show("Disease information updated in the database", "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL exception occured\n" + ex.ToString(), "MCSArogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are about to delete a record in the database", "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                DbAccess db = new DbAccess();
                SqlCommand comm = new SqlCommand("DELETE FROM disease WHERE id = '" + id + "';");
                try
                {
                    int res = db.executeQuery(comm);
                    if (res > 0)
                    {
                        MessageBox.Show("Disease info removed from database", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Hide();
                }            
                catch(SqlException ex)
                {
                    MessageBox.Show("SQL Exception occured\n"+ex.ToString(), "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void disCell_Load(object sender, EventArgs e)
        {
            dname.Text = name;
            dinfo.Text = info;
        }
    }
}
