using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLibrary
{
    public static class StandardMessages
    {
        public static string ObjectSpeed()
        {
            return "What was the speed the object was going?";
        }

        public static string ObjectTime()
        {
            return "How many hours it took for the object to get to the location?";
        }

        public static string ObjectDistance(double length)
        {
            return $"The object traveled {length} miles.";
        }
    }
}
