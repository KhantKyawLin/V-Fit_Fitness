namespace V_Fit_Fitness_Tracker
{
    partial class GoalSetting
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
            this.btnrecord = new System.Windows.Forms.Button();
            this.txtmembername = new System.Windows.Forms.TextBox();
            this.lblkg = new System.Windows.Forms.Label();
            this.txttargetweight = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.lblgoalid = new System.Windows.Forms.Label();
            this.lbltargetweight = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.lblmembername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclubmemberhome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclubmemberhome);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnrecord);
            this.groupBox1.Controls.Add(this.txtmembername);
            this.groupBox1.Controls.Add(this.lblkg);
            this.groupBox1.Controls.Add(this.txttargetweight);
            this.groupBox1.Controls.Add(this.txtduration);
            this.groupBox1.Controls.Add(this.dtpenddate);
            this.groupBox1.Controls.Add(this.dtpstartdate);
            this.groupBox1.Controls.Add(this.lblgoalid);
            this.groupBox1.Controls.Add(this.lbltargetweight);
            this.groupBox1.Controls.Add(this.lblduration);
            this.groupBox1.Controls.Add(this.lblenddate);
            this.groupBox1.Controls.Add(this.lblstartdate);
            this.groupBox1.Controls.Add(this.lblmembername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Your Goal.";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(270, 183);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 37);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnrecord
            // 
            this.btnrecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnrecord.Location = new System.Drawing.Point(109, 183);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(75, 37);
            this.btnrecord.TabIndex = 13;
            this.btnrecord.Text = "Record";
            this.btnrecord.UseVisualStyleBackColor = false;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // txtmembername
            // 
            this.txtmembername.Location = new System.Drawing.Point(363, 42);
            this.txtmembername.Name = "txtmembername";
            this.txtmembername.Size = new System.Drawing.Size(139, 22);
            this.txtmembername.TabIndex = 12;
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(475, 134);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(27, 17);
            this.lblkg.TabIndex = 11;
            this.lblkg.Text = "Kg";
            // 
            // txttargetweight
            // 
            this.txttargetweight.Location = new System.Drawing.Point(363, 131);
            this.txttargetweight.Name = "txttargetweight";
            this.txttargetweight.Size = new System.Drawing.Size(109, 22);
            this.txttargetweight.TabIndex = 10;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(109, 131);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(109, 22);
            this.txtduration.TabIndex = 9;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(363, 85);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(139, 22);
            this.dtpenddate.TabIndex = 8;
            this.dtpenddate.ValueChanged += new System.EventHandler(this.dtpenddate_ValueChanged);
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartdate.Location = new System.Drawing.Point(111, 85);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(109, 22);
            this.dtpstartdate.TabIndex = 7;
            // 
            // lblgoalid
            // 
            this.lblgoalid.AutoSize = true;
            this.lblgoalid.Location = new System.Drawing.Point(108, 42);
            this.lblgoalid.Name = "lblgoalid";
            this.lblgoalid.Size = new System.Drawing.Size(0, 17);
            this.lblgoalid.TabIndex = 6;
            // 
            // lbltargetweight
            // 
            this.lbltargetweight.AutoSize = true;
            this.lbltargetweight.Location = new System.Drawing.Point(241, 131);
            this.lbltargetweight.Name = "lbltargetweight";
            this.lbltargetweight.Size = new System.Drawing.Size(116, 17);
            this.lbltargetweight.TabIndex = 5;
            this.lbltargetweight.Text = "Target Weight:";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Location = new System.Drawing.Point(18, 131);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(75, 17);
            this.lblduration.TabIndex = 4;
            this.lblduration.Text = "Duration:";
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Location = new System.Drawing.Point(241, 85);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(80, 17);
            this.lblenddate.TabIndex = 3;
            this.lblenddate.Text = "End Date:";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Location = new System.Drawing.Point(18, 85);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(87, 17);
            this.lblstartdate.TabIndex = 2;
            this.lblstartdate.Text = "Start Date:";
            // 
            // lblmembername
            // 
            this.lblmembername.AutoSize = true;
            this.lblmembername.Location = new System.Drawing.Point(241, 42);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(116, 17);
            this.lblmembername.TabIndex = 1;
            this.lblmembername.Text = "Member Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
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
            this.pictureBox1.Image = global::V_Fit_Fitness_Tracker.Properties.Resources.fittnesslogoicon11;
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnclubmemberhome
            // 
            this.btnclubmemberhome.Location = new System.Drawing.Point(6, 191);
            this.btnclubmemberhome.Name = "btnclubmemberhome";
            this.btnclubmemberhome.Size = new System.Drawing.Size(50, 29);
            this.btnclubmemberhome.TabIndex = 15;
            this.btnclubmemberhome.Text = "<<<";
            this.btnclubmemberhome.UseVisualStyleBackColor = true;
            this.btnclubmemberhome.Click += new System.EventHandler(this.btnclubmemberhome_Click);
            // 
            // GoalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoalSetting";
            this.Text = "GoalSetting";
            this.Load += new System.EventHandler(this.GoalSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltargetweight;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Label lblmembername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgoalid;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.TextBox txtmembername;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.TextBox txttargetweight;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclubmemberhome;
    }
}