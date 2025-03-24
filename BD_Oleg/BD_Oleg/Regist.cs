using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BD_Oleg
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
            PassW.PasswordChar = '*';
            PassW2.PasswordChar = '*';
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewLog.Text))
            {
                MessageBox.Show("Ну емае, заполни поле будущего логина.");
                return;
            }

            if (string.IsNullOrEmpty(PassW.Text) || string.IsNullOrEmpty(PassW2.Text))
            {
                MessageBox.Show("Одно из полей для ввода пароля пустое.");
                return;
            }
            if (PassW.Text != PassW2.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            string connectionString = "server=95.183.12.18;port=3306;database=OlegDB;uid=oleg;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand cmdCheckUser = new MySqlCommand(checkUserQuery, conn);
                    cmdCheckUser.Parameters.AddWithValue("@username", NewLog.Text);

                    int userCount = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Логин уже занят.");
                        return;
                    }

                    string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@username, SHA2(@password, 256), 'user')";
                    MySqlCommand cmdInsertUser = new MySqlCommand(insertUserQuery, conn);
                    cmdInsertUser.Parameters.AddWithValue("@username", NewLog.Text);
                    cmdInsertUser.Parameters.AddWithValue("@password", PassW.Text);

                    cmdInsertUser.ExecuteNonQuery();
                    MessageBox.Show("Регистрация успешна.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
