using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class ManageDeliveriesForm : Form
    {
        string filePath = "deliveries.txt";

        Dictionary<string, int> locationIndex = new Dictionary<string, int>()
        {
            { "Dispatch Center - Gulshan", 0 },
            { "Bahria University", 1 },
            { "Dalmia", 2 },
            { "Millennium Mall", 3 },
            { "Gulshan-e-Iqbal", 4 },
            { "Clifton", 5 },
            { "Saddar", 6 },
            { "Baldia Town", 7 }
        };

        int[,] distances =
        {
            { 0, 6, 5, 7, 4, 10, 11, 18 },
            { 6, 0, 3, 4, 5, 9, 10, 17 },
            { 5, 3, 0, 2, 4, 8, 9, 16 },
            { 7, 4, 2, 0, 5, 7, 8, 15 },
            { 4, 5, 4, 5, 0, 9, 10, 17 },
            { 10, 9, 8, 7, 9, 0, 3, 12 },
            { 11, 10, 9, 8, 10, 3, 0, 11 },
            { 18, 17, 16, 15, 17, 12, 11, 0 }
        };

        public ManageDeliveriesForm()
        {
            InitializeComponent();

            cmbDeliveryStatus.Items.Add("Pending");
            cmbDeliveryStatus.Items.Add("In Progress");
            cmbDeliveryStatus.Items.Add("Completed");

            foreach (var loc in locationIndex.Keys)
            {
                if (loc != "Dispatch Center - Gulshan")
                    cmbAddress.Items.Add(loc);
            }

            LoadRiders();
            LoadDeliveries();
        }

        void LoadRiders()
        {
            cmbRiderName.Items.Clear();
            if (!File.Exists("users.txt")) return;

            var lines = File.ReadAllLines("users.txt");
            foreach (var line in lines)
            {
                var data = line.Split('|');
                if (data.Length == 3 && data[2] == "Rider")
                    cmbRiderName.Items.Add(data[0]);
            }
        }

        void LoadDeliveries()
        {
            dgvDeliveries.Rows.Clear();
            dgvDeliveries.Columns.Clear();

            dgvDeliveries.Columns.Add("OrderID", "Order ID");
            dgvDeliveries.Columns.Add("Customer", "Customer");
            dgvDeliveries.Columns.Add("Rider", "Rider");
            dgvDeliveries.Columns.Add("Location", "Location");
            dgvDeliveries.Columns.Add("Status", "Status");

            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var d = line.Split('|');
                dgvDeliveries.Rows.Add(d[0], d[1], d[2], d[3], d[4]);
            }
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "" || txtCustomerName.Text == "" ||
                cmbRiderName.SelectedIndex == -1 ||
                cmbAddress.SelectedIndex == -1 ||
                cmbDeliveryStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            string record =
                txtOrderID.Text + "|" +
                txtCustomerName.Text + "|" +
                cmbRiderName.SelectedItem + "|" +
                cmbAddress.SelectedItem + "|" +
                cmbDeliveryStatus.SelectedItem;

            File.AppendAllText(filePath, record + Environment.NewLine);
            LoadDeliveries();
            ClearFields();
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.SelectedRows.Count == 0) return;

            string id = dgvDeliveries.SelectedRows[0].Cells[0].Value.ToString();
            var lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + "|"))
                {
                    lines[i] =
                        txtOrderID.Text + "|" +
                        txtCustomerName.Text + "|" +
                        cmbRiderName.SelectedItem + "|" +
                        cmbAddress.SelectedItem + "|" +
                        cmbDeliveryStatus.SelectedItem;
                }
            }

            File.WriteAllLines(filePath, lines);
            LoadDeliveries();
            ClearFields();
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.SelectedRows.Count == 0) return;

            string id = dgvDeliveries.SelectedRows[0].Cells[0].Value.ToString();
            var newLines = File.ReadAllLines(filePath)
                               .Where(l => !l.StartsWith(id + "|"))
                               .ToArray();

            File.WriteAllLines(filePath, newLines);
            LoadDeliveries();
            ClearFields();
        }

        private void btnClearDelivery_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtOrderID.Clear();
            txtCustomerName.Clear();
            cmbRiderName.SelectedIndex = -1;
            cmbAddress.SelectedIndex = -1;
            cmbDeliveryStatus.SelectedIndex = -1;
        }

        private void dgvDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtOrderID.Text = dgvDeliveries.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustomerName.Text = dgvDeliveries.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbRiderName.SelectedItem = dgvDeliveries.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbAddress.SelectedItem = dgvDeliveries.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDeliveryStatus.SelectedItem = dgvDeliveries.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnCalculateRoute_Click(object sender, EventArgs e)
        {
            var activeDeliveries = dgvDeliveries.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[3].Value != null &&
                            r.Cells[4].Value.ToString() != "Completed")
                .ToList();

            int n = activeDeliveries.Count;
            if (n == 0)
            {
                MessageBox.Show("No pending or in-progress deliveries to calculate route for");
                return;
            }

            int[,] tspDistances = new int[n + 1, n + 1];

            List<string> tspLocations = new List<string> { "Dispatch Center - Gulshan" };
            foreach (var r in activeDeliveries)
                tspLocations.Add(r.Cells[3].Value.ToString());

            for (int i = 0; i < tspLocations.Count; i++)
            {
                for (int j = 0; j < tspLocations.Count; j++)
                {
                    int idx1 = locationIndex[tspLocations[i]];
                    int idx2 = locationIndex[tspLocations[j]];
                    tspDistances[i, j] = distances[idx1, idx2];
                }
            }

            var result = TSP.SolveBruteForce(tspDistances);

            string normalRoute = string.Join(" -> ", tspLocations);
            string optimizedRoute = string.Join(" -> ", result.ShortestRoute.Select(x => tspLocations[x]));

            MessageBox.Show("Normal Route: " + normalRoute +
                            "\nOptimized Route: " + optimizedRoute +
                            "\nOptimized Distance: " + result.MinDistance);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }
    }
}
