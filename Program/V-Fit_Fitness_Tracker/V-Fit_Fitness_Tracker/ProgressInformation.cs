using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Fit_Fitness_Tracker
{
    public partial class ProgressInformation : Form
    {
        public ProgressInformation()
        {
            InitializeComponent();
        }
        // Initialize data tableadapters
        FitnessTrackerDataSetTableAdapters.ClubmemberInfoTableAdapter objclubmemberinfo = new FitnessTrackerDataSetTableAdapters.ClubmemberInfoTableAdapter();
        FitnessTrackerDataSetTableAdapters.ActivityTableAdapter objactivity = new FitnessTrackerDataSetTableAdapters.ActivityTableAdapter();
        FitnessTrackerDataSetTableAdapters.ProgressInfoTableAdapter objprogressinfo = new FitnessTrackerDataSetTableAdapters.ProgressInfoTableAdapter();
        FitnessTrackerDataSetTableAdapters.ProgressDetailsTableAdapter objprogressdetails = new FitnessTrackerDataSetTableAdapters.ProgressDetailsTableAdapter();

        // Define data table for DataGridView
        DataTable dtdgvinfo = new DataTable();
        DataRow dr;
        decimal  TotalCal = 0;
        int varforremove;
        public static string progressid;
        int pdetails;

        // Method to generate automatic progress ID
        public void AutoID_Progress()
        {
            DataTable dt = new DataTable();
            dt = objprogressinfo.GetData();

            if (dt.Rows.Count == 0)
            {
                progressid = "P_001";
            }
            else
            {
                // Extract the last ID and generate the next one
                int size = dt.Rows.Count - 1;
                string oldId = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldId.Substring(2, 3));

                if (newID >= 1 && newID < 9)
                {
                    progressid = "P_00" + (newID + 1);
                }
                else if (newID > 9 && newID < 99)
                {
                    progressid = "P_0" + (newID + 1);
                }
                else if (newID > 99 && newID < 999)
                {
                    progressid = "P_" + (newID + 1);
                }
            }
        }
        //Event handler for the form load
        private void ProgressInformation_Load(object sender, EventArgs e)
        {
            AutoID_Progress();
            btnremove.Enabled = false;
            ProgressInformationDisplay();
            DataTable dt = new DataTable();
            string mid = Clubmemberlogin.MemberID;
            lblclubmembername.Text = Clubmemberlogin.MemberName;
            dt = objclubmemberinfo.CheckData(mid);
            if (dt.Rows.Count > 0)
            {
                // Load club member information
                lblclubmembername.Text = dt.Rows[0][1].ToString();
                lblweight.Text = dt.Rows[0][2].ToString();
                lblduration.Text = dt.Rows[0][3].ToString();
                lbltargetweight.Text = dt.Rows[0][4].ToString();
                lblstartdate.Text = dt.Rows[0][5].ToString();
                
            }
            DataTable dtact = new DataTable();
            dtact = objactivity.GetData();
            if (dtact.Rows.Count > 0)
            {
                for (int k = 0; k < dtact.Rows.Count; k++)
                {
                    // Load activity names into the combo box
                cboactivities .Items .Add(dtact .Rows [k][1].ToString ());
                }
            }
        }

        // Method to initialize DataGridView
        private void ProgressInformationDisplay()
        {
            // Add columns to the data table
            dr = dtdgvinfo.NewRow();
            dtdgvinfo.Columns.Add("Member ID").ToString();
            dtdgvinfo.Columns.Add("Member Name").ToString();
            dtdgvinfo.Columns.Add("Activity Name").ToString();
            dtdgvinfo.Columns.Add("Duration").ToString();
            dtdgvinfo.Columns.Add("Weight").ToString();
            dtdgvinfo.Columns.Add("MET").ToString();
            dtdgvinfo.Columns.Add("Calorie Burned").ToString();
            dgvprogressinfo.DataSource = dtdgvinfo;
            dgvprogressinfo.Refresh();
        }
        private void lblactivities_Click(object sender, EventArgs e)
        {

        }

        // Selected index changed event handler for combo box
        private void cboactivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtact = new DataTable();
            string activities;
            activities = cboactivities.SelectedItem.ToString();
            dtact = objactivity.CheckActName(activities);
            if (dtact.Rows.Count > 0)
            {
                txtmet.Text = dtact.Rows[0]["MET"].ToString();
            }
        }
        // Add button click event handler
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtactduration.Text == "")
                {
                    MessageBox.Show("Please input activity duration.");
                    txtactduration.Focus();
                }
                else if (cboactivities.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose Activity.");
                    cboactivities.Focus();
                }
                else
                {
                    // Retrieve input values
                    string MemberID, MemberName, Activity;
                    int Actduration, TotalActivities = 0;
                    decimal weight, met, calburned;
                    MemberID = Clubmemberlogin.MemberID;
                    MemberName = lblclubmembername.Text;
                    Activity = cboactivities.SelectedItem.ToString();
                    Actduration = Convert.ToInt32(txtactduration.Text);
                    weight = Convert.ToDecimal(lblweight.Text);
                    met = Convert.ToDecimal (txtmet.Text);
                    calburned = (met * weight * Actduration)/60;
                    dr = dtdgvinfo.NewRow();

                    int flag = -1;
                    // Check for duplicate entry
                    for (int k = 0; k < dgvprogressinfo.Rows.Count; k++)
                    {
                        if (Convert.ToString(dgvprogressinfo.Rows[k].Cells["Activity Name"].Value) == cboactivities.Text)
                        {
                            MessageBox.Show("Duplicate Entry");
                            flag = k;
                            break;
                        }
                    }
                    if (flag == -1)
                    {
                        TotalCal = 0;
                        dr[0] = MemberID;
                        dr[1] = MemberName;
                        dr[2] = Activity;
                        dr[3] = Actduration;
                        dr[4] = weight;
                        dr[5] = met;
                        dr[6] = calburned;
                        dtdgvinfo.Rows.Add(dr);
                        dgvprogressinfo.DataSource = dtdgvinfo;
                        dgvprogressinfo.Refresh();
                        for (int k = 0; k < dgvprogressinfo.Rows.Count; k++)
                        {
                             TotalCal  += Convert.ToDecimal (dgvprogressinfo.Rows[k].Cells["Calorie Burned"].Value);
                            TotalActivities += 1;
                        }
                        lblcalburned.Text = Convert.ToString(TotalCal);
                        lbltotalact.Text = Convert.ToString(TotalActivities);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
        }
        // Cell mouse click event handler for DataGridView
        private void dgvprogressinfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnremove.Enabled = true;
            varforremove = dgvprogressinfo.CurrentRow.Index;

        }
        // Remove button click event handler
        private void btnremove_Click(object sender, EventArgs e)
        {
            decimal temp = 0;
            int k = dgvprogressinfo.CurrentRow.Index;
            decimal rdata = Convert.ToDecimal(dgvprogressinfo["Calorie Burned", k].Value.ToString());
            temp = Convert.ToDecimal(lblcalburned.Text);

            lblcalburned.Text = Convert.ToString(temp - rdata);
            lbltotalact.Text = Convert.ToString(Convert.ToDecimal(lbltotalact.Text) - 1);
            this.dgvprogressinfo.Rows.RemoveAt(varforremove);
        }
        // Save button click event handler
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (dtdgvinfo.Rows.Count < 0)
            {
                MessageBox.Show("There is no activity");
            }
            else
            {
                string  status = "Progressinfo";
                DateTime progressdate;
                int totalact;
                string totalcal;
                progressdate = Convert.ToDateTime(lblstartdate.Text);
                totalact = Convert.ToInt32(lbltotalact.Text);
                totalcal = (lblcalburned.Text);
                int data = objprogressinfo.InsertProgressInfo(progressid, progressdate.ToString (), Clubmemberlogin.MemberID, totalact, totalcal, status);
                if (data > 0)
                {
                    DataTable dtact = new DataTable();
                    for (int k = 0; k < dgvprogressinfo.Rows.Count; k++)
                    {
                        string actname = dgvprogressinfo.Rows[k].Cells["Activity Name"].Value.ToString();
                        dtact = objactivity.CheckActName(actname);
                        string actid = dtact.Rows[0][0].ToString();
                        int duration = Convert.ToInt32(dgvprogressinfo.Rows[k].Cells["Duration"].Value.ToString());
                        string met = (dgvprogressinfo.Rows[k].Cells["MET"].Value.ToString());
                        string calburned = (dgvprogressinfo.Rows[k].Cells["Calorie Burned"].Value.ToString());
                        pdetails=objprogressdetails.InsertProgressDetails (progressid,actid  ,duration,met ,calburned);

                    }
                    if (pdetails > 0)
                    {
                        decimal TotalCB = Convert.ToDecimal(lblcalburned.Text);
                        decimal TotalW = Convert.ToDecimal(lbltargetweight.Text);
                        if (TotalCB > TotalW)
                        {
                            MessageBox.Show("Congratulation! Your target is achieved.");
                            this.Hide();
                            Clubmember_Home CH = new Clubmember_Home();
                            CH.Show();
                        }
                    }
                }
            }
        }
        // Event handler for the "Member Home" button click
        private void btnmemberhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clubmember_Home CH = new Clubmember_Home();
            CH.Show();
        }

    }
}
 
