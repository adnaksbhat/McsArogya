using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace McsArogya
{
    public partial class Mcs_Arogya : Form
    {
        string message;
        /*public Mcs_Arogya()
        {
            InitializeComponent();
        }
        */

        public Mcs_Arogya(string msg)
        {
            this.message = msg;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\"+message;
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", path));
            this.Hide();
        }

        private void Mcs_Arogya_Load(object sender, EventArgs e)
        {
            label1.Text = "Backup successfully generated\nPath: " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            label1.Text += "\nFilename: " + message;
        }
    }
}
