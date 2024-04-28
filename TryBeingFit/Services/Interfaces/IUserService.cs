using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public  interface IUserService
    {
        void Account();
        bool Register();

        bool Login();

        void LogOut();

        void UpgradeToPremium();

        bool ValidateUserInput(string firstName, string lastName, string username, string password);

        //only for the trainers:
        void RescheduleTraining();
        
        void Train();




    }
}
