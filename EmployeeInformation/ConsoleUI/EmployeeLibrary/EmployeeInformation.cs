using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeInformation
    {
        public static void EmployeeN(Employee information)
        {
            Console.WriteLine(EmployeeLibrary.StandardMessages.AskForName());
            information.Name = Console.ReadLine();
        }
        public static void EmployeeP(Employee information)
        {
            Console.WriteLine(EmployeeLibrary.StandardMessages.AskForPhoneNumber());
            information.PhoneNumber = ConvertToInt(Console.ReadLine());
        }
        public static void EmployeeA(Employee information)
        {
            Console.WriteLine(EmployeeLibrary.StandardMessages.AskForAge());
            information.Age = ConvertToInt(Console.ReadLine());
        }
        public static int ConvertToInt(string input)
        {
            int output = 0;

            if (int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                output = -1;
                return output;
            }
        }
        //public static void EmployeeI(Employee information)
        //{
        //    Console.WriteLine(EmployeeLibrary.StandardMessages.AskForName());
        //    information.Name = Console.ReadLine();
        //}
    }
}
