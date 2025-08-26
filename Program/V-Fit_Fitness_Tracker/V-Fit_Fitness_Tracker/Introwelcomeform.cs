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
    public partial class Introwelcomeform : Form
    {
        public Introwelcomeform()
        {
            InitializeComponent();
        }
        // Event handler for admin login button click
        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create and show the AdminLogin form
            AdminLogin AL = new AdminLogin();
            AL.Show();
        }
        // Event handler for member login button click
        private void btnmemberlogin_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create and show the Clubmemberlogin form
            Clubmemberlogin CL = new Clubmemberlogin();
            CL.Show();
        }
    }
}
