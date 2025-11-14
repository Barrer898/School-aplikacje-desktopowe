namespace JewleryShopExampleForm
{
    public delegate void OnUserChangeEventHandler();

    public class User
    {
        public string LoginName { get; private set; }
        public string Password { get; private set; }

        public User(string loginName, string password)
        {
            if (string.IsNullOrWhiteSpace(loginName))
            {
                throw new ArgumentException("Login name cannot be empty.", nameof(loginName));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty.", nameof(password));
            }

            LoginName = loginName;
            Password = password;
        }
    }


    internal static class Program
    {
        public static List<User> UserList = new List<User>();
        public static User CurrentUser = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User Admin = new User("Admin", "admin123");
            UserList.Add(Admin);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeMenu());
        }
    }
    public static class UserControl
    {
        public static event OnUserChangeEventHandler OnChange;
        internal static void RaiseOnChange()
        {
            OnChange?.Invoke();
        }
        public static User? GetCurrentUser()
        {
            return Program.CurrentUser;
        }
        public static void SetCurrentUser(User? user)
        {
            if(user == null)
            {
                throw new ArgumentNullException("user","Attempting to set current user as null, use ClearCurrentUser() if you want to LogOut a user");
            }
            else
            {
                if(Program.CurrentUser != user)
                {
                    Program.CurrentUser = user;
                    RaiseOnChange();
                }
            }
        }
        public static void ClearCurrentUser()
        {
            if(Program.CurrentUser != null)
            {
                Program.CurrentUser = null;
                RaiseOnChange();
            }

        }
        public static bool isLoginValid(string Login, string Password)
        {
            User tempUser = new User(Login, Password);
            foreach(User user in Program.UserList)
            {
                if(user.LoginName == tempUser.LoginName && user.Password == user.Password)
                {
                    tempUser = null; // destroy, to be eaten by GC
                    return true;
                }
            }
            return false;        
        }
        public static User? RetriveUserObject(string Login, string Password)
        {
            if(Login == null)
            {
                throw new ArgumentNullException("Login", "Provided login is null");
            }
            if (Password == null)
            {
                throw new ArgumentNullException("Password", "Provided password is null");
            }
            if (isLoginValid(Login, Password))
            {
                return new User(Login, Password);
            }
            else
            {
                return null; 
            }
        }
    }
}