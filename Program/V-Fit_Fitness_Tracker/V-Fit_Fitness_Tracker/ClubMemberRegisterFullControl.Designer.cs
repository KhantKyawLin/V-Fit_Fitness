namespace V_Fit_Fitness_Tracker
{
    partial class ClubMemberRegisterFullControl
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvshowdataclubmember = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.cboactivities = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphno = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataclubmember)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(37, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "V-Fit\r\nFitness Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.fittnesslogoicon2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvshowdataclubmember);
            this.groupBox2.Location = new System.Drawing.Point(37, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgvshowdataclubmember
            // 
            this.dgvshowdataclubmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowdataclubmember.Location = new System.Drawing.Point(15, 21);
            this.dgvshowdataclubmember.Name = "dgvshowdataclubmember";
            this.dgvshowdataclubmember.RowTemplate.Height = 24;
            this.dgvshowdataclubmember.Size = new System.Drawing.Size(631, 88);
            this.dgvshowdataclubmember.TabIndex = 0;
            this.dgvshowdataclubmember.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvshowdataclubmember_CellMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Controls.Add(this.btnclear);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnregister);
            this.groupBox4.Controls.Add(this.cboactivities);
            this.groupBox4.Controls.Add(this.dtpdob);
            this.groupBox4.Controls.Add(this.rdofemale);
            this.groupBox4.Controls.Add(this.rdomale);
            this.groupBox4.Controls.Add(this.txtconfirmpassword);
            this.groupBox4.Controls.Add(this.txtpassword);
            this.groupBox4.Controls.Add(this.txtaddress);
            this.groupBox4.Controls.Add(this.txtphno);
            this.groupBox4.Controls.Add(this.txtweight);
            this.groupBox4.Controls.Add(this.txtemail);
            this.groupBox4.Controls.Add(this.txtmembername);
            this.groupBox4.Controls.Add(this.txtmemberid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(37, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 318);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Member Registration Form";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(413, 272);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(84, 34);
            this.btnclose.TabIndex = 28;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(534, 272);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(84, 34);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Silver;
            this.btnupdate.Location = new System.Drawing.Point(285, 272);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(84, 34);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btndelete.Location = new System.Drawing.Point(149, 272);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(84, 34);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnregister.Location = new System.Drawing.Point(22, 272);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(84, 34);
            this.btnregister.TabIndex = 24;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // cboactivities
            // 
            this.cboactivities.FormattingEnabled = true;
            this.cboactivities.Items.AddRange(new object[] {
            "Walking",
            "Swimming",
            "Push-up",
            "Elbow plank",
            "Squatting",
            "Crunching"});
            this.cboactivities.Location = new System.Drawing.Point(483, 79);
            this.cboactivities.Name = "cboactivities";
            this.cboactivities.Size = new System.Drawing.Size(163, 24);
            this.cboactivities.TabIndex = 23;
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(483, 45);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(163, 22);
            this.dtpdob.TabIndex = 22;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(223, 150);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(81, 21);
            this.rdofemale.TabIndex = 21;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(135, 150);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(63, 21);
            this.rdomale.TabIndex = 20;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(483, 145);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(163, 22);
            this.txtconfirmpassword.TabIndex = 19;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(483, 112);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(163, 22);
            this.txtpassword.TabIndex = 18;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(483, 181);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(163, 71);
            this.txtaddress.TabIndex = 17;
            // 
            // txtphno
            // 
            this.txtphno.Location = new System.Drawing.Point(135, 232);
            this.txtphno.Name = "txtphno";
            this.txtphno.Size = new System.Drawing.Size(163, 22);
            this.txtphno.TabIndex = 16;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(135, 192);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(163, 22);
            this.txtweight.TabIndex = 15;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(135, 112);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(163, 22);
            this.txtemail.TabIndex = 14;
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(135, 79);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(163, 22);
            this.txtmembername.TabIndex = 13;
            // 
            // txtmemberid
            // 
            this.txtmemberid.Enabled = false;
            this.txtmemberid.Location = new System.Drawing.Point(135, 45);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.Size = new System.Drawing.Size(163, 22);
            this.txtmemberid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Activities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Weight:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Member Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Member ID:";
            // 
            // ClubMemberRegisterFullControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(762, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "ClubMemberRegisterFullControl";
            this.Text = "ClubMemberRegisterFullControl";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataclubmember)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphno;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cboactivities;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.DataGridView dgvshowdataclubmember;
    }
}