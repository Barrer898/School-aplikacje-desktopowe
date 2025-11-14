namespace JewleryShopExampleForm
{
    partial class HomeMenu
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
            label1 = new Label();
            LBL_CurrentUser = new Label();
            BTN_BrowseJewelry = new Button();
            BTN_Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome back : ";
            // 
            // LBL_CurrentUser
            // 
            LBL_CurrentUser.AutoSize = true;
            LBL_CurrentUser.Location = new Point(111, 9);
            LBL_CurrentUser.Name = "LBL_CurrentUser";
            LBL_CurrentUser.Size = new Size(57, 15);
            LBL_CurrentUser.TabIndex = 1;
            LBL_CurrentUser.Text = "NO_USER";
            // 
            // BTN_BrowseJewelry
            // 
            BTN_BrowseJewelry.Enabled = false;
            BTN_BrowseJewelry.Location = new Point(11, 34);
            BTN_BrowseJewelry.Name = "BTN_BrowseJewelry";
            BTN_BrowseJewelry.Size = new Size(165, 23);
            BTN_BrowseJewelry.TabIndex = 2;
            BTN_BrowseJewelry.Text = "BrowseJewelry";
            BTN_BrowseJewelry.UseVisualStyleBackColor = true;
            // 
            // BTN_Login
            // 
            BTN_Login.Location = new Point(101, 5);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.Size = new Size(75, 23);
            BTN_Login.TabIndex = 3;
            BTN_Login.Text = "Login";
            BTN_Login.UseVisualStyleBackColor = true;
            BTN_Login.Click += BTN_Login_Click;
            // 
            // HomeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 67);
            Controls.Add(BTN_Login);
            Controls.Add(BTN_BrowseJewelry);
            Controls.Add(LBL_CurrentUser);
            Controls.Add(label1);
            Name = "HomeMenu";
            Text = "Home Screen";
            Load += HomeMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LBL_CurrentUser;
        private Button BTN_BrowseJewelry;
        private Button BTN_Login;
    }
}
