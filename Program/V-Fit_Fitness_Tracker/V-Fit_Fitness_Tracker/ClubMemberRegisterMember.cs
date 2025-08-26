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
    public partial class ClubMemberRegisterMember : Form
    {
        FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter objClubmember = new FitnessTrackerDataSetTableAdapters.ClubmemberTableAdapter();
        DataTable dtClubmember = new DataTable();

        public ClubMemberRegisterMember()
        {
            InitializeComponent();
            btnregister.Enabled = false;
            dgvshowdataclubmember.Hide();
        }

        private void ClubMemberRegisterMember_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mid = Clubmemberlogin.MemberID;
            txtmembername.Text = Clubmemberlogin.MemberName;
            dt = objClubmember.CheckData(mid);
            if (dt.Rows.Count > 0)
                for (int k = 0; k < dtClubmember.Rows.Count; k++)
                {
                    // Load activity names into the combo box
                    cboactivities.Items.Add(dtClubmember.Rows[k][1].ToString());
                }
            {
                txtmemberid.Text = Clubmemberlogin.MemberID;
                txtmembername.Text = dt.Rows[0][1].ToString();
                txtemail.Text = dt.Rows[0][2].ToString();
                txtweight.Text = dt.Rows[0][4].ToString();
                txtphno.Text = dt.Rows[0][5].ToString(); ;
                txtpassword.Text = dt.Rows[0][8].ToString();
                txtaddress.Text = dt.Rows[0][9].ToString();

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

        }

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Delete selected clubmember record from the database
            objClubmember.DeleteClubmember(txtmemberid.Text);
            MessageBox.Show("Successfully Deleted!");

            dtClubmember = objClubmember.GetData();
            dgvshowdataclubmember.DataSource = dtClubmember;
            dgvshowdataclubmember.Refresh();


            btndelete.Enabled = true;
            Clubmemberlogin CL = new Clubmemberlogin();
            CL.Show();
            this.Hide();
        }

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
            else if (rdofemale .Text  == "")
            {
                MessageBox.Show("Please select your gender.");
            }
            else if (rdomale.Text == "")
            {
                MessageBox.Show("Please select your gender.");
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

                dtClubmember = objClubmember.GetData();
                dgvshowdataclubmember.DataSource = dtClubmember;
                dgvshowdataclubmember.Refresh();


                btnupdate.Enabled = true;
                btnregister.Enabled = false;
                btndelete.Enabled = false;
                Clubmember_Home CH = new Clubmember_Home();
                CH.Show();
                this.Hide();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
            this.Hide();
            Clubmember_Home CH = new Clubmember_Home();
            CH.Show();
        }
    }
}