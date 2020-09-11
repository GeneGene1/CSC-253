/**
 * 9.4.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculates the total cost of a hospital stay
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double medicationCharges;
            double surgicalCharges;
            double labFees;
            double rehabilitationCharges;
            double miscCost;
            double days;
            double dayStay;
            double totalCost;
            


            Console.WriteLine(HospitalLibrary.StandardMessages.MedicationCost());
            input = Console.ReadLine();

            Double.TryParse(input, out medicationCharges);

            Console.WriteLine(HospitalLibrary.StandardMessages.SurgicalCost());
            input = Console.ReadLine();

            Double.TryParse(input, out surgicalCharges);

            Console.WriteLine(HospitalLibrary.StandardMessages.RehabCost());
            input = Console.ReadLine();

            Double.TryParse(input, out rehabilitationCharges);

            Console.WriteLine(HospitalLibrary.StandardMessages.LabCost());
            input = Console.ReadLine();

            Double.TryParse(input, out labFees);

            miscCost = CalcMiscCharges(medicationCharges, surgicalCharges, rehabilitationCharges, labFees);

            Console.WriteLine(HospitalLibrary.StandardMessages.CalcMiscCost(miscCost));
            input = Console.ReadLine();

            Double.TryParse(input, out miscCost);

            Console.WriteLine(HospitalLibrary.StandardMessages.DaySpent());
            input = Console.ReadLine();

            Double.TryParse(input, out days);

            dayStay = CalcStayCharges(days);

            Console.WriteLine(HospitalLibrary.StandardMessages.CalcStayCost(dayStay));
            input = Console.ReadLine();

            Double.TryParse(input, out dayStay);

            totalCost = CalcTotalCharges(miscCost, dayStay);

            Console.WriteLine(HospitalLibrary.StandardMessages.CalcTotalCost(totalCost));
            input = Console.ReadLine();

            Double.TryParse(input, out totalCost);
        }
        public static double CalcMiscCharges(double medicationCharges, double surgicalCharges, double rehabilitationCharges, double labFees)
        {
            double miscCharges = medicationCharges + surgicalCharges + rehabilitationCharges + labFees;
            return miscCharges;
        }
        public static double CalcStayCharges(double days)
        {
            double stayCharges = days * 350;
            return stayCharges;
        }
        public static double CalcTotalCharges(double miscCost, double dayStay)
        {
            double total = miscCost + dayStay;
            return total;
        }
    }
}
