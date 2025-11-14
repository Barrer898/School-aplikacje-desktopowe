using static System.Net.Mime.MediaTypeNames;

namespace JewleryShopExampleForm
{
    public partial class HomeMenu : Form
    {
        LoginScreen loginScreen;
        public HomeMenu()
        {
            InitializeComponent();
        }

        internal void UpdateCurrentUserDisplay()
        {
            if (UserControl.GetCurrentUser() != null)
                BTN_Login.Visible = false;
            else
                BTN_Login.Visible = true;

            if (UserControl.GetCurrentUser() != null)
            {
                LBL_CurrentUser.Text = UserControl.GetCurrentUser().LoginName;
                BTN_BrowseJewelry.Enabled = true;
                loginScreen.Close();
            }
            
        }
        private void HomeMenu_Load(object sender, EventArgs e)
        {
            UserControl.OnChange += UpdateCurrentUserDisplay;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            loginScreen = new LoginScreen();
            loginScreen.ShowDialog();
        }
    }
}
