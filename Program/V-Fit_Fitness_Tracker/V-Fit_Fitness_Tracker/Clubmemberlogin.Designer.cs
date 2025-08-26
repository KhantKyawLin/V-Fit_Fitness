namespace V_Fit_Fitness_Tracker
{
    partial class Clubmemberlogin
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
            this.lnkregiter = new System.Windows.Forms.LinkLabel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvshowdataclubmemberlogin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataclubmemberlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.lnkregiter);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V-Fit Member Login Form";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(189, 230);
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
            this.btncancel.Location = new System.Drawing.Point(99, 230);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 37);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Clear";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.Location = new System.Drawing.Point(6, 230);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 37);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lnkregiter
            // 
            this.lnkregiter.AutoSize = true;
            this.lnkregiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkregiter.Location = new System.Drawing.Point(25, 200);
            this.lnkregiter.Name = "lnkregiter";
            this.lnkregiter.Size = new System.Drawing.Size(248, 17);
            this.lnkregiter.TabIndex = 5;
            this.lnkregiter.TabStop = true;
            this.lnkregiter.Text = "Don\'t have an account? Register here";
            this.lnkregiter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkregiter_LinkClicked);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(28, 166);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(198, 22);
            this.txtpassword.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(28, 100);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(198, 22);
            this.txtemail.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(25, 137);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(82, 17);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(25, 63);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 17);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your information to log in.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvshowdataclubmemberlogin);
            this.groupBox2.Location = new System.Drawing.Point(27, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvshowdataclubmemberlogin
            // 
            this.dgvshowdataclubmemberlogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowdataclubmemberlogin.Location = new System.Drawing.Point(6, 12);
            this.dgvshowdataclubmemberlogin.Name = "dgvshowdataclubmemberlogin";
            this.dgvshowdataclubmemberlogin.RowTemplate.Height = 24;
            this.dgvshowdataclubmemberlogin.Size = new System.Drawing.Size(261, 23);
            this.dgvshowdataclubmemberlogin.TabIndex = 0;
            // 
            // Clubmemberlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(337, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clubmemberlogin";
            this.Text = "Clubmemberlogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowdataclubmemberlogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lnkregiter;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvshowdataclubmemberlogin;
    }
}