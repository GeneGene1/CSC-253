/**
 * 10.9.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that read random number of files
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int random = 0;
            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText("RandomNumber.txt");

                
                while (!inputFile.EndOfStream)
                {
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    total = int.Parse(inputFile.ReadLine());
                    //total = int.Parse(inputFile.ReadLine(1,10));
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    random = int.Parse(inputFile.ReadLine());
                    //random =int.Parse(inputFile.ReadLine(1,10));
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine($"The total of number is {total}.");
            Console.WriteLine($"The number of random number is {random}.");
            Console.ReadLine();
        }
    }
}
