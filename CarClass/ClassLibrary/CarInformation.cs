using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class CarInformation
    {
        public static void CreateCar(Car inputCar)
        {
            Console.WriteLine(ClassLibrary.StandardMessages.AskForYear());
            inputCar.Year = Console.ReadLine();

            Console.WriteLine(ClassLibrary.StandardMessages.AskForMake());
            inputCar.Make = Console.ReadLine();
        }
    }
}
