using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class ViewRatesForm : Form
    {
        string filePath = "rates.txt";

        public ViewRatesForm()
        {
            InitializeComponent();

            cmbDeliveryType.Items.Add("Normal");
            cmbDeliveryType.Items.Add("Express");
            cmbDeliveryType.Items.Add("Priority");

            LoadRates();
        }

        void LoadRates()
        {
            dgvRates.Rows.Clear();
            dgvRates.Columns.Clear();

            dgvRates.Columns.Add("DeliveryType", "Delivery Type");
            dgvRates.Columns.Add("Weight", "Weight (kg)");
            dgvRates.Columns.Add("Distance", "Distance (km)");
            dgvRates.Columns.Add("Rate", "Rate (PKR)");

            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var data = line.Split('|');
                dgvRates.Rows.Add(data[0], data[1], data[2], data[3]);
            }
        }

        private void btnCalculateRate_Click(object sender, EventArgs e)
        {
            if (cmbDeliveryType.SelectedIndex == -1 || txtWeight.Text == "" || txtDistance.Text == "")
            {
                MessageBox.Show("Fill all fields to calculate rate");
                return;
            }

            double weight = double.Parse(txtWeight.Text);
            double distance = double.Parse(txtDistance.Text);
            double multiplier = 1;

            if (cmbDeliveryType.SelectedItem.ToString() == "Express") multiplier = 1.5;
            else if (cmbDeliveryType.SelectedItem.ToString() == "Priority") multiplier = 2;

            double rate = 50 * weight * distance * multiplier; 
            txtRate.Text = rate.ToString("0.00");
        }

        private void btnSaveRate_Click(object sender, EventArgs e)
        {
            if (cmbDeliveryType.SelectedIndex == -1 || txtWeight.Text == "" || txtDistance.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show("Calculate rate first");
                return;
            }

            string record = $"{cmbDeliveryType.SelectedItem}|{txtWeight.Text}|{txtDistance.Text}|{txtRate.Text}";
            File.AppendAllText(filePath, record + Environment.NewLine);
            LoadRates();
            ClearFields();
        }

        private void btnClearRate_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            cmbDeliveryType.SelectedIndex = -1;
            txtWeight.Clear();
            txtDistance.Clear();
            txtRate.Clear();
        }

        private void dgvRates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cmbDeliveryType.SelectedItem = dgvRates.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtWeight.Text = dgvRates.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDistance.Text = dgvRates.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRate.Text = dgvRates.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }
    }
}
