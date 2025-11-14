namespace JewleryShopExampleForm
{
    partial class LoginScreen
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
            TXB_Login = new TextBox();
            TXB_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTN_Login = new Button();
            SuspendLayout();
            // 
            // TXB_Login
            // 
            TXB_Login.Location = new Point(80, 9);
            TXB_Login.Name = "TXB_Login";
            TXB_Login.Size = new Size(100, 23);
            TXB_Login.TabIndex = 0;
            // 
            // TXB_Password
            // 
            TXB_Password.Location = new Point(80, 38);
            TXB_Password.Name = "TXB_Password";
            TXB_Password.Size = new Size(100, 23);
            TXB_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // BTN_Login
            // 
            BTN_Login.Location = new Point(14, 67);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.Size = new Size(75, 23);
            BTN_Login.TabIndex = 4;
            BTN_Login.Text = "Login";
            BTN_Login.UseVisualStyleBackColor = true;
            BTN_Login.Click += BTN_Login_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(193, 105);
            Controls.Add(BTN_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXB_Password);
            Controls.Add(TXB_Login);
            Name = "LoginScreen";
            Text = "Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXB_Login;
        private TextBox TXB_Password;
        private Label label1;
        private Label label2;
        private Button BTN_Login;
    }
}