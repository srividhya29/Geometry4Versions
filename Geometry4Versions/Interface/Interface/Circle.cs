using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Circle : ICompute
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        double pi = Math.PI;
        public void area()
        {
            System.Console.WriteLine("area of circle is {0} ", (pi * this.r * this.r));
        }
         public void peri()
        {
            System.Console.WriteLine("perimeter of circle is {0} ", (2 * pi * this.r));
        }
    }
}
