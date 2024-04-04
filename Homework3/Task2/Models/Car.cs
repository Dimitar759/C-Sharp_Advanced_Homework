using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : IVehichle
    {
        public string DisplayInfo()
        {
            return "Im a car and i drive with 4 wheels :)";
        }

        public string Drive()
        {
            return "Driving";
        }
    }

}