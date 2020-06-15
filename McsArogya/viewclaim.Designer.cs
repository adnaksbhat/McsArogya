namespace McsArogya
{
    partial class viewclaim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewclaim));
            this.sbi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sbn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sbi
            // 
            this.sbi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sbi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sbi.Location = new System.Drawing.Point(307, 61);
            this.sbi.Name = "sbi";
            this.sbi.Size = new System.Drawing.Size(396, 22);
            this.sbi.TabIndex = 30;
            this.sbi.Text = "Search By Account Number";
            this.sbi.Enter += new System.EventHandler(this.sbi_Enter);
            this.sbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sbi_KeyDown);
            this.sbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sbi_KeyPress);
            this.sbi.Leave += new System.EventHandler(this.sbi_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(906, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 70);
            this.button1.TabIndex = 29;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbn
            // 
            this.sbn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sbn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sbn.Location = new System.Drawing.Point(307, 23);
            this.sbn.Name = "sbn";
            this.sbn.Size = new System.Drawing.Size(396, 22);
            this.sbn.TabIndex = 28;
            this.sbn.Text = "Search By Name";
            this.sbn.Enter += new System.EventHandler(this.sbn_Enter);
            this.sbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sbn_KeyDown);
            this.sbn.Leave += new System.EventHandler(this.sbn_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 70);
            this.button2.TabIndex = 27;
            this.button2.Text = "🡸";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 90);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 70;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(980, 551);
            this.dataGrid.TabIndex = 26;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Location = new System.Drawing.Point(0, 647);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(503, 74);
            this.button3.TabIndex = 31;
            this.button3.Text = "Export to Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Location = new System.Drawing.Point(509, 647);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(503, 74);
            this.button4.TabIndex = 32;
            this.button4.Text = "Generate CSV";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewclaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sbi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sbn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewclaim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewclaim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewclaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sbi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sbn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}