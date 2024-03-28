using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Programmer : Employee
    {

        public int MonthsPerYear { get; set; }

        public Programmer(int monthMoney, int monthsPerYear) : base(monthMoney)
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
