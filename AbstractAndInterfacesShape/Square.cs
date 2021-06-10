using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    class Square : Shape
    {
        
        public Square(double Length)
        {
            this.Length = Length;
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
