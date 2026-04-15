using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class CustomerForm : Form
    {
        private string username;
        private string deliveriesFile = "deliveries.txt";
        private string selectedOrderID;

        public CustomerForm(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username;
            btnFeedback.Visible = false;

            LoadDeliveries();
            CheckNotifications();

            dgvOrders.CellClick += dgvOrders_CellClick;
            btnFeedback.Click += BtnFeedback_Click;
            btnLogout.Click += btnLogout_Click;
        }

        void LoadDeliveries()
        {
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("Rider", "Rider");
            dgvOrders.Columns.Add("Location", "Location");
            dgvOrders.Columns.Add("Status", "Status");

            if (!File.Exists(deliveriesFile)) return;

            var lines = File.ReadAllLines(deliveriesFile);
            foreach (var line in lines)
            {
                var data = line.Split('|');
                if (data[1] == username)
                {
                    dgvOrders.Rows.Add(data[0], data[2], data[3], data[4]);
                }
            }
        }

        void CheckNotifications()
        {
            if (!File.Exists(deliveriesFile)) return;

            var lines = File.ReadAllLines(deliveriesFile);
            foreach (var line in lines)
            {
                var data = line.Split('|');
                if (data[1] == username)
                {
                    string status = data[4];
                    if (status == "Completed")
                        MessageBox.Show("Order " + data[0] + " has been delivered successfully!");
                    else if (status == "In Progress")
                        MessageBox.Show("Order " + data[0] + " is now in progress.");
                }
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string status = dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnFeedback.Visible = status == "Completed";
            selectedOrderID = dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void BtnFeedback_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedOrderID)) return;

            FeedbackForm feedbackForm = new FeedbackForm(username, selectedOrderID);
            feedbackForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDeliveries();
            btnFeedback.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
