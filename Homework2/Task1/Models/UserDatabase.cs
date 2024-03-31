using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class UserDatabase
    {
        
        public static List<User> Users { get; set; }  = new List<User>();

        public static void AddUser(User user)
        {
            try
            {
                Users.Add(user);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"A NullReferenceException occurred while adding user: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding user: {ex.Message}");
            }
        }

        public static List<User> Search(string searchTerm)
        {
            List<User> searchResults = new List<User>();
            try
            {

                foreach (var user in Users)
                {
                    if (user.Id == searchTerm)
                        searchResults.Add(user);

                    if (user.Name.ToLower() == searchTerm)
                        searchResults.Add(user);

                    if (user.Age == searchTerm)
                        searchResults.Add(user);
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding user: {ex.Message}");
            }
            return searchResults;
        }
    }
    
}
