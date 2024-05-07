using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class MenuService : IMenuService
    {
        public void PremiumUserMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Train");
            Console.WriteLine("2. Account");
            Console.WriteLine("3. Log Out");
        }

        public void TrainerMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Reschedule Training");
            Console.WriteLine("2. Account");
            Console.WriteLine("3. Train");
            Console.WriteLine("4. Log Out");
        }

        public void UserMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Train");
            Console.WriteLine("2. Upgrade to Premium");
            Console.WriteLine("3. Account");
            Console.WriteLine("4. Log Out");
        }
    }
}
