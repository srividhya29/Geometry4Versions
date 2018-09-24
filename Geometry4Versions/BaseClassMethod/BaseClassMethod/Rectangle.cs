using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassMethod
{
    class Rectangle : Compute
    {
        private float length, breadth;
        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        override public void peri()
        {
            Console.WriteLine("perimeter of rectangle is {0} ", ((2 * this.length) + (2 * this.breadth)));
        }
        override public void area()
        {
            Console.WriteLine("area of rectangle is {0}", (this.length * this.breadth));
        }
    }
}
