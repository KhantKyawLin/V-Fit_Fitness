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
    public partial class ActivitiesInfo : Form
    {
        // Initialize the ActivityTableAdapter and a DataTable
        FitnessTrackerDataSetTableAdapters.ActivityTableAdapter objActivity = new FitnessTrackerDataSetTableAdapters.ActivityTableAdapter();
        DataTable dt = new DataTable();
        public ActivitiesInfo()
        {
            // Retrieve activity data from the database
            InitializeComponent();
            dt = objActivity.GetData();
            dgvactivitiesinfo.DataSource = dt;
            dgvactivitiesinfo.Refresh();
        }
        // Event handler for the "Close" button click
        private void btnclose_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the Club Member Home form
            this.Hide();
            Clubmember_Home CH = new Clubmember_Home();
            CH.Show();
        }
    }
}
