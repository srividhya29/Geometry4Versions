using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    class Rectangle
    {
        private float length, breadth;
        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void periRect()
        {
            Console.WriteLine("perimeter of rectangle is {0} ", ((2 * this.length) + (2 * this.breadth)));
        }
        public void areaRect()
        {
            Console.WriteLine("area of rectangle is {0}", (this.length * this.breadth));
        }
    }
}
