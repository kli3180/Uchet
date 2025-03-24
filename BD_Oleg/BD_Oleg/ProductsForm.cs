using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace BD_Oleg
{
    public partial class ProductsForm : Form
    {
        private MySqlConnection conn;
        private MySqlDataAdapter? dataAdapter;
        private DataTable? dataTable;
        private string userRole;
        private Form1 loginForm;

        public ProductsForm(string role, Form1 loginForm)
        {
            InitializeComponent();
            userRole = role ?? throw new ArgumentNullException(nameof(role));
            this.loginForm = loginForm ?? throw new ArgumentNullException(nameof(loginForm));

            string connectionString = "server=95.183.12.18;port=3306;database=OlegDB;uid=oleg;";
            conn = new MySqlConnection(connectionString);
            tableComboBox.Items.AddRange(new string[] { "Продукты", "Категории", "Поставщики", "Транзакции", "Запасы" });
            tableComboBox.SelectedItem = "Продукты";
            if (userRole == "admin")
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                saveButton.Visible = true;
            }
            else
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                saveButton.Visible = false;
            }
            tableComboBox.SelectedIndexChanged += TableComboBox_SelectedIndexChanged;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;

            this.FormClosing += new FormClosingEventHandler(ProductsForm_FormClosing);
        }

        private void LoadData(string? tableName)
        {
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Пожалуйста, выберите таблицу.");
                return;
            }

            try
            {
                string query = tableName switch
                {
                    "Продукты" => "SELECT * FROM Products",
                    "Категории" => "SELECT * FROM Categories",
                    "Поставщики" => "SELECT * FROM Suppliers",
                    "Транзакции" => "SELECT * FROM Transactions",
                    "Запасы" => "SELECT * FROM Stock",
                    _ => throw new InvalidOperationException("Неизвестное имя таблицы.")
                };

                dataAdapter = new MySqlDataAdapter(query, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                UpdateCategoryComboBox(tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void UpdateCategoryComboBox(string tableName)
        {
            categoryComboBox.Items.Clear();

            switch (tableName)
            {
                case "Продукты":
                    categoryComboBox.Items.AddRange(new string[] { "ID_продукта", "Имя_продукта", "КатегорияID", "ПоставщикID", "Цена" });
                    break;
                case "Категории":
                    categoryComboBox.Items.AddRange(new string[] { "ID_категории", "Имя_категории" });
                    break;
                case "Поставщики":
                    categoryComboBox.Items.AddRange(new string[] { "ID_поставщика", "Имя_поставщика", "Имя_контакта", "Телефон" });
                    break;
                case "Транзакции":
                    categoryComboBox.Items.AddRange(new string[] { "ID_транзакции", "ID_продукта", "Тип_транзакции", "Количество", "Дата_транзакции" });
                    break;
                case "Запасы":
                    categoryComboBox.Items.AddRange(new string[] { "ID_запаса", "ID_продукта", "Количество", "Местоположение" });
                    break;
            }

            categoryComboBox.SelectedIndex = -1;
        }

        private void UpdateValueComboBox(string categoryName)
        {
            valueComboBox.Items.Clear();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Пожалуйста, выберите категорию.");
                return;
            }

            string tableName = tableComboBox.SelectedItem?.ToString() switch
            {
                "Продукты" => "Products",
                "Категории" => "Categories",
                "Поставщики" => "Suppliers",
                "Транзакции" => "Transactions",
                "Запасы" => "Stock",
                _ => throw new InvalidOperationException("Неизвестное имя таблицы.")
            };

            string query = $"SELECT DISTINCT {categoryName} FROM {tableName}";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            valueComboBox.Items.Add(reader[0].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении значений: {ex.Message}");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string? tableName = tableComboBox.SelectedItem?.ToString();
            string? categoryName = categoryComboBox.SelectedItem?.ToString();
            string? searchValue = valueComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Пожалуйста, выберите таблицу, категорию и значение.");
                return;
            }

            string sqlTableName = tableName switch
            {
                "Продукты" => "Products",
                "Категории" => "Categories",
                "Поставщики" => "Suppliers",
                "Транзакции" => "Transactions",
                "Запасы" => "Stock",
                _ => throw new InvalidOperationException("Неизвестное имя таблицы.")
            };

            try
            {
                string query = $"SELECT * FROM {sqlTableName} WHERE {categoryName} = @searchValue";
                dataAdapter = new MySqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@searchValue", searchValue);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dataAdapter == null || dataTable == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            try
            {
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataTable);
                MessageBox.Show("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm.ClearFields();
            this.Hide();
            loginForm.Show();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedCategory = categoryComboBox.SelectedItem?.ToString();
            valueComboBox.SelectedIndex = -1;
            UpdateValueComboBox(selectedCategory);
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedTable = tableComboBox.SelectedItem?.ToString();
            valueComboBox.SelectedIndex = -1;
            LoadData(selectedTable);
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApplication();
        }

        private void CloseApplication()
        {
            Application.Exit();
        }
    }
}
