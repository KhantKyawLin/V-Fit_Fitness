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
    public partial class Clubmember_Home : Form
    {
        public Clubmember_Home()
        {
            InitializeComponent();
            // Set the label text to the club member's name retrieved from the login form
            lblname.Text = Clubmemberlogin.MemberName;
        }
        // Event handler for member login button click
        private void btnmemberlogin_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the clubmember login form
            this.Hide();
            Clubmemberlogin CL = new Clubmemberlogin();
            CL.Show();
        }
        // Event handler for clubmember registration button click
        private void btnclubmemberregister_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the clubmember registration  clubmember form
            this.Hide();
            ClubMemberRegisterMember CM = new ClubMemberRegisterMember();
            CM.Show();
        }
        // Event handler for club member goal setting button click
        private void btnclubmembergoal_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the goal setting form
            this.Hide();
            GoalSetting GS = new GoalSetting();
            GS.Show();
        }
        // Event handler for progress information button click
        private void btnprogressinfo_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the progress information form
            this.Hide();
            ProgressInformation PI = new ProgressInformation();
            PI.Show();
        }
        // Event handler for reset password button click
        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the password reset form
            this.Hide();
            PasswordResetForm PR = new PasswordResetForm();
            PR.Show();
        }
        // Event handler for close button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
        // Event handler for logout button click
        private void btnlogout_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the welcome form
            this.Hide();
            Introwelcomeform IF = new Introwelcomeform();
            IF.Show();
        }
        // Event handler for report button click
        private void btnreport_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the report form
            this.Hide();
            ReportForm RF = new ReportForm();
            RF.Show();
        }
        // Event handler for activities information button click
        private void btnactivitiesinfo_Click(object sender, EventArgs e)
        { 
            // Event handler for activities information button click
            this.Hide();
            ActivitiesInfo AI = new ActivitiesInfo();
            AI.Show();
        }
    }
}
