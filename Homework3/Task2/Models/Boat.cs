using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Boat : Vehichle
    {

        public override string DisplayInfo()
        {
            return "Im a boat and i do not have any wheels :(";
        }
    }
}