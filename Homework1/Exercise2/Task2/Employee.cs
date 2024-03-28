using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public abstract class Employee
    {
        public int MonthlySalary {  get; set; }

        public Employee(int salaryMonth) 
        {
            MonthlySalary = salaryMonth;
        }

        public abstract int CalculateSalary();

        public abstract string DisplayInfo();

    }
}
