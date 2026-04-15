using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class RiderSalaryManagementForm : Form
    {
        string deliveriesFile = "deliveries.txt";
        string usersFile = "users.txt";
        int salaryPerDelivery = 100;

        public RiderSalaryManagementForm()
        {
            InitializeComponent();

            cmbMonth.Items.AddRange(new string[]
            {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            });

            LoadRiders();
            LoadSalaryData();
        }

        void LoadRiders()
        {
            cmbRiderName.Items.Clear();
            if (!File.Exists(usersFile)) return;

            string[] users = File.ReadAllLines(usersFile);
            foreach (var user in users)
            {
                var parts = user.Split('|');
                if (parts.Length == 3 && parts[2] == "Rider")
                    cmbRiderName.Items.Add(parts[0]);
            }
        }

        void LoadSalaryData()
        {
            dgvSalary.Rows.Clear();
            dgvSalary.Columns.Clear();

            dgvSalary.Columns.Add("RiderName", "Rider Name");
            dgvSalary.Columns.Add("Month", "Month");
            dgvSalary.Columns.Add("CompletedDeliveries", "Completed Deliveries");
            dgvSalary.Columns.Add("Salary", "Salary");

            if (!File.Exists(deliveriesFile)) return;

            var lines = File.ReadAllLines(deliveriesFile);

            var completedDeliveries = lines
                .Select(line => line.Split('|'))
                .Where(d => d[4] == "Completed")
                .ToList();

            var grouped = completedDeliveries
                .GroupBy(d => new { Rider = d[2], Month = DateTime.Now.ToString("MMMM") }) // For demo, month is current
                .ToList();

            foreach (var g in grouped)
            {
                int count = g.Count();
                int salary = count * salaryPerDelivery;
                dgvSalary.Rows.Add(g.Key.Rider, g.Key.Month, count, salary);
            }
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            if (cmbRiderName.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Select Rider and Month");
                return;
            }

            string selectedRider = cmbRiderName.SelectedItem.ToString();
            string selectedMonth = cmbMonth.SelectedItem.ToString();

            if (!File.Exists(deliveriesFile)) return;

            var lines = File.ReadAllLines(deliveriesFile);

            var completedDeliveries = lines
                .Select(line => line.Split('|'))
                .Where(d => d[4] == "Completed" && d[2] == selectedRider)
                .ToList();

            int count = completedDeliveries.Count();
            int salary = count * salaryPerDelivery;

            dgvSalary.Rows.Clear();
            dgvSalary.Rows.Add(selectedRider, selectedMonth, count, salary);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadSalaryData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }
    }
}
