namespace View
{
    partial class MainFrame
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
            EraseButton = new Button();
            EnterButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            LoginMainLabel = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EraseButton
            // 
            EraseButton.Font = new Font("Impact", 20F);
            EraseButton.Location = new Point(508, 378);
            EraseButton.Name = "EraseButton";
            EraseButton.Size = new Size(140, 70);
            EraseButton.TabIndex = 0;
            EraseButton.Text = "Очистить";
            EraseButton.UseVisualStyleBackColor = true;
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Impact", 20F);
            EnterButton.Location = new Point(172, 378);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(140, 70);
            EnterButton.TabIndex = 1;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(287, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDark;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(287, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(LoginMainLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 100);
            panel1.TabIndex = 4;
            // 
            // LoginMainLabel
            // 
            LoginMainLabel.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginMainLabel.Location = new Point(0, 0);
            LoginMainLabel.Name = "LoginMainLabel";
            LoginMainLabel.Size = new Size(784, 100);
            LoginMainLabel.TabIndex = 0;
            LoginMainLabel.Text = "Автосервис";
            LoginMainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            LoginLabel.Font = new Font("Impact", 32F);
            LoginLabel.Location = new Point(0, 100);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(784, 56);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Логин";
            LoginLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Font = new Font("Impact", 32F);
            PasswordLabel.Location = new Point(0, 198);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(784, 53);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Пароль";
            PasswordLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(EnterButton);
            Controls.Add(EraseButton);
            Name = "MainFrame";
            Text = "Login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EraseButton;
        private Button EnterButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label LoginMainLabel;
        private Label LoginLabel;
        private Label PasswordLabel;
    }
}
