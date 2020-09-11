using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class StandardMessages
    {
        public static string Length()
        {
            return "What is the length? ";
        }
        public static string Width()
        {
            return "What is the width? ";
        }
        public static string Height()
        {
            return "What is the height? ";
        }
        public static string Radius()
        {
            return "What is the radius? ";
        }
        public static string CircleArea(double cir)
        {
            return $"The circle area is {cir}";
        }
        public static string RectangleArea(double rec)
        {
            return $"The rectangle area is {rec}";
        }
        public static string CylinderArea(double cyl)
        {
            return $"The cylinder area is {cyl}";
        }
    }
}
