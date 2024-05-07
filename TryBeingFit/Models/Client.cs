using Models.Enums;

namespace Models
{
    public class Client : User
    {
        public Client(int id, string firstName, string lastName, string username, string password, UserType accountType) 
            : base(id, firstName, lastName, username, password, accountType)
        {
        }

       
    }
}
// narpavi servisi za login logout i register
// Train da bide za site negavi treninzi
//account da bide za detalite na userot- dali e user ili trener