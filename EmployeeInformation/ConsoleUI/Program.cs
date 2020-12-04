/**
 * 4.1.2020
 * CSC 153
 * Eugene Davis-Paulino
 * Creating a class library for employee
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            List<Employee> age = new List<Employee>();

            do
            { 
                Console.WriteLine(StandardMessages.Menu());

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(StandardMessages.AskForName());
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine(StandardMessages.AskForPhoneNumber());
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(StandardMessages.AskForAge());
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine(StandardMessages.DisplayEmployee());
                        //Console.WriteLine();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine(StandardMessages.DisplayAverageAge());
                        Console.WriteLine(Employee.Count);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        break;
                } 
            } while (exit == false);
        }
    }
}
