using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class LoginForm : Form
    {
        string filePath = "users.txt"; 

        public LoginForm()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Rider");
            comboBox1.Items.Add("Customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please enter all fields!");
                return;
            }

            if (userType == "Admin")
            {
                if (username == "admin" && password == "admin123")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Admin credentials!");
                }
            }
            else
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No users registered yet!");
                    return;
                }

                var lines = File.ReadAllLines(filePath);
                bool found = false;

                foreach (var line in lines)
                {
                    var parts = line.Split('|'); 
                    if (parts.Length != 3) continue;

                    string fileUsername = parts[0].Trim();
                    string filePassword = parts[1].Trim();
                    string fileRole = parts[2].Trim();

                    if (fileUsername == username && filePassword == password && fileRole == userType)
                    {
                        found = true;

                        if (userType == "Rider")
                        {
                            var rider = new Rider()
                            {
                                Username = username,
                                Name = username   
                            };
                            RiderForm riderForm = new RiderForm(rider);
                            riderForm.Show();
                            this.Hide();
                        }

                        else if (userType == "Customer")
                        {
                            var customer = new Customer() { Username = username };
                            CustomerForm customerForm = new CustomerForm(customer.Username);
                            customerForm.Show();
                            this.Hide();
                        }


                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Invalid credentials for the selected user type!");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
