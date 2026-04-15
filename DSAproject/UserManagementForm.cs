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
    public partial class UserManagementForm : Form
        {
            string filePath = "users.txt";

            public UserManagementForm()
            {
                InitializeComponent();
                LoadUsers();
            }

            void LoadUsers()
            {
                dgvUsers.Rows.Clear();
                dgvUsers.Columns.Clear();

                dgvUsers.Columns.Add("Username", "Username");
                dgvUsers.Columns.Add("Password", "Password");
                dgvUsers.Columns.Add("Role", "Role");

                if (!File.Exists(filePath))
                    return;

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split('|');
                    dgvUsers.Rows.Add(data[0], data[1], data[2]);
                }
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill all fields");
                    return;
                }

                string record = txtUsername.Text + "|" + txtPassword.Text + "|" + cmbRole.SelectedItem.ToString();
                File.AppendAllText(filePath, record + Environment.NewLine);
                LoadUsers();
                ClearFields();
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a user");
                    return;
                }

                string selectedUsername = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith(selectedUsername + "|"))
                    {
                        lines[i] = txtUsername.Text + "|" + txtPassword.Text + "|" + cmbRole.SelectedItem.ToString();
                    }
                }

                File.WriteAllLines(filePath, lines);
                LoadUsers();
                ClearFields();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Select a user");
                    return;
                }

                string selectedUsername = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                var newLines = File.ReadAllLines(filePath)
                                   .Where(line => !line.StartsWith(selectedUsername + "|"))
                                   .ToArray();

                File.WriteAllLines(filePath, newLines);
                LoadUsers();
                ClearFields();
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearFields();
            }

            void ClearFields()
            {
                txtUsername.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
            }

            private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbRole.SelectedItem = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm aForm = new AdminForm();
            aForm.Show();
            this.Hide();
        }
    }
    }



