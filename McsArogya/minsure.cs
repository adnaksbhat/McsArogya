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
    public partial class minsure : Form
    {
        public minsure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            DialogResult dr = MessageBox.Show("You are about to change the maximum allocated insure amount for all users\nAre you sure you want to proceed?", "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    SqlCommand com = new SqlCommand("UPDATE int_vars set value = " + int.Parse(iamt.Text) + " where name = 'insure_amt';");
                    db.executeQuery(com);
                    MessageBox.Show("Max allocated insure amount has been Updated successfully.\nPlease Reset Insure amount for all users from management console if needed.", "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Exception occured\n" + ex.ToString(), "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void minsure_Load(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            SqlDataReader reader = db.readDatathroughReader("Select value from int_vars where name = 'insure_amt';");
            reader.Read();
            int amt = reader.GetInt32(0);
            reader.Close();
            iamt.Text = amt.ToString();
        }
    }
}
