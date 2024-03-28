using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class Manager : Employee
    {
        public int MonthsPerYear { get; set; }

        public Manager(int monthMoney, int monthsPerYear) : base(monthMoney)
        {
            MonthsPerYear = monthsPerYear;
        }

        public override int CalculateSalary()
        {
            return MonthlySalary * MonthsPerYear;
        }

        public override string DisplayInfo()
        {
            int yearlySalary = CalculateSalary();
            return $"Yearly Salary: {yearlySalary}$";
        }
    }
}
