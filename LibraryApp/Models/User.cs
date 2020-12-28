namespace LibraryApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public User()
        {

        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
