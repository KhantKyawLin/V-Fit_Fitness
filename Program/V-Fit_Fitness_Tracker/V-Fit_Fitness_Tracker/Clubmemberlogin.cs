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
    public partial class Clubmemberlogin : Form
    {
        // Initialize the data adapter for club member login
        FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter objClubmember = new FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter();

        // Track the number of login attempts
        private int LoginCount = 0;

        // Static variables to hold member ID and name
        public static string MemberID, MemberName;


        public Clubmemberlogin()
        {
            InitializeComponent();
        }

        // Event handler for login button click
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Check if login attempts exceed the limit
            if (LoginCount == 3)
            {
                MessageBox.Show("Login fails three times! You have reached your limit");
            }
            // Check if email field is empty
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please input your email address");
            }
            // Check if password field is empty
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please input your password");
            }
            else
            {
                // Validate login credentials against the database
                DataTable dt = new DataTable();
                dt = objClubmember.ClubmemberLogin(txtemail.Text, txtpassword.Text);

                if (dt.Rows.Count == 1)
                {
                    // If login is successful, show a message and navigate to Clubmember Home
                   
                    MessageBox.Show("Login Successful");
                    dgvshowdataclubmemberlogin.DataSource = dt;
                    MemberID = dgvshowdataclubmemberlogin[0, 0].Value.ToString();
                    MemberName = dgvshowdataclubmemberlogin[1, 0].Value.ToString();
                    Clubmember_Home CH = new Clubmember_Home();
                    CH.Show();
                    this.Hide();
                }
                else
                {
                    // If login fails, increment the login count and show a message
                    LoginCount += 1;
                    LoginCount += 1;
                    MessageBox.Show("Invalid Login! Login Attempt:" + LoginCount);
                }
            }

        }

        // Event handler for register link clicked
        private void lnkregiter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to ClubmemberRegister form
            this.Hide();
            ClubmemberRegister CR = new ClubmemberRegister();
            CR.Show();
        }

        // Event handler for close button clicked
        private void btnclose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}
