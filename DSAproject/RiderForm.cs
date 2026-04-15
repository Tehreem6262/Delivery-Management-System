using System;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class RiderForm : Form
    {
        private Rider currentRider;

        public RiderForm(Rider rider)
        {
            InitializeComponent();

            if (rider == null)
            {
                MessageBox.Show("Rider data not found!");
                this.Close();
                return;
            }

            currentRider = rider;
        }

        private void RiderForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + currentRider.Username;
        }

        private void btnViewAssignedDeliveries_Click(object sender, EventArgs e)
        {
            AssignedDeliveriesForm adf =
                new AssignedDeliveriesForm(currentRider);
            adf.Show();
            this.Hide();
        }

        private void btnRouteOptimization_Click(object sender, EventArgs e)
        {
            RouteOptimization rof = new RouteOptimization(currentRider);
            rof.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}

