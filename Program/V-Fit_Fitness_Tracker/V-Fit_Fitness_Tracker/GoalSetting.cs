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
    public partial class GoalSetting : Form
    {
        public GoalSetting()
        {
            InitializeComponent();
        }
        // Adapter for interacting with the GoalSetting table in the database
        FitnessTrackerDataSetTableAdapters.GoalSettingTableAdapter objGoal = new FitnessTrackerDataSetTableAdapters.GoalSettingTableAdapter();
        DataTable dt = new DataTable();
        public static string MemberID,MemberName, GoalID;

        // Method to automatically generate Goal ID
        public void AutoID_Goal()
        {
            DataTable dtgoal = new DataTable();
            dtgoal = objGoal.GetData();

            if (dtgoal.Rows.Count == 0)
            {
                lblgoalid.Text = "G_001";// If no goals exist, set ID to G_001
            }
            else
            {
                int size = dtgoal.Rows.Count - 1;
                string oldId = dtgoal.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldId.Substring(2, 3));

                if (newID >= 1 && newID < 10)
                {
                    // Generate next ID based on count of existing goals
            
                    lblgoalid.Text = "G_00" + (newID + 1);
                }
                else if (newID > 9 && newID < 100)
                {
                    lblgoalid.Text = "G_0" + (newID + 1);
                }
                else if (newID > 99 && newID < 1000)
                {
                    lblgoalid.Text = "G_" + (newID + 1);
                }
            }
        }

        // Event handler for form load
        private void GoalSetting_Load(object sender, EventArgs e)
        {
            // Set member name and ID from Clubmemberlogin form
            txtmembername.Text  = Clubmemberlogin.MemberName;

            MemberID = Clubmemberlogin.MemberID;

            AutoID_Goal(); // Automatically generate Goal ID
        }

        // Event handler for end date value change
        private void dtpenddate_ValueChanged(object sender, EventArgs e)
        {
            DateTime startdate, enddate;

            TimeSpan difference;

            startdate = dtpstartdate.Value;

            enddate = dtpenddate.Value;

            difference = enddate - startdate;

            txtduration.Text = difference.TotalDays.ToString();// Calculate and display duration in days
        }

        // Event handler for record button click
        private void btnrecord_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txttargetweight.Text) >= 2 && Convert.ToInt32(txttargetweight.Text) <= 6)
            {
                // Insert goal data into the database
                int goaldata = objGoal.InsertGoal(lblgoalid.Text.ToString(), MemberID, Convert.ToString(dtpstartdate.Value), Convert.ToString(dtpenddate.Value), Convert.ToInt32(txtduration.Text), Convert.ToInt32(txttargetweight.Text));

                if (goaldata > 0)
                {
                    // Close the form after successfully setting the goal
                
                    MessageBox.Show("Member has successfully set Goal.");

                    this.Hide();
                    Clubmember_Home CH = new Clubmember_Home();
                    CH.Show();
                }
            }
                
            else
            {
                   MessageBox.Show("Invalid Target weight.");

            } 
           
        }

        // Event handler for close button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event handler for club member home button click
        private void btnclubmemberhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clubmember_Home CH = new Clubmember_Home();
            CH.Show();// Show Club Member Home form
        }

    }
}
