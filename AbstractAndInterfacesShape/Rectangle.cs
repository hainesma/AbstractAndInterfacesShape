using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }


        public double GetArea()
        {
            double area = Length * Width;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Length * 2 + Width * 2;
            return perimeter;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is a rectangle.");
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);


        }
    }
}
