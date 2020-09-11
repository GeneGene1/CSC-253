/* 
 * 8.30.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculate the size of a population
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double organism;
            double percentage;
            double day;
            double population;

            Console.WriteLine(ClassLibrary.StandardMessages.NumberOrganism());
            input = Console.ReadLine();

            Double.TryParse(input, out organism);

            Console.WriteLine(ClassLibrary.StandardMessages.PeoplePercentage());
            input = Console.ReadLine();

            Double.TryParse(input, out percentage);
            
            Console.WriteLine(ClassLibrary.StandardMessages.DayMultiply());
            input = Console.ReadLine();

            Double.TryParse(input, out day);

            population = OrganismPopulation(percentage, organism, day);

            Console.WriteLine(ClassLibrary.StandardMessages.ShowPopulation(population));
            input = Console.ReadLine();

            Double.TryParse(input, out population);
        }

        public static double OrganismPopulation(double percentage, double organism, double day)
        {
            double people = organism * percentage * day;
            return people;
        }
    }
}
