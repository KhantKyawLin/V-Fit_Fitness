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
    public partial class ReportForm : Form
    {
        // Initialize a ProgressInfoTableAdapter and a DataTable for progress information
        FitnessTrackerDataSetTableAdapters.ProgressInfoTableAdapter objprogressinfo = new FitnessTrackerDataSetTableAdapters.ProgressInfoTableAdapter();
        DataTable dtprogressinfo = new DataTable();
        public ReportForm()
        {
            InitializeComponent();

            // Call the method to set progress ID combo box
            SetProgressID();
        }
        // Method to populate the combo box with progress IDs
        private void SetProgressID()
        {
            // Retrieve progress information
            dtprogressinfo = objprogressinfo.GetData();
            // Add default item to the combo box
            cbofindid.Items.Add("Please Choose Progress ID");

            // Populate the combo box with progress IDs
            for (int k = 0; k < dtprogressinfo.Rows.Count; k++)
            {
                cbofindid.Items.Add(dtprogressinfo.Rows[k][0].ToString());
            }
            // Set the default selected item to the first one
            cbofindid.SelectedIndex = 0;
        }

        // Event handler for the "Find" button click
        private void btnfind_Click(object sender, EventArgs e)
        {
            // Parse the selected start and end dates
    
            DateTime StartDate = DateTime.Parse(dtpstartdate.Text);
            DateTime EndDate = DateTime.Parse(dtpenddate.Text);
            // Check if searching by member ID is selected
            if (rdofindbyid.Checked)
            {
                // Retrieve progress information by member ID
                dtprogressinfo = objprogressinfo.Findby_ID(cbofindid.SelectedItem.ToString());
                dgvreport.DataSource = dtprogressinfo;
                dgvreport.Refresh();
            }
            
            // Check if searching by date range is selected
            else if (rdofindbydate.Checked)
            { // Retrieve progress information by date range
                dtprogressinfo = objprogressinfo.Findby_Date(StartDate.ToString (), EndDate.ToString ());
                // Set the retrieved data as the data source for the DataGridView
                dgvreport.DataSource = dtprogressinfo;
                // Refresh the DataGridView to display the data
                dgvreport.Refresh();
            }
        }

        // Event handler for the "Show All" button click
        private void btnshowall_Click(object sender, EventArgs e)
        {
            // Retrieve all progress information
            dtprogressinfo = objprogressinfo.Showallinfo();

            dgvreport.DataSource = dtprogressinfo;

            dgvreport.Refresh();
        }
        // Event handler for the "Close" button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}
