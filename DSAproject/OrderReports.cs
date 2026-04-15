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
    public partial class OrderReportsForm : Form
    {
        string filePath = "deliveries.txt";

        public OrderReportsForm()
        {
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            dgvReports.Rows.Clear();
            dgvReports.Columns.Clear();

            dgvReports.Columns.Add("TotalDeliveries", "Total Deliveries");
            dgvReports.Columns.Add("Completed", "Completed");
            dgvReports.Columns.Add("Pending", "Pending");
            dgvReports.Columns.Add("InProgress", "In Progress");
            dgvReports.Columns.Add("CompletionPercent", "Completion %");

            int total = 0, completed = 0, pending = 0, inProgress = 0;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split('|');
                    if (data.Length == 5)
                    {
                        total++;
                        string status = data[4];
                        if (status == "Completed") completed++;
                        else if (status == "Pending") pending++;
                        else if (status == "In Progress") inProgress++;
                    }
                }
            }

            double percent = (total == 0) ? 0 : ((double)completed / total) * 100;
            dgvReports.Rows.Add(total, completed, pending, inProgress, Math.Round(percent, 2) + "%");
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            string reportFile = "OrderReport.txt";
            using (StreamWriter sw = new StreamWriter(reportFile))
            {
                sw.WriteLine("Order Reports Summary\n");
                sw.WriteLine("Total Deliveries: " + dgvReports.Rows[0].Cells[0].Value);
                sw.WriteLine("Completed: " + dgvReports.Rows[0].Cells[1].Value);
                sw.WriteLine("Pending: " + dgvReports.Rows[0].Cells[2].Value);
                sw.WriteLine("In Progress: " + dgvReports.Rows[0].Cells[3].Value);
                sw.WriteLine("Completion %: " + dgvReports.Rows[0].Cells[4].Value);
            }
            MessageBox.Show("Report exported as " + reportFile);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
