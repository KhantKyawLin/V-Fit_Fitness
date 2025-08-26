namespace V_Fit_Fitness_Tracker
{
    partial class Admin_Home
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
            this.btnclubmemberlogin = new System.Windows.Forms.Button();
            this.btnclubmemberregister = new System.Windows.Forms.Button();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.btnadminregister = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnactivities = new System.Windows.Forms.Button();
            this.btnchangepassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclubmemberlogin
            // 
            this.btnclubmemberlogin.Location = new System.Drawing.Point(26, 151);
            this.btnclubmemberlogin.Name = "btnclubmemberlogin";
            this.btnclubmemberlogin.Size = new System.Drawing.Size(200, 63);
            this.btnclubmemberlogin.TabIndex = 3;
            this.btnclubmemberlogin.Text = "Club-member Log-in";
            this.btnclubmemberlogin.UseVisualStyleBackColor = true;
            this.btnclubmemberlogin.Click += new System.EventHandler(this.btnclubmemberlogin_Click);
            // 
            // btnclubmemberregister
            // 
            this.btnclubmemberregister.Location = new System.Drawing.Point(26, 220);
            this.btnclubmemberregister.Name = "btnclubmemberregister";
            this.btnclubmemberregister.Size = new System.Drawing.Size(200, 63);
            this.btnclubmemberregister.TabIndex = 2;
            this.btnclubmemberregister.Text = "Club-member Info";
            this.btnclubmemberregister.UseVisualStyleBackColor = true;
            this.btnclubmemberregister.Click += new System.EventHandler(this.btnclubmemberregister_Click);
            // 
            // btnadminlogin
            // 
            this.btnadminlogin.Location = new System.Drawing.Point(26, 82);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(200, 63);
            this.btnadminlogin.TabIndex = 1;
            this.btnadminlogin.Text = "Admin Log-in";
            this.btnadminlogin.UseVisualStyleBackColor = true;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // btnadminregister
            // 
            this.btnadminregister.Location = new System.Drawing.Point(26, 13);
            this.btnadminregister.Name = "btnadminregister";
            this.btnadminregister.Size = new System.Drawing.Size(200, 63);
            this.btnadminregister.TabIndex = 0;
            this.btnadminregister.Text = "Admin Info";
            this.btnadminregister.UseVisualStyleBackColor = true;
            this.btnadminregister.Click += new System.EventHandler(this.btnadminregister_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.Blue;
            this.lblname.Location = new System.Drawing.Point(37, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(13, 17);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "-";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(37, 13);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(77, 17);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblwelcome);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(550, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 424);
            this.panel2.TabIndex = 2;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogout.Location = new System.Drawing.Point(40, 359);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(84, 34);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.trainerlogo11;
            this.pictureBox1.Location = new System.Drawing.Point(14, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(181, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 74);
            this.label3.TabIndex = 6;
            this.label3.Text = "V-Fit\r\nFitness Tracker";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(169, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 74);
            this.label4.TabIndex = 1;
            this.label4.Text = "V-Fit\r\nFitness Tracker";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.fittnesslogoicon;
            this.pictureBox3.Location = new System.Drawing.Point(27, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnactivities);
            this.panel1.Controls.Add(this.btnchangepassword);
            this.panel1.Controls.Add(this.btnadminregister);
            this.panel1.Controls.Add(this.btnadminlogin);
            this.panel1.Controls.Add(this.btnclubmemberregister);
            this.panel1.Controls.Add(this.btnclubmemberlogin);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 313);
            this.panel1.TabIndex = 8;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(278, 220);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(200, 63);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(278, 151);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(200, 63);
            this.btnreport.TabIndex = 8;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnactivities
            // 
            this.btnactivities.Location = new System.Drawing.Point(278, 82);
            this.btnactivities.Name = "btnactivities";
            this.btnactivities.Size = new System.Drawing.Size(200, 63);
            this.btnactivities.TabIndex = 6;
            this.btnactivities.Text = "Activities";
            this.btnactivities.UseVisualStyleBackColor = true;
            this.btnactivities.Click += new System.EventHandler(this.btnactivities_Click);
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.Location = new System.Drawing.Point(278, 13);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(200, 63);
            this.btnchangepassword.TabIndex = 5;
            this.btnchangepassword.Text = "Change Password";
            this.btnchangepassword.UseVisualStyleBackColor = true;
            this.btnchangepassword.Click += new System.EventHandler(this.btnchangepassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.fittnesslogoicon3;
            this.pictureBox2.Location = new System.Drawing.Point(39, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(750, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Name = "Admin_Home";
            this.Text = "Admin_Home";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclubmemberlogin;
        private System.Windows.Forms.Button btnclubmemberregister;
        private System.Windows.Forms.Button btnadminlogin;
        private System.Windows.Forms.Button btnadminregister;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnactivities;
        private System.Windows.Forms.Button btnchangepassword;
        private System.Windows.Forms.Button btnlogout;
    }
}