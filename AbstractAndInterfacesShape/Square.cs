using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{

    // The children promise they will fill in an interface's methods
    // C# will hold you to that promise
    class Square : IShape
    {
        public double Length { get; set; }
        public Square(double Length)
        {
            this.Length = Length;
        }
        public double GetArea()
        {
            double area = Length * Length;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Length * 4;
            return perimeter;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is a square.");
            Console.WriteLine("Length: " + Length);
            
        }
    }
}
