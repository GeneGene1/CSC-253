using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StandardMessages
    {
        public static string NumberOrganism()
        {
            return "Starting number of organisms: ";
        }

        public static string PeoplePercentage()
        {
            return "Average daily increase: ";
        }
        public static string DayMultiply()
        {
            return "Number of days to multiply: ";
        }

        public static string ShowPopulation(double population)
        {
            return $"The population is {population}";
        }
    }
}
