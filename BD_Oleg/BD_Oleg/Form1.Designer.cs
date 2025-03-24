namespace BD_Oleg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NameUser = new TextBox();
            PasswordUser = new TextBox();
            LogButton = new Button();
            RegLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(49, 152);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 319);
            label2.Name = "label2";
            label2.Size = new Size(88, 48);
            label2.TabIndex = 1;
            label2.Text = "Федоров О.Д. \r\nИСПП 22 1/9\r\nУчет товаров\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(338, 9);
            label3.Name = "label3";
            label3.Size = new Size(450, 30);
            label3.TabIndex = 2;
            label3.Text = "Для входа в систему, авторизуйтесь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(510, 65);
            label4.Name = "label4";
            label4.Size = new Size(91, 30);
            label4.TabIndex = 3;
            label4.Text = "Логин:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(510, 152);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 4;
            label5.Text = "Пароль:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(360, 306);
            label6.Name = "label6";
            label6.Size = new Size(241, 30);
            label6.TabIndex = 5;
            label6.Text = "Еще нет аккаунта?";
            // 
            // NameUser
            // 
            NameUser.BackColor = Color.DarkGray;
            NameUser.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameUser.Location = new Point(456, 113);
            NameUser.Name = "NameUser";
            NameUser.Size = new Size(200, 25);
            NameUser.TabIndex = 6;
            // 
            // PasswordUser
            // 
            PasswordUser.BackColor = Color.DarkGray;
            PasswordUser.Font = new Font("Times New Roman", 11.25F);
            PasswordUser.Location = new Point(456, 200);
            PasswordUser.Name = "PasswordUser";
            PasswordUser.Size = new Size(200, 25);
            PasswordUser.TabIndex = 7;
            // 
            // LogButton
            // 
            LogButton.BackColor = Color.Transparent;
            LogButton.Font = new Font("Times New Roman", 11.25F);
            LogButton.Location = new Point(484, 242);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(149, 35);
            LogButton.TabIndex = 8;
            LogButton.Text = "Войти";
            LogButton.UseVisualStyleBackColor = false;
            LogButton.Click += LogButton_Click;
            // 
            // RegLink
            // 
            RegLink.ActiveLinkColor = Color.LightGray;
            RegLink.AutoSize = true;
            RegLink.BackColor = Color.Transparent;
            RegLink.Font = new Font("Century Gothic", 18F);
            RegLink.LinkColor = Color.Blue;
            RegLink.Location = new Point(607, 306);
            RegLink.Name = "RegLink";
            RegLink.Size = new Size(166, 30);
            RegLink.TabIndex = 9;
            RegLink.TabStop = true;
            RegLink.Text = "Регистрация";
            RegLink.VisitedLinkColor = Color.Blue;
            RegLink.LinkClicked += RegLink_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 378);
            Controls.Add(RegLink);
            Controls.Add(LogButton);
            Controls.Add(PasswordUser);
            Controls.Add(NameUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Окно авторизации";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NameUser;
        private TextBox PasswordUser;
        private Button LogButton;
        private LinkLabel RegLink;
    }
}
