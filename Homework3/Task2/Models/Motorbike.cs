using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Motorbike : IVehichle
    {

        public string DisplayInfo()
        {
            return "Im a motorbike and i drive on 2 wheels :)";
        }

        public string Wheelie()
        {
            return "Driving on one wheel";
        }
    }
}