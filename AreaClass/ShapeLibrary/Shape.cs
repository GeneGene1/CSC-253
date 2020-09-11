using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Shape
    {
        private string _length;
        private string _width;
        private string _heigth;
        private string _pi;

        public Shape()
        {
            Length = "";
            Width = "";
            Height = "";
            Pi = "";
        }
        public Shape(string length, string width, string height, string pi)
        {
            Length = length;
            Width = width;
            Height = height;
            Pi = pi;
        }
        public string Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public string Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public string Height
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = value;
            }
        }
        public string Pi
        {
            get
            {
                return _pi;
            }
            set
            {
                _pi = value;
            }
        }
        //public static double Shape(double pi, double radius)
        //{
        //    double circle = pi * radius * radius;
        //    return circle;
        //}
        //public static double Shape(double length, double width)
        //{
        //    double rectangle = length * width;
        //    return rectangle;
        //}
        //public static double Shape(double pi, double radius, double height)
        //{
        //    double cylinder = 2 * pi * (radius * radius) + height * (2 * pi * radius);
        //    return cylinder;
        //}
    }
}
