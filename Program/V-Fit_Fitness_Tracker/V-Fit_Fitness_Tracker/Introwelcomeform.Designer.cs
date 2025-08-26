namespace V_Fit_Fitness_Tracker
{
    partial class Introwelcomeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmemberlogin = new System.Windows.Forms.Button();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.lbldescription = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(169, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "V-Fit\r\nFitness Tracker";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmemberlogin);
            this.groupBox2.Controls.Add(this.btnadminlogin);
            this.groupBox2.Controls.Add(this.lbldescription);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Welcome To V-Fit Fitness Tracker";
            // 
            // btnmemberlogin
            // 
            this.btnmemberlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnmemberlogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnmemberlogin.Location = new System.Drawing.Point(343, 212);
            this.btnmemberlogin.Name = "btnmemberlogin";
            this.btnmemberlogin.Size = new System.Drawing.Size(90, 59);
            this.btnmemberlogin.TabIndex = 4;
            this.btnmemberlogin.Text = "Member Login";
            this.btnmemberlogin.UseVisualStyleBackColor = false;
            this.btnmemberlogin.Click += new System.EventHandler(this.btnmemberlogin_Click);
            // 
            // btnadminlogin
            // 
            this.btnadminlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnadminlogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnadminlogin.Location = new System.Drawing.Point(55, 212);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(90, 59);
            this.btnadminlogin.TabIndex = 3;
            this.btnadminlogin.Text = "Admin Login";
            this.btnadminlogin.UseVisualStyleBackColor = false;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.ForeColor = System.Drawing.Color.DimGray;
            this.lbldescription.Location = new System.Drawing.Point(27, 22);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(446, 17);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Please click login button to log in  as admin or club member.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.newmemberlogo1;
            this.pictureBox3.Location = new System.Drawing.Point(313, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.trainerlogo2;
            this.pictureBox2.Location = new System.Drawing.Point(27, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.fittnesslogoicon1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Introwelcomeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(578, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Introwelcomeform";
            this.Text = "Introwelcomeform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnmemberlogin;
        private System.Windows.Forms.Button btnadminlogin;
        private System.Windows.Forms.Label lbldescription;
    }
}