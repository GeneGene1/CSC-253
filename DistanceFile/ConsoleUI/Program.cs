/**
 * 10.3.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculate distance with streamwriter and streamreader
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "";
            double time = 0;
            double speed = 0;
            double length = 0;

            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Distance.txt");

                //outputFile.Write("What was the speed the object was going? ");
                //outputFile.WriteLine(Console.ReadLine());
                outputFile.WriteLine("10");
                //outputFile.WriteLine("How many hours it took for the object to get to the location? ");
                //outputFile.WriteLine(Console.ReadLine());
                outputFile.WriteLine("4");

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText("Distance.txt");


                while (!inputFile.EndOfStream)
                {
                    //input = inputFile.ReadLine();
                    speed = int.Parse(inputFile.ReadLine());
                    time = int.Parse(inputFile.ReadLine());
                    //length = int.Parse(inputFile.ReadLine());

                    length = speed * time;
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine($"The object traveled {length} miles.");
            Console.ReadLine();
        }
    }
}
