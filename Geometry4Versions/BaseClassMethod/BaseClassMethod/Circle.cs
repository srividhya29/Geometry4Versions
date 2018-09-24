using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassMethod
{
    class Circle : Compute
    {
        //private double r;
        public Circle(double r)
        {
            this.radius = r;
        }
        public double radius { get; private set; }
        

        double pi = Math.PI;
        override public void area()
        {
            System.Console.WriteLine("area of circle is {0} ", (pi * this.radius * this.radius));
        }
        override public void peri()
        {
            System.Console.WriteLine("perimeter of circle is {0} ", (2 * pi * this.radius));
        }
    }
}
