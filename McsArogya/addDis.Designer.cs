﻿namespace McsArogya
{
    partial class addDis
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
            this.label1 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.dinfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disease Name";
            // 
            // dname
            // 
            this.dname.Location = new System.Drawing.Point(61, 70);
            this.dname.Multiline = true;
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(207, 57);
            this.dname.TabIndex = 1;
            // 
            // dinfo
            // 
            this.dinfo.Location = new System.Drawing.Point(61, 169);
            this.dinfo.Multiline = true;
            this.dinfo.Name = "dinfo";
            this.dinfo.Size = new System.Drawing.Size(207, 61);
            this.dinfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disease Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.label1);
            this.Name = "addDis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addDis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.TextBox dinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}