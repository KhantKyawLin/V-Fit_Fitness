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
    public partial class AdminRegister : Form
    {
        // Initialize the data adapter for admin registration
        FitnessTrackerDataSetTableAdapters.AdminTableAdapter objAdmin = new FitnessTrackerDataSetTableAdapters.AdminTableAdapter();
        DataTable dtAdmin = new DataTable();

        public AdminRegister()
        {
            InitializeComponent();
            AutoID_Admin();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            //hide the datagrid view
            dgvshowdataadmin.Hide();
            
            dtAdmin = objAdmin.GetData();
            
        }

        // Method to generate automatic admin ID
        public void AutoID_Admin()
        {
            DataTable dt = new DataTable();
            dt = objAdmin.GetData();

            if (dt.Rows.Count == 0)
            {
                txtadminid.Text = "A_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldId = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldId.Substring(2, 3));

                if (newID >= 1 && newID < 9)
                {
                    txtadminid.Text = "A_00" + (newID + 1);
                }
                else if (newID > 9 && newID < 99)
                {
                    txtadminid.Text = "A_0" + (newID + 1);
                }
                else if (newID > 99 && newID < 999)
                {
                    txtadminid.Text = "A_" + (newID + 1);
                }
            }
        }

        
        private void lbladminid_Click(object sender, EventArgs e)
        {

        }

        // Event handler for updating the admin recorded data
        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string adminid = txtadminid.Text;
            string adminname = txtadminname.Text;
            string email = txtemail.Text;
            string phoneno = txtphno.Text;
            string password = txtpassword.Text;
            string confirmpassword = txtconfirmpassword.Text;
            string address = txtaddress.Text;

            // Perform validation check
            if (txtadminname.Text == "")
            {
                MessageBox.Show("Please Input Your Name.");
                txtadminname.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Input Your Email Address.");
                txtemail.Focus();
            }
            else if (txtphno.Text == "")
            {
                MessageBox.Show("Please Input Your Phone Number.");
                txtphno.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Input Your Password.");
                txtpassword.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Input Your  Address.");
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain upper one letter.");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contian lower characters.");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain one digit.");
                txtpassword.Focus();
            }
            else if (txtpassword.Text.Length < 8 || txtpassword.Text.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters.");
                txtpassword.Focus();
            }
            else if (txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Please Input Password to confirm.");
                txtconfirmpassword.Focus();
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Please Reinput Password to Confirm.");
                txtconfirmpassword.Focus();
            }
            else
            {
                // Create an instance of Admin_Encapsulation and populate with data
                Admin_Encapsulation AE = new Admin_Encapsulation();
                AE.AdminID = txtadminid.Text;
                AE.AdminName = txtadminname.Text;
                AE.Email = txtemail.Text;
                AE.PhoneNo = txtphno.Text;
                AE.Password = txtpassword.Text;
                AE.ConfirmPassword = txtconfirmpassword.Text;
                AE.Address = txtaddress.Text;

                // Update admin record in the database
                objAdmin.UpdateAdmin(AE.AdminName, AE.Email, AE.PhoneNo, AE.Password, AE.Address,AE.AdminID);
                MessageBox.Show("Successfully Updated!");

                // Refresh DataGridView 
                AutoID_Admin();
                dtAdmin = objAdmin.GetData();
                dgvshowdataadmin.DataSource = dtAdmin;
                dgvshowdataadmin.Refresh();
                AdminLogin AL = new AdminLogin();
                AL.Show();
                this.Hide();
                btnupdate.Enabled = true;
                btnregister.Enabled = false;
                btndelete.Enabled = false;
               
            }
        }

        // Event handler for registering the data
        private void btnregister_Click(object sender, EventArgs e)
        {
            string adminid = txtadminid.Text;
            string adminname = txtadminname.Text;
            string email = txtemail.Text;
            string phoneno = txtphno.Text;
            string password = txtpassword.Text;
            string confirmpassword = txtconfirmpassword.Text;
            string address = txtaddress.Text;

            // Perform validation check
            if (txtadminname.Text == "")
            {
                MessageBox.Show("Please Input Your Name.");
                txtadminname.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Input Your Email Address.");
                txtemail.Focus();
            }
            else if (txtphno.Text == "")
            {
                MessageBox.Show("Please Input Your Phone Number.");
                txtphno.Focus();
            }
            else  if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Input Your Password.");
                txtpassword.Focus();
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Input Your Address.");
            }
            else if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain upper one letter.");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contian lower characters.");
                txtpassword.Focus();
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain one digit.");
                txtpassword.Focus();
            }
            else if (txtpassword.Text.Length < 8 || txtpassword.Text.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters.");
                txtpassword.Focus();
            }
            else if (txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Please Input Password to confirm.");
                txtconfirmpassword.Focus();
            }
            else if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show("Please Reinput Password to Confirm");
                txtconfirmpassword.Focus();
            }
            else
            {
                Admin_Encapsulation AE = new Admin_Encapsulation();
                AE.AdminID = txtadminid.Text;
                AE.AdminName = txtadminname.Text;
                AE.Email = txtemail.Text;
                AE.PhoneNo = txtphno.Text;
                AE.Password = txtpassword.Text;
                AE.ConfirmPassword = txtconfirmpassword.Text;
                AE.Address= txtaddress.Text;

                // Validate input fields, insert new admin record, refresh DataGridView
                objAdmin.Insert(AE.AdminID, AE.AdminName, AE.Email, AE.PhoneNo, AE.Password, AE.Address);
                dtAdmin = objAdmin.GetData();
                MessageBox.Show("Successfully Registered");
                AutoID_Admin();
                dtAdmin = objAdmin.GetData();
                dgvshowdataadmin.DataSource = dtAdmin;
                dgvshowdataadmin.Refresh();

                 btnupdate.Enabled = false ;
                btnregister.Enabled = true ;
                btndelete.Enabled = false;
                AdminLogin AL = new AdminLogin();
                AL.Show();
                this.Hide();
            }
           
        }
        // Event handler for DataGridView cellmouse click
        private void dgvshowdataadmin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // show all input data in the data grid view
            DataGridViewRow row = this.dgvshowdataadmin.Rows[e.RowIndex];
            txtadminid.Text = row.Cells[0].Value.ToString();
            txtadminname.Text = row.Cells[1].Value.ToString();
            txtemail.Text = row.Cells[2].Value.ToString();
            txtphno.Text = row.Cells[3].Value.ToString();
            txtpassword.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();

            btnupdate.Enabled = true;
        }
        // Event handler for deleting the selected data
        private void btndelete_Click(object sender, EventArgs e)
        {
            // Delete selected admin record from the database
            objAdmin.DeleteAdmin(txtadminid.Text);
            MessageBox.Show("Successfully Deleted!");

            // Refresh DataGridView
            dtAdmin = objAdmin.GetData();
            dgvshowdataadmin.DataSource = dtAdmin;
            dgvshowdataadmin.Refresh();
            AutoID_Admin();

            btndelete.Enabled = true;
            
        }
        // Method to clear input data
        public void ClearData()
        {
            txtadminname.Clear();
            txtemail.Clear();
            txtpassword.Clear();
            txtphno.Clear();
            txtconfirmpassword.Clear();
            txtaddress.Clear();
            AutoID_Admin();
        }

        // Event handler for clearing the data
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        // Event handler for closing the form
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
