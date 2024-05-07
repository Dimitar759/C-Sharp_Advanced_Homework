using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public  interface IUserService
    {
        string Account();
        bool Register(string firstName, string lastName, string username, string password);

        bool Login(string username, string password);

        void LogOut();

        bool UpgradeToPremium();

        bool ValidateUserInput(string firstName, string lastName, string username, string password);

        //only for the trainers:
        void RescheduleTraining();
        
        void Train();




    }
}
