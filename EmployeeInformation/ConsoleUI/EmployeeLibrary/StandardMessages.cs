using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class StandardMessages
    {
        public static string Menu()
        {
            return "1. Employee's name\n2. Employee's phone number\n3. Employee's age\n" +
                "4. Display employee information\n5. Display employees average age\n6. Exit\n-->";
        }
        public static string AskForName()
        {
            return "What is the employee's name?";
        }
        public static string AskForPhoneNumber()
        {
            return "What is the employee's phone number?";
        }
        public static string AskForAge()
        {
            return "What is the employee's age?";
        }
        public static string DisplayEmployee()
        {
            return "Employee Name";
        }
        public static string DisplayAverageAge()
        {
            return "What are the employee average age?";
        }
    }
}
