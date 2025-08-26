namespace V_Fit_Fitness_Tracker
{
    partial class ReportForm
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
            this.cbofindid = new System.Windows.Forms.ComboBox();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.rdofindbyid = new System.Windows.Forms.RadioButton();
            this.rdofindbydate = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvreport = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.cbofindid);
            this.groupBox1.Controls.Add(this.btnshowall);
            this.groupBox1.Controls.Add(this.btnfind);
            this.groupBox1.Controls.Add(this.lblenddate);
            this.groupBox1.Controls.Add(this.lblstartdate);
            this.groupBox1.Controls.Add(this.dtpenddate);
            this.groupBox1.Controls.Add(this.dtpstartdate);
            this.groupBox1.Controls.Add(this.rdofindbyid);
            this.groupBox1.Controls.Add(this.rdofindbydate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "V-Fit Progress Report Form";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Location = new System.Drawing.Point(470, 215);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 33);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cbofindid
            // 
            this.cbofindid.FormattingEnabled = true;
            this.cbofindid.Location = new System.Drawing.Point(417, 111);
            this.cbofindid.Name = "cbofindid";
            this.cbofindid.Size = new System.Drawing.Size(169, 24);
            this.cbofindid.TabIndex = 8;
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnshowall.Location = new System.Drawing.Point(307, 215);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(96, 33);
            this.btnshowall.TabIndex = 7;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnfind.Location = new System.Drawing.Point(138, 215);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(83, 33);
            this.btnfind.TabIndex = 6;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Location = new System.Drawing.Point(24, 161);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(80, 17);
            this.lblenddate.TabIndex = 5;
            this.lblenddate.Text = "End Date:";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Location = new System.Drawing.Point(24, 111);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(87, 17);
            this.lblstartdate.TabIndex = 4;
            this.lblstartdate.Text = "Start Date:";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(118, 161);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(169, 22);
            this.dtpenddate.TabIndex = 3;
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartdate.Location = new System.Drawing.Point(118, 111);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(169, 22);
            this.dtpstartdate.TabIndex = 2;
            // 
            // rdofindbyid
            // 
            this.rdofindbyid.AutoSize = true;
            this.rdofindbyid.Location = new System.Drawing.Point(417, 47);
            this.rdofindbyid.Name = "rdofindbyid";
            this.rdofindbyid.Size = new System.Drawing.Size(178, 21);
            this.rdofindbyid.TabIndex = 1;
            this.rdofindbyid.TabStop = true;
            this.rdofindbyid.Text = "Find By Progress ID:";
            this.rdofindbyid.UseVisualStyleBackColor = true;
            // 
            // rdofindbydate
            // 
            this.rdofindbydate.AutoSize = true;
            this.rdofindbydate.Location = new System.Drawing.Point(27, 47);
            this.rdofindbydate.Name = "rdofindbydate";
            this.rdofindbydate.Size = new System.Drawing.Size(127, 21);
            this.rdofindbydate.TabIndex = 0;
            this.rdofindbydate.TabStop = true;
            this.rdofindbydate.Text = "Find By Date:";
            this.rdofindbydate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvreport);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvreport
            // 
            this.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport.Location = new System.Drawing.Point(6, 22);
            this.dgvreport.Name = "dgvreport";
            this.dgvreport.RowTemplate.Height = 24;
            this.dgvreport.Size = new System.Drawing.Size(647, 170);
            this.dgvreport.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbofindid;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.RadioButton rdofindbyid;
        private System.Windows.Forms.RadioButton rdofindbydate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvreport;
        private System.Windows.Forms.Button btnclose;
    }
}