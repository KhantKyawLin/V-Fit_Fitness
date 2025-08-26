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
    public partial class Activities : Form
    {
        // Adapter for interacting with the Activity table in the database
        FitnessTrackerDataSetTableAdapters.ActivityTableAdapter objActivity = new FitnessTrackerDataSetTableAdapters.ActivityTableAdapter();
        DataTable dt = new DataTable();

        public Activities()
        {
            InitializeComponent();
            AutoID_Activity();// Automatically generate Activity ID
            dt = objActivity.GetData();
            dgvactivitydata.DataSource = dt;
            dgvactivitydata.Refresh();
        }

        // Method to automatically generate Activity ID
        public void AutoID_Activity()
        {
            DataTable dt = new DataTable();
            dt = objActivity.GetData();

            if (dt.Rows.Count == 0)
            {
                lblactivityid.Text = "A_001";// If no activities exist, set ID to A_001
            }
            else
            {
                int size = dt.Rows.Count - 1;
                string oldId = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldId.Substring(2, 3));

                if (newID >= 1 && newID < 10)
                {
                    lblactivityid.Text = "A_00" + (newID + 1);// Generate next ID based on count of existing activities
                }
                else if (newID > 9 && newID < 100)
                {
                    lblactivityid.Text = "A_0" + (newID + 1);
                }
                else if (newID > 99 && newID < 1000)
                {
                    lblactivityid.Text = "A_" + (newID + 1);
                }
            }
        }

        // Event handler for save button click
        private void btnsave_Click(object sender, EventArgs e)
        {
           
            if (txtactivityname.Text == "")
            {
                MessageBox.Show("Please Input Activity Name");
                txtactivityname.Focus(); // Ensure Activity Name is entered
            }
            else if (txtmetric1.Text == "")
            {
                MessageBox.Show("Please Input Metric 1 data.");
                txtmetric1.Focus();
            }
            else if (txtmetric2.Text == "")
            {
                MessageBox.Show("Please Input Metric 2 data.");
                txtmetric1.Focus();
            }
            else if (txtmetric3.Text == "")
            {
                MessageBox.Show("Please Input Metric 3 data.");
                txtmetric3.Focus();
            }
            else if (txtmet.Text == "")
            {
                MessageBox.Show("Please Input MET Value.");
                txtmet.Focus();
            }
            else if (txtdescription.Text  == "")
            {
                MessageBox.Show("Please Input Activity Description.");
                txtdescription.Focus();
            }
            else
            {
                // Insert activity into the database
                objActivity.InsertActivity(lblactivityid.Text, txtactivityname.Text, txtmetric1.Text, txtmetric2.Text, txtmetric3.Text, txtmet.Text, txtdescription.Text);
                MessageBox.Show("Successfully saved");
                AutoID_Activity();// Generate next Activity ID
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for close button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close(); Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }

        // Event handler for admin home button click
        private void btnadminhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home AH = new Admin_Home();
            AH.Show();// Show Admin Home form

        }
    }
}
