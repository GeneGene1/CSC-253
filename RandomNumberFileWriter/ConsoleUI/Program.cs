/**
 * 10.9.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that pick random number of files
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
            Random random = new Random();
            //int numberHold = 0;
            StreamWriter outputFile;

            try
            {
                outputFile = File.CreateText("RandomNumber.txt");

                outputFile.WriteLine("how many random numbers the file will hold and should be saved to a user-specific file name? ");
                //Double.TryParse(Random);
                for (int i = 0; i < 10; i++)
                {
                    outputFile.WriteLine(random.Next(1, 101));
                }
                //for (int i = 0; i < numberHold; i++)
                //{
                //    outputFile.WriteLine(random.Next(1, 101));
                //}
                Console.WriteLine("how many random numbers the file will hold and should be saved to a user-specific file name? ");
                //Double.TryParse(Console.ReadLine(), out random);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
