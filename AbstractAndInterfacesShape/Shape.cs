using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    class Shape
    {
        //properties go here if any
        public double Length { get; set; }
        public double Width { get; set; }


        // We won't use a constructor here because we don't want to force parameters on the children

        public virtual double GetArea()
        {
            double area = Length * Width;
            return area;
        }

        public virtual double GetPerimeter()
        {
            double perimeter = Length * 2 + Width * 2;
            return perimeter;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);
        }
    }
}
