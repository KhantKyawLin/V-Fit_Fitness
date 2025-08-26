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
    public partial class AdminPasswordResetForm : Form
    {
        public AdminPasswordResetForm()
        {
            InitializeComponent();
        }
        // Initialize data adapter and DataTable
        FitnessTrackerDataSetTableAdapters.AdminTableAdapter objadmin = new FitnessTrackerDataSetTableAdapters.AdminTableAdapter();
        DataTable dtadmin = new DataTable();

        // Event handler for "Admin Home" button click
        private void btnadminhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home AH = new Admin_Home();
            AH.Show();
        }


        // Event handler for "Change" button click
        private void btnchange_Click(object sender, EventArgs e)
        {
            // Retrieve old password, new password, and confirm password
            string oldpassword, newpassword, confirmpassword;
            oldpassword = txtoldpassword.Text;
            newpassword = txtnewpassword.Text;
            confirmpassword = txtconfirmpassword.Text;
            /// Check if the old password matches the current admin's password
            dtadmin = objadmin.AdminCheckPassword(oldpassword);
            if (dtadmin.Rows.Count > 0)
            {
                // Validate the new password first
                if (txtnewpassword.Text == "")
                {
                    MessageBox.Show("Please Input Your Password");
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
                else if (txtnewpassword.Text.Length < 8 || txtnewpassword.Text.Length > 16)
                {
                    MessageBox.Show("Password must be between 8 and 16 characters");
                    txtnewpassword.Focus();
                }
                else if (txtconfirmpassword.Text == "")
                {
                    MessageBox.Show("Please Input Password to confirm");
                    txtconfirmpassword.Focus();
                }
                else if (txtnewpassword.Text != txtconfirmpassword.Text)
                {
                    MessageBox.Show("Please Reinput Password to Confirm");
                    txtconfirmpassword.Focus();
                }
                else
                {
                    // If new password is valid, proceed with updating
                    string aid = AdminLogin.AdminID;
                    int data = objadmin.AdminUpdatePassword(newpassword, aid);

                    // Update the password in the database
                    if (data > 0)
                    {
                        MessageBox.Show("Successfully changed Password");
                        this.Close();
                        AdminLogin AL = new AdminLogin();
                        AL.Show();
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
            Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }
    }
}
