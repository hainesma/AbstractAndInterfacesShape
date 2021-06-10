using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }


        public override double GetArea()
        {
            double area = Length * Width;
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = Length * 2 + Width * 2;
            return perimeter;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("This is a rectangle.");
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);


        }
    }
}
