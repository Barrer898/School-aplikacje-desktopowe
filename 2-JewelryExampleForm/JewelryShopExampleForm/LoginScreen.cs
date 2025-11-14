using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JewleryShopExampleForm
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if(UserControl.isLoginValid(TXB_Login.Text, TXB_Password.Text))
            {
                UserControl.SetCurrentUser(UserControl.RetriveUserObject(TXB_Login.Text, TXB_Password.Text));
            }
        }
    }
}
