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
    public partial class ClubmemberRegister : Form
    {
        // Initialize the data adapter for clubmember registration
        FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter objClubmember = new FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter();
        DataTable dtClubmember = new DataTable();

        public ClubmemberRegister()
        {
            InitializeComponent();
            AutoID_Clubmember();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            // Hide the Data Grid View
            dtClubmember = objClubmember.GetData();
            dgvshowdataclubmember.Hide();
        }

        // Method to generate automatic clubmember ID
        public void AutoID_Clubmember()
        {
            DataTable dt = new DataTable();
            dt = objClubmember.GetData();

            if (dt.Rows.Count == 0)
            {
                txtmemberid.Text = "C_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldId = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldId.Substring(2, 3));

                if (newID >= 1 && newID < 10)
                {
                    txtmemberid.Text = "C_00" + (newID + 1);
                }
                else if (newID > 9 && newID < 100)
                {
                    txtmemberid.Text = "C_0" + (newID + 1);
                }
                else if (newID > 99 && newID < 1000)
                {
                    txtmemberid.Text = "C_" + (newID + 1);
                }
            }
        }
        // Method to clear input data
        public void ClearData()
        {
            txtmemberid.Clear();
            txtmembername.Clear();
            txtemail.Clear();
            txtweight.Clear();
            rdofemale.Checked = false;
            rdomale.Checked = false;
            txtphno.Clear();
            txtpassword.Clear();
            txtconfirmpassword.Clear();
            txtaddress.Clear();
            AutoID_Clubmember();
        }

        // Event handler for registering the data
        private void btnregister_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string memberid = txtmemberid.Text;
            string membername = txtmembername.Text;
            string email = txtemail.Text;
            string phoneno = txtphno.Text;
            string password = txtpassword.Text;
            string confirmpassword = txtconfirmpassword.Text;
            string address = txtaddress.Text;
            DateTime currendate = dtpdob.Value;

            string gender = null;
            // Perform validation check
            if (rdofemale.Checked == true)
            {
                gender = rdofemale.Text;
            }
            else if (rdofemale.Checked == true)
            {
                gender = rdomale.Text;
            }

            if (txtmembername.Text == "")
            {
                MessageBox.Show("Please Input Your Name.");
                txtmembername.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Input Your Email Address.");
                txtemail.Focus();
            }
            else if (txtweight.Text == "")
            {
                MessageBox.Show("Please Input Your Weight.");
                txtweight.Focus();
            }
            else if (txtphno.Text == "")
            {
                MessageBox.Show("Please Input Your Phone Number.");
                txtphno.Focus();
            }
            else if (cboactivities.Text == "")
            {
                MessageBox.Show("Please Choose Your Activities");
                cboactivities.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Input Your Address.");
                txtaddress.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Input Your Password");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one digit");
                txtpassword.Focus();
            }
            else if (txtpassword.Text.Length < 8 || txtpassword.Text.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters");
                txtpassword.Focus();
            }
            else if (txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Please Input Password to confirm");
                txtconfirmpassword.Focus();
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Please Reinput Password to Confirm");
                txtconfirmpassword.Focus();
            }
            else
            {
                // Convert weight to an integer
                int weight = Convert.ToInt32(txtweight.Text);

                // Validate input fields, insert new clubmember record, refresh DataGridView
                objClubmember.Insert(txtmemberid.Text, txtmembername.Text, txtemail.Text, gender, weight, txtphno.Text, currendate, cboactivities.SelectedItem.ToString(), txtpassword.Text, txtaddress.Text);
                dtClubmember = objClubmember.GetData();
                MessageBox.Show("Successfully Registered");
                AutoID_Clubmember();
                dtClubmember = objClubmember.GetData();
                dgvshowdataclubmember.DataSource = dtClubmember;
                dgvshowdataclubmember.Refresh();

                btnupdate.Enabled = false;
                btnregister.Enabled = true;
                btndelete.Enabled = false;
                Clubmemberlogin CL = new Clubmemberlogin();
                CL.Show();
                this.Hide();
            }

        }

        // Event handler for DataGridView cellmouse click
        private void dgvshowdataclubmember_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Populate input fields with data from selected DataGridView row
            DataGridViewRow row = this.dgvshowdataclubmember.Rows[e.RowIndex];
            txtmemberid.Text = row.Cells[0].Value.ToString();
            txtmembername.Text = row.Cells[1].Value.ToString();
            txtemail.Text = row.Cells[2].Value.ToString();
            txtweight.Text = row.Cells[4].Value.ToString();
            txtphno.Text = row.Cells[5].Value.ToString();
            txtpassword.Text = row.Cells[8].Value.ToString();
            txtaddress.Text = row.Cells[9].Value.ToString();

            btnupdate.Enabled = true;
        }

        // Event handler for deleting the selected data
        private void btndelete_Click(object sender, EventArgs e)
        {
            // Delete selected clubmember record from the database
            objClubmember.DeleteClubmember(txtmemberid.Text);
            MessageBox.Show("Successfully Deleted!");

            dtClubmember = objClubmember.GetData();
            dgvshowdataclubmember.DataSource = dtClubmember;
            dgvshowdataclubmember.Refresh();
            AutoID_Clubmember();

            btndelete.Enabled = true;

        }

        // Event handler for updating the data in the database
        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string memberid = txtmemberid.Text;
            string membername = txtmembername.Text;
            string email = txtemail.Text;
            string phoneno = txtphno.Text;
            string password = txtpassword.Text;
            string confirmpassword = txtconfirmpassword.Text;
            string address = txtaddress.Text;
            DateTime currendate = dtpdob.Value;
            string gender = null;
            // Perform validation check
            if (rdofemale.Checked == true)
            {
                gender = rdofemale.Text;
            }
            else
            {
                gender = rdomale.Text;
            }

            if (txtmembername.Text == "")
            {
                MessageBox.Show("Please Input Your Name.");
                txtmembername.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Input Your Email Address.");
                txtemail.Focus();
            }

            else if (txtweight.Text == "")
            {
                MessageBox.Show("Please Input Your Weight.");
                txtweight.Focus();
            }
            else if (txtphno.Text == "")
            {
                MessageBox.Show("Please Input Your Phone Number.");
                txtphno.Focus();
            }
            else if (cboactivities.Text == "")
            {
                MessageBox.Show("Please Choose Your Activities");
                cboactivities.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Input Your Address.");
                txtaddress.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Input Your Password");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain upper one letter");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contian lower characters");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain one digit");
                txtpassword.Focus();
            }
            else if (txtpassword.Text.Length < 8 || txtpassword.Text.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters");
                txtpassword.Focus();
            }
            else if (txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Please Input Password to confirm");
                txtconfirmpassword.Focus();
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Please Reinput Password to Confirm");
                txtconfirmpassword.Focus();
            }
            else
            {
                // Convert weight to an integer
                int weight = Convert.ToInt32(txtweight.Text);
                // Update clubmember record in the database
                objClubmember.UpdateClubmember(txtmembername.Text, txtemail.Text, gender, weight, txtphno.Text, currendate, cboactivities.SelectedItem.ToString(), txtpassword.Text, txtaddress.Text, txtmemberid.Text);
                dtClubmember = objClubmember.GetData();
                MessageBox.Show("Successfully Updated.");
                // Refresh DataGridView
                AutoID_Clubmember();
                dtClubmember = objClubmember.GetData();
                dgvshowdataclubmember.DataSource = dtClubmember;
                dgvshowdataclubmember.Refresh();


                btnupdate.Enabled = true;
                btnregister.Enabled = false;
                btndelete.Enabled = false;
                Clubmemberlogin CL = new Clubmemberlogin();
                CL.Show();
                this.Hide();
            }

        }

        // Method to clear the inputted data
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        // Method to close the form
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
