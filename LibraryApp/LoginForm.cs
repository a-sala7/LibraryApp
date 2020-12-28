using LibraryApp.Models;
using LibraryApp.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class LoginForm : Form
    {
        private readonly IDatabase _database;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(IDatabase database)
        {
            InitializeComponent();
            _database = database;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.Trim() == "" || passwordTB.Text.Trim() == "")
            {
                statusLabel.Text = "Username/password cannot be blank";
                return;
            }
            User user = _database.GetUser(usernameTB.Text);

            if (user != null && passwordTB.Text == user.Password)
            {
                if (_database.GetUser(usernameTB.Text).IsAdmin)
                {
                    MainForm mf = new MainForm(user, _database);
                    this.Hide();
                    mf.Show();
                }
                else
                {
                    MainForm mf = new MainForm(user, _database);
                    this.Hide();
                    mf.Show();
                }
            }
            else
            {
                statusLabel.Text = "Invalid username or password.";
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text.Trim() == "" || passwordTB.Text.Trim() == "")
            {
                statusLabel.Text = "Username/password cannot be blank";
                return;
            }
            if(_database.GetUser(usernameTB.Text) != null)
            {
                statusLabel.Text = "Duplicate username.";
                return;
            }
            User user = new User(usernameTB.Text, passwordTB.Text, false);
            try
            {
                _database.RegisterUser(user);

                MessageBox.Show("Registered successfully.\nPress OK to continue to the application");
                MainForm mf = new MainForm(user, _database);
                this.Hide();
                mf.Show();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                statusLabel.Text = "An error occured.";
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
