using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class StandardMessages
    {
        public static string MedicationCost()
        {
            return "How much does the medication cost? ";
        }

        public static string SurgicalCost()
        {
            return "How much does the surgical cost? ";
        }
        public static string RehabCost()
        {
            return "How much does the rehabilitation cost? ";
        }
        public static string LabCost()
        {
            return "How much is it for the lab fee? ";
        }
        public static string CalcMiscCost(double miscCost)
        {
            return $"The miscellaneous cost is ${miscCost}";
        }
        public static string DaySpent()
        {
            return "How many days spent at the hospital? ";
        }
        public static string CalcStayCost(double dayStay)
        {
            return $"The cost of days spent at the hospital is ${dayStay}";
        }
        public static string CalcTotalCost(double totalCost)
        {
            return $"The total cost at the hospital is ${totalCost}";
        }
    }
}
