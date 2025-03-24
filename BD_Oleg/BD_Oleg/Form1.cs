using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_Oleg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PasswordUser.PasswordChar = '*';
        }

        public void ClearFields()
        {
            NameUser.Text = string.Empty;
            PasswordUser.Text = string.Empty;
        }

        private void RegLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regist formRegist = new Regist();
            formRegist.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string videoPath = AppDomain.CurrentDomain.BaseDirectory + "BD_Oleg.mp4";
            Process.Start(new ProcessStartInfo
            {
                FileName = videoPath,
                UseShellExecute = true
            });
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameUser.Text))
            {
                MessageBox.Show("�� ����, ������� ���� ������.");
                return;
            }

            if (string.IsNullOrEmpty(PasswordUser.Text))
            {
                MessageBox.Show("�� ����, ������� ���� ������.");
                return;
            }


            string connectionString = "server=95.183.12.18;port=3306;database=OlegDB;uid=oleg;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username = @username AND password = SHA2(@password, 256)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", NameUser.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordUser.Text);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"����� ����������, {role}!");

                        // �������� ����� � ���������� � �������� ���� ������������ � ���������� ����� �����������
                        ProductsForm productsForm = new ProductsForm(role, this);
                        productsForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("�������� ����� ��� ������.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������: {ex.Message}");
                }
            }
        }
    }
}
