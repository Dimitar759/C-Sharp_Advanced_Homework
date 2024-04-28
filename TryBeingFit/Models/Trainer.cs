using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainer : User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType AccountType { get; } = UserType.Trainer; 

        public Trainer(int id, string firstName, string lastName, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            
        }

        public void RescheduleTraining()
        {

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

        public bool Login()
        {

            return true;
        }


        public void DisplayMenu()
        {
            //Reschedule training, account, train , logout
        }
    }
}
