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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sbi
            // 
            this.sbi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sbi.Location = new System.Drawing.Point(416, 22);
            this.sbi.Name = "sbi";
            this.sbi.Size = new System.Drawing.Size(350, 22);
            this.sbi.TabIndex = 30;
            this.sbi.Text = "Search By Account Number";
            this.sbi.Enter += new System.EventHandler(this.sbi_Enter);
            this.sbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sbi_KeyDown);
            this.sbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sbi_KeyPress);
            this.sbi.Leave += new System.EventHandler(this.sbi_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbn
            // 
            this.sbn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sbn.Location = new System.Drawing.Point(74, 22);
            this.sbn.Name = "sbn";
            this.sbn.Size = new System.Drawing.Size(336, 22);
            this.sbn.TabIndex = 28;
            this.sbn.Text = "Search By Name";
            this.sbn.Enter += new System.EventHandler(this.sbn_Enter);
            this.sbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sbn_KeyDown);
            this.sbn.Leave += new System.EventHandler(this.sbn_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 44);
            this.button2.TabIndex = 27;
            this.button2.Text = "🡸";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 62);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 70;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(813, 654);
            this.dataGrid.TabIndex = 26;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(812, 47);
            this.button3.TabIndex = 31;
            this.button3.Text = "Export to Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewclaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 781);
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
    }
}