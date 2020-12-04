using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        // Fields
        private string _name;
        private int _phoneNumber;
        private int _age;

        // Constructor
        public Employee()
        {
            Name = "";
            PhoneNumber = 0;
            Age = 0;
            Count++;
        }

        public Employee(string name, int phoneNumber, int age)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Age = age;
            Count++;
        }

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public static int Count { get; set; } = 0;
    }
}
