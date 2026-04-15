using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class AssignedDeliveriesForm : Form
    {
        private Rider currentRider;
        private string deliveriesFile = "deliveries.txt";

        public AssignedDeliveriesForm(Rider rider)
        {
            InitializeComponent();

            if (rider == null)
            {
                MessageBox.Show("Rider object is null.");
                this.Close();
                return;
            }

            currentRider = rider;

            if (lblRiderName != null)
                lblRiderName.Text = "Rider: " + (currentRider.Name ?? "Unknown");

            LoadAssignedDeliveries();
        }


        private void LoadAssignedDeliveries()
        {
            if (dgvAssignedDeliveries == null)
            {
                MessageBox.Show("DataGridView not found. Check its name in Designer.");
                return;
            }

            if (currentRider == null)
            {
                MessageBox.Show("Rider is null. Please login again.");
                return;
            }

            if (string.IsNullOrEmpty(currentRider.Name))
            {
                MessageBox.Show("Rider name is missing.");
                return;
            }

            dgvAssignedDeliveries.Rows.Clear();
            dgvAssignedDeliveries.Columns.Clear();

            dgvAssignedDeliveries.Columns.Add("OrderID", "Order ID");
            dgvAssignedDeliveries.Columns.Add("CustomerName", "Customer Name");
            dgvAssignedDeliveries.Columns.Add("Location", "Location");
            dgvAssignedDeliveries.Columns.Add("Status", "Status");

            if (!File.Exists(deliveriesFile))
            {
                MessageBox.Show("Deliveries file not found!");
                return;
            }

            var lines = File.ReadAllLines(deliveriesFile);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var data = line.Split('|');
                if (data.Length < 5) continue;

                if (data[2].Trim()
                    .Equals(currentRider.Name.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    dgvAssignedDeliveries.Rows.Add(
                        data[0].Trim(),
                        data[1].Trim(),
                        data[3].Trim(),
                        data[4].Trim()
                    );
                }
            }
        }

        private void dgvAssignedDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvAssignedDeliveries.Rows[e.RowIndex].Cells[3].Value != null)
                cmbStatus.SelectedItem =
                    dgvAssignedDeliveries.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvAssignedDeliveries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a delivery.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string newStatus = cmbStatus.SelectedItem.ToString();
            string selectedOrderID =
                dgvAssignedDeliveries.SelectedRows[0].Cells[0].Value.ToString();

            var lines = File.ReadAllLines(deliveriesFile).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var data = lines[i].Split('|');
                if (data.Length < 5) continue;

                if (data[0].Trim() == selectedOrderID &&
                    data[2].Trim() == currentRider.Name.Trim())
                {
                    data[4] = newStatus;
                    lines[i] = string.Join("|", data);
                    break;
                }
            }

            File.WriteAllLines(deliveriesFile, lines);
            MessageBox.Show("Status updated!");
            LoadAssignedDeliveries();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAssignedDeliveries();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            RiderForm rf = new RiderForm(currentRider);
            rf.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RiderForm rf = new RiderForm(currentRider);
            rf.Show();
           this.Hide();
        }
    }
}
