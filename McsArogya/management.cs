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
    public partial class management : Form
    {
        public management()
        {
            InitializeComponent();
        }

        private void management_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mdis md = new mdis();
            md.ShowDialog();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbAccess db = new DbAccess();
            SqlDataReader reader = db.readDatathroughReader("Select value from int_vars where name = 'insure_amt';");
            reader.Read();
            int amt = reader.GetInt32(0);
            reader.Close();
            DialogResult dr = MessageBox.Show("Total insure amount for all the users will be reset to ₹"+amt+" per user\nThis cannot be undone\nAre you sure you want to proceed", "MCS-Arogya", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    SqlCommand com = new SqlCommand("UPDATE members set insurance_amt = " + amt + ";");
                    db.executeQuery(com);
                    MessageBox.Show("Insure Amount has been reset successfully" , "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SQL Exception occured\n" + ex.ToString(), "MCS-Arogya", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            minsure ms = new minsure();
            ms.ShowDialog();
        }
    }
}
