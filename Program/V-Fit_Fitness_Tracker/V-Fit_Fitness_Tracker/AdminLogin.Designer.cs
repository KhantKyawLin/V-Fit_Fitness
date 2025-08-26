namespace V_Fit_Fitness_Tracker
{
    partial class AdminLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lnkadminregister = new System.Windows.Forms.LinkLabel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvshowdataadminlogin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataadminlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.lnkadminregister);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V-Fit Admin Login Form";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(196, 230);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 37);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Silver;
            this.btncancel.Location = new System.Drawing.Point(100, 230);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 37);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Clear";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.Location = new System.Drawing.Point(7, 230);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 37);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lnkadminregister
            // 
            this.lnkadminregister.AutoSize = true;
            this.lnkadminregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkadminregister.Location = new System.Drawing.Point(23, 194);
            this.lnkadminregister.Name = "lnkadminregister";
            this.lnkadminregister.Size = new System.Drawing.Size(248, 17);
            this.lnkadminregister.TabIndex = 5;
            this.lnkadminregister.TabStop = true;
            this.lnkadminregister.Text = "Don\'t have an account? Register here";
            this.lnkadminregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkadminregister_LinkClicked);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(26, 156);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(175, 22);
            this.txtpassword.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(29, 87);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(172, 22);
            this.txtemail.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(26, 125);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(82, 17);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(26, 56);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 17);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email to log in.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvshowdataadminlogin);
            this.groupBox2.Location = new System.Drawing.Point(23, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvshowdataadminlogin
            // 
            this.dgvshowdataadminlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowdataadminlogin.Location = new System.Drawing.Point(7, 21);
            this.dgvshowdataadminlogin.Name = "dgvshowdataadminlogin";
            this.dgvshowdataadminlogin.RowTemplate.Height = 24;
            this.dgvshowdataadminlogin.Size = new System.Drawing.Size(261, 23);
            this.dgvshowdataadminlogin.TabIndex = 0;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(337, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataadminlogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lnkadminregister;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.DataGridView dgvshowdataadminlogin;
    }
}