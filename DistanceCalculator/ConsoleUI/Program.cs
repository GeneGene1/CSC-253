/**
 * 9.26.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculate distance
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double time;
            double speed;
            double length;

            Console.WriteLine(DistanceLibrary.StandardMessages.ObjectSpeed());
            input = Console.ReadLine();

            Double.TryParse(input, out speed);

            Console.WriteLine(DistanceLibrary.StandardMessages.ObjectTime());
            input = Console.ReadLine();

            Double.TryParse(input, out time);

            length = CallDistance(speed, time);

            Console.WriteLine(DistanceLibrary.StandardMessages.ObjectDistance(length));
            input = Console.ReadLine();

            Double.TryParse(input, out length);
        }

        public static double CallDistance(double speed, double time)
        {
            double distance = speed * time;
            return distance;
        }
    }
}
