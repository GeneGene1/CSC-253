/**
 * 9.4.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculate the area of shapes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double pi = Math.PI;
            double length;
            double width;
            double height;
            double radius;
            double cir;
            double rec;
            double cyl;

            Console.WriteLine(ShapeLibrary.StandardMessages.Length());
            input = Console.ReadLine();

            Double.TryParse(input, out length);

            Console.WriteLine(ShapeLibrary.StandardMessages.Width());
            input = Console.ReadLine();

            Double.TryParse(input, out width);

            Console.WriteLine(ShapeLibrary.StandardMessages.Height());
            input = Console.ReadLine();

            Double.TryParse(input, out height);

            Console.WriteLine(ShapeLibrary.StandardMessages.Radius());
            input = Console.ReadLine();

            Double.TryParse(input, out radius);

            cir = Shape(radius);

            Console.WriteLine(ShapeLibrary.StandardMessages.CircleArea(cir));
            input = Console.ReadLine();

            Double.TryParse(input, out cir);

            rec = Shape(length, height);

            Console.WriteLine(ShapeLibrary.StandardMessages.RectangleArea(rec));
            input = Console.ReadLine();

            Double.TryParse(input, out rec);

            cyl = Shape(pi, radius, height);

            Console.WriteLine(ShapeLibrary.StandardMessages.CylinderArea(cyl));
            input = Console.ReadLine();

            Double.TryParse(input, out cyl);
        }
        public static double Shape(double radius)
        {
            double circle = Math.PI * radius * radius;
            return circle;
        }
        public static double Shape(double length, double width)
        {
            double rectangle = length * width;
            return rectangle;
        }
        public static double Shape(double pi, double radius, double height)
        {
            double cylinder = 2 * pi * (radius * radius) + height * (2 * pi * radius);
            return cylinder;
        }
    }
}
