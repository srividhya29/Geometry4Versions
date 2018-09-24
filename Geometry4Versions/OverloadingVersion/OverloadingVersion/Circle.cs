using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingVersion
{
    class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        double pi = Math.PI;
        public void areaCircle()
        {
            System.Console.WriteLine("area of circle is {0} ", (pi * this.r * this.r));
        }
        public void periCircle()
        {
            System.Console.WriteLine("perimeter of circle is {0} ", (2 * pi * this.r));
        }
    }
}
