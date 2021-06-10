using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesShape
{
    interface IShape
    {
        // No properties, variables, or constructors are allowed in interfaces
        // Only method stubs

        // This is a method stub. It has no body, no curlies.
        // The children must override all method stubs.
        public double GetArea();
        public double GetPerimeter();
        public void PrintInfo();
    }
}
