namespace BD_Oleg
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button saveButton;
        private Button logoutButton;
        private ComboBox tableComboBox;
        private ComboBox categoryComboBox;
        private ComboBox valueComboBox;
        private Button searchButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            saveButton = new Button();
            logoutButton = new Button();
            tableComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            valueComboBox = new ComboBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(615, 300);
            dataGridView1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 348);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(528, 348);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(100, 23);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Выйти";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // tableComboBox
            // 
            tableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new Point(13, 13);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new Size(150, 23);
            tableComboBox.TabIndex = 3;
            tableComboBox.SelectedIndexChanged += TableComboBox_SelectedIndexChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(170, 13);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(150, 23);
            categoryComboBox.TabIndex = 4;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // valueComboBox
            // 
            valueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            valueComboBox.FormattingEnabled = true;
            valueComboBox.Location = new Point(327, 13);
            valueComboBox.Name = "valueComboBox";
            valueComboBox.Size = new Size(150, 23);
            valueComboBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(528, 13);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // ProductsForm
            // 
            ClientSize = new Size(640, 377);
            Controls.Add(searchButton);
            Controls.Add(valueComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(tableComboBox);
            Controls.Add(logoutButton);
            Controls.Add(saveButton);
            Controls.Add(dataGridView1);
            Name = "ProductsForm";
            Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}
