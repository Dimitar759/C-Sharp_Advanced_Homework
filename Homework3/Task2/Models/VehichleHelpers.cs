using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class VehichleHelpers 
    {
        public static string Drive(this string driving)
        {
            return "Driving";
        }

        public static string Wheelie(this string oneWheeling)
        {
            return "Driving on one wheel";
        }

        public static string Sale(this string sailing)
        {
            return "Saling";
        }
        public static string Fly(this string flying)
        {
            return "Flying";
        }
    }
}
