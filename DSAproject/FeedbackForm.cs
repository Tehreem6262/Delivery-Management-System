using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class FeedbackForm : Form
    {
        private string username;
        private string orderID;
        private string feedbackFile = "feedback.txt";

        public FeedbackForm(string username, string orderID)
        {
            InitializeComponent();
            this.username = username;
            this.orderID = orderID;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            cmbRating.ForeColor = Color.White;
            cmbRating.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblOrderID.Text = "Order ID: " + orderID;

            cmbRating.Items.Clear();
            for (int i = 1; i <= 5; i++)
                cmbRating.Items.Add(i.ToString());

            txtComments.Multiline = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRating.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please provide a rating and comments.");
                return;
            }

            string rating = cmbRating.SelectedItem.ToString();
            string comments = txtComments.Text.Replace("|", "-"); 
            string record = $"{username}|{orderID}|{rating}|{comments}";

            File.AppendAllText(feedbackFile, record + Environment.NewLine);

            MessageBox.Show("Thank you for your feedback!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();

        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
