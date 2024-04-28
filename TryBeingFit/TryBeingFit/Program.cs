using Models;
using Models.Enums;
using DataAccess;
using System;

namespace TryBeingFit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Users newUser = new Users("John", "Doe", "john123", "password123", UserType.Standard);

            
            Storage.Users.Add(newUser);

            
            var allUsers = Storage.Users.GetAll();
            foreach (var user in allUsers)
            {
                Console.WriteLine($"User: {user.FirstName} {user.LastName}, Username: {user.Username}, UserType: {user.AccountType}");
            }


        }
    }
}
