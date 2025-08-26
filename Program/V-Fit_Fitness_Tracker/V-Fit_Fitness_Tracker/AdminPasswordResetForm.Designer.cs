namespace V_Fit_Fitness_Tracker
{
    partial class AdminPasswordResetForm
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
            this.btnadminhome = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lbloldpassword = new System.Windows.Forms.Label();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtconfirmpassword);
            this.groupBox1.Controls.Add(this.lblconfirmpassword);
            this.groupBox1.Controls.Add(this.btnadminhome);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnchange);
            this.groupBox1.Controls.Add(this.txtnewpassword);
            this.groupBox1.Controls.Add(this.txtoldpassword);
            this.groupBox1.Controls.Add(this.lblnewpassword);
            this.groupBox1.Controls.Add(this.lbloldpassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V-Fit Password Reset Form";
            // 
            // btnadminhome
            // 
            this.btnadminhome.Location = new System.Drawing.Point(6, 311);
            this.btnadminhome.Name = "btnadminhome";
            this.btnadminhome.Size = new System.Drawing.Size(50, 25);
            this.btnadminhome.TabIndex = 6;
            this.btnadminhome.Text = "<<<";
            this.btnadminhome.UseVisualStyleBackColor = true;
            this.btnadminhome.Click += new System.EventHandler(this.btnadminhome_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(107, 259);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(84, 34);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnchange.Location = new System.Drawing.Point(0, 259);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(84, 34);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(27, 124);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(164, 22);
            this.txtnewpassword.TabIndex = 3;
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(27, 57);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(164, 22);
            this.txtoldpassword.TabIndex = 2;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(27, 104);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(117, 17);
            this.lblnewpassword.TabIndex = 1;
            this.lblnewpassword.Text = "New Password:";
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.Location = new System.Drawing.Point(24, 37);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(112, 17);
            this.lbloldpassword.TabIndex = 0;
            this.lbloldpassword.Text = "Old Password:";
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Location = new System.Drawing.Point(27, 181);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(142, 17);
            this.lblconfirmpassword.TabIndex = 7;
            this.lblconfirmpassword.Text = "Confirm Password:";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(30, 202);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(164, 22);
            this.txtconfirmpassword.TabIndex = 8;
            // 
            // AdminPasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(259, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminPasswordResetForm";
            this.Text = "AdminPasswordResetForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lbloldpassword;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnadminhome;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
    }
}