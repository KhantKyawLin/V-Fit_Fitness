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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
            // Set the label text to the admin's name retrieved from the login
            lblname.Text = AdminLogin.AdminName;
        }
        // Event handler for admin registration button click
        private void btnadminregister_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the admin registration full control form
            this.Hide();
            AdminRegisterFullControl AF = new AdminRegisterFullControl();
            AF.Show();
        }
        // Event handler for admin login button click
        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin AL = new AdminLogin();
            AL.Show();
        }
        // Event handler for club member registration button click
        private void btnclubmemberregister_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the club member registration full  control form
            this.Hide();
            ClubMemberRegisterFullControl CF = new ClubMemberRegisterFullControl();
            CF.Show();
        }

        // Event handler for club member login button click
        private void btnclubmemberlogin_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the club member login form
            this.Hide();
            Clubmemberlogin CL = new Clubmemberlogin();
            CL.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        // Event handler for activities button click
        private void btnactivities_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the activities form
            this.Hide();
            Activities Act = new Activities();
            Act.Show();
        }
        // Event handler for close button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
        // Event handler for change password button click
        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the admin password reset form
            this.Hide();
            AdminPasswordResetForm AR = new AdminPasswordResetForm();
            AR .Show ();
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
    }
}
