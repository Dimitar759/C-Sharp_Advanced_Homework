using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Airplane : IVehichle
    {
        public string DisplayInfo()
        {
            return "Im a plane i have a couple of wheels :)";
        }
    }
}
