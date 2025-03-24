namespace BD_Oleg
{
    partial class Regist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NewLog = new TextBox();
            PassW = new TextBox();
            PassW2 = new TextBox();
            RegBut = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(70, 9);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 4;
            label4.Text = "Регистрация";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(70, 51);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 5;
            label1.Text = "Ваш будущий логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(115, 98);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 6;
            label2.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(90, 148);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 7;
            label3.Text = "Повтор пароля:";
            // 
            // NewLog
            // 
            NewLog.BackColor = SystemColors.ScrollBar;
            NewLog.Location = new Point(70, 75);
            NewLog.Name = "NewLog";
            NewLog.Size = new Size(166, 23);
            NewLog.TabIndex = 8;
            // 
            // PassW
            // 
            PassW.BackColor = SystemColors.ScrollBar;
            PassW.Location = new Point(70, 122);
            PassW.Name = "PassW";
            PassW.Size = new Size(166, 23);
            PassW.TabIndex = 9;
            // 
            // PassW2
            // 
            PassW2.BackColor = SystemColors.ScrollBar;
            PassW2.Location = new Point(70, 172);
            PassW2.Name = "PassW2";
            PassW2.Size = new Size(166, 23);
            PassW2.TabIndex = 10;
            // 
            // RegBut
            // 
            RegBut.BackColor = SystemColors.ActiveBorder;
            RegBut.Location = new Point(70, 226);
            RegBut.Name = "RegBut";
            RegBut.Size = new Size(174, 29);
            RegBut.TabIndex = 11;
            RegBut.Text = "Зарегистрироваться";
            RegBut.UseVisualStyleBackColor = false;
            RegBut.Click += RegBut_Click;
            // 
            // Regist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(320, 283);
            Controls.Add(RegBut);
            Controls.Add(PassW2);
            Controls.Add(PassW);
            Controls.Add(NewLog);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            MaximizeBox = false;
            Name = "Regist";
            Text = "Окно регистрации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NewLog;
        private TextBox PassW;
        private TextBox PassW2;
        private Button RegBut;
    }
}