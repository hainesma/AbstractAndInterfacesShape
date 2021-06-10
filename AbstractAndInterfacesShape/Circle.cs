using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double GetPerimeter()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("This is a circle");
            Console.WriteLine("Radius: " + Radius);
        }
    }
}
