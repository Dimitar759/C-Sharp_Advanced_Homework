using Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserDatabase.AddUser(new User("1", "Ben", "21"));
            UserDatabase.AddUser(new User("2", "Kevin", "32"));
            UserDatabase.AddUser(new User("3", "Kai", "54"));
            UserDatabase.AddUser(new User("4", "Lucy", "28"));
            UserDatabase.AddUser(new User("5", "Gwen", "46"));
            UserDatabase.AddUser(new User("6", "Max", "73"));
            UserDatabase.AddUser(new User("7", "Cooper", "37"));

            Console.WriteLine("Enter the user ID, name, or age you want to find:");
            var userSearch = Console.ReadLine().ToLower();

            List<User> searchResults = UserDatabase.Search(userSearch);

            Console.WriteLine("Search Results:");
            foreach (var user in searchResults)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }

           


        }
    }
}
