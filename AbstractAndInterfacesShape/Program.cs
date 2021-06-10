using System;

namespace AbstractAndInterfacesShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(10);
            TestShape(s);

            Rectangle r = new Rectangle(10, 6);
            TestShape(r);

            Circle c = new Circle(10);
        }

        public static void TestShape(Shape s)
        {
            s.PrintInfo();
            double area = s.GetArea();
            double perimeter = s.GetPerimeter();
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
