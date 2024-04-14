using Models.Enums;

namespace Models
{
    public class Users : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType AccountType { get; set; }

        public Users(string firstName, string lastName, string username, string password, UserType accountType)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            AccountType = accountType;
        }

        public bool ValidateFirstName()
        {
            return FirstName.Length >= 2;
        }

        public bool ValidateLastName()
        {
            return LastName.Length >= 2;
        }

        public bool ValidateUsername()
        {
            return Username.Length >= 6;
        }

        public bool ValidatePassword()
        {
            return Password.Length >= 6 && Password.Any(char.IsDigit);
        }

        public bool Register(Users user)
        {
            users.Add(user);
            return true; 
        }

        public bool Login()
        {
            
            return true; 
        }

        public void UpgradeToPremium()
        {
            if (AccountType == UserType.Standard)
            {
                AccountType = UserType.Premium;
            }
        }

        public void DisplayMenu()
        {
            if (AccountType == UserType.Standard)
            {
                
            }

            if (AccountType == UserType.Premium)
            {

            }
        }
    }
}
