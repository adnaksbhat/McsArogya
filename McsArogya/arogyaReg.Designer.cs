﻿namespace McsArogya
{
    partial class arogyaReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arogyaReg));
            this.label1 = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.TextBox();
            this.anum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aadhar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bpl = new System.Windows.Forms.RadioButton();
            this.apl = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bloodGroup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.occupation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ar_card = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name";
            // 
            // aname
            // 
            this.aname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aname.Location = new System.Drawing.Point(411, 181);
            this.aname.Margin = new System.Windows.Forms.Padding(4);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(252, 22);
            this.aname.TabIndex = 2;
            // 
            // anum
            // 
            this.anum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.anum.Location = new System.Drawing.Point(410, 126);
            this.anum.Margin = new System.Windows.Forms.Padding(4);
            this.anum.MaxLength = 10;
            this.anum.Name = "anum";
            this.anum.Size = new System.Drawing.Size(253, 22);
            this.anum.TabIndex = 1;
            this.anum.TextChanged += new System.EventHandler(this.anum_TextChanged);
            this.anum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.anum_KeyDown);
            this.anum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anum_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Member Number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address.Location = new System.Drawing.Point(410, 329);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(253, 88);
            this.address.TabIndex = 5;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            this.address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address_KeyPress);
            // 
            // contact
            // 
            this.contact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contact.Location = new System.Drawing.Point(410, 233);
            this.contact.Margin = new System.Windows.Forms.Padding(4);
            this.contact.MaxLength = 10;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(253, 22);
            this.contact.TabIndex = 3;
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            this.contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact";
            // 
            // aadhar
            // 
            this.aadhar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aadhar.Location = new System.Drawing.Point(411, 446);
            this.aadhar.Margin = new System.Windows.Forms.Padding(4);
            this.aadhar.MaxLength = 16;
            this.aadhar.Name = "aadhar";
            this.aadhar.Size = new System.Drawing.Size(253, 22);
            this.aadhar.TabIndex = 6;
            this.aadhar.TextChanged += new System.EventHandler(this.aadhar_TextChanged);
            this.aadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aadhar_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aadhar Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ration Card Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.bpl);
            this.groupBox1.Controls.Add(this.apl);
            this.groupBox1.Location = new System.Drawing.Point(407, 528);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(144, 36);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // bpl
            // 
            this.bpl.AutoSize = true;
            this.bpl.Location = new System.Drawing.Point(76, 7);
            this.bpl.Margin = new System.Windows.Forms.Padding(4);
            this.bpl.Name = "bpl";
            this.bpl.Size = new System.Drawing.Size(55, 21);
            this.bpl.TabIndex = 9;
            this.bpl.Text = "BPL";
            this.bpl.UseVisualStyleBackColor = true;
            // 
            // apl
            // 
            this.apl.AutoSize = true;
            this.apl.Checked = true;
            this.apl.Location = new System.Drawing.Point(8, 7);
            this.apl.Margin = new System.Windows.Forms.Padding(4);
            this.apl.Name = "apl";
            this.apl.Size = new System.Drawing.Size(55, 21);
            this.apl.TabIndex = 8;
            this.apl.TabStop = true;
            this.apl.Text = "APL";
            this.apl.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 581);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medical Certificate";
            // 
            // bloodGroup
            // 
            this.bloodGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodGroup.FormattingEnabled = true;
            this.bloodGroup.Items.AddRange(new object[] {
            "--",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroup.Location = new System.Drawing.Point(406, 640);
            this.bloodGroup.Margin = new System.Windows.Forms.Padding(4);
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.Size = new System.Drawing.Size(145, 24);
            this.bloodGroup.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 630);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Blood Group";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(815, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 72);
            this.button2.TabIndex = 20;
            this.button2.Text = "🡸";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // occupation
            // 
            this.occupation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.occupation.Location = new System.Drawing.Point(406, 692);
            this.occupation.Margin = new System.Windows.Forms.Padding(4);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(253, 22);
            this.occupation.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 681);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "Occupation";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.no);
            this.groupBox2.Controls.Add(this.yes);
            this.groupBox2.Location = new System.Drawing.Point(407, 579);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(144, 36);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(76, 7);
            this.no.Margin = new System.Windows.Forms.Padding(4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(45, 21);
            this.no.TabIndex = 11;
            this.no.Text = "no";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Checked = true;
            this.yes.Location = new System.Drawing.Point(8, 7);
            this.yes.Margin = new System.Windows.Forms.Padding(4);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(51, 21);
            this.yes.TabIndex = 10;
            this.yes.TabStop = true;
            this.yes.Text = "yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.age.Location = new System.Drawing.Point(410, 287);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.MaxLength = 3;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(253, 22);
            this.age.TabIndex = 4;
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "Age";
            // 
            // gender
            // 
            this.gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gender.Location = new System.Drawing.Point(411, 487);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.MaxLength = 1;
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(55, 22);
            this.gender.TabIndex = 7;
            this.gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gender_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(106, 485);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 34);
            this.label11.TabIndex = 27;
            this.label11.Text = "Gender";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // paid
            // 
            this.paid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paid.Location = new System.Drawing.Point(406, 742);
            this.paid.Margin = new System.Windows.Forms.Padding(4);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(253, 22);
            this.paid.TabIndex = 14;
            this.paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(102, 731);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 34);
            this.label12.TabIndex = 28;
            this.label12.Text = "Amount Paid";
            // 
            // ar_card
            // 
            this.ar_card.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ar_card.Location = new System.Drawing.Point(406, 791);
            this.ar_card.Margin = new System.Windows.Forms.Padding(4);
            this.ar_card.Name = "ar_card";
            this.ar_card.Size = new System.Drawing.Size(253, 22);
            this.ar_card.TabIndex = 15;
            this.ar_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ar_card_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(102, 780);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 34);
            this.label13.TabIndex = 30;
            this.label13.Text = "Arogya Card Number";
            // 
            // arogyaReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1124, 841);
            this.Controls.Add(this.ar_card);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.occupation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bloodGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aadhar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "arogyaReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arogyaReg";
            this.Load += new System.EventHandler(this.arogyaReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aname;
        private System.Windows.Forms.TextBox anum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aadhar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bpl;
        private System.Windows.Forms.RadioButton apl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bloodGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox occupation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ar_card;
        private System.Windows.Forms.Label label13;
    }
}