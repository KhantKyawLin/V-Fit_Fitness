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
    public partial class PasswordResetForm : Form
    {
        // Initialize data adapter and DataTable
        FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter objclubmember = new FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter();
        DataTable dtclubmember = new DataTable();

        public PasswordResetForm()
        {
            InitializeComponent();
        }

        // Event handler for "Change" button click
        private void btnchange_Click(object sender, EventArgs e)
        {
            // Retrieve old password, new password, and confirm password
            string oldpassword, newpassword, confirmpassword;
            oldpassword = txtoldpassword.Text;
            newpassword = txtnewpassword.Text;
            confirmpassword = txtconfirmpassword.Text;

            // Check if the old password matches the current member's password
            dtclubmember = objclubmember.CheckPassword(oldpassword);
            if (dtclubmember.Rows.Count > 0)
            {
                // Validate the new password first
                if (string.IsNullOrEmpty(newpassword))
                {
                    MessageBox.Show("Please Enter Your Password");
                    txtnewpassword.Focus();
                }
                else if (!newpassword.Any(char.IsUpper))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter");
                    txtnewpassword.Focus();
                }
                else if (!newpassword.Any(char.IsLower))
                {
                    MessageBox.Show("Password must contain at least one lowercase letter");
                    txtnewpassword.Focus();
                }
                else if (!newpassword.Any(char.IsDigit))
                {
                    MessageBox.Show("Password must contain at least one digit");
                    txtnewpassword.Focus();
                }
                else if (newpassword.Length < 8 || newpassword.Length > 16)
                {
                    MessageBox.Show("Password must be between 8 and 16 characters");
                    txtnewpassword.Focus();
                }
                else if (string.IsNullOrEmpty(confirmpassword))
                {
                    MessageBox.Show("Please Enter Password to confirm");
                    txtconfirmpassword.Focus();
                }
                else if (newpassword != confirmpassword)
                {
                    MessageBox.Show("Passwords do not match");
                    txtconfirmpassword.Focus();
                }
                else
                {
                    // If new password is valid, proceed with updating
                    string cid = Clubmemberlogin.MemberID;
                    int data = objclubmember.UpdatePassword(newpassword, cid);

                    // Update the password in the database
                    if (data > 0)
                    {
                        MessageBox.Show("Successfully changed Password");
                        this.Close();
                        Clubmemberlogin CL = new Clubmemberlogin();
                        CL.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect old password. Please try again.");
                txtoldpassword.Focus();
            }
        }

        // Event handler for "Close" button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        // Event handler for "Member Home" button click
        private void btnmemberhome_Click(object sender, EventArgs e)
        {
            // Navigate back to Club Member Home form
            this.Hide();
            Clubmember_Home CH = new Clubmember_Home();
            CH.Show();
        }
    }
}
