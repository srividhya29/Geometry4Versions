using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Rectangle : ICompute
    {
        private float length, breadth;
        public Rectangle(float length, float breadth)
        {
         
            this.length = length;
            this.breadth = breadth;
        }
        public void peri()
        {
            
            
            Console.WriteLine("perimeter of rectangle is {0} {1} ", ((2 * this.length) + (2 * this.breadth)));
        }
        public void area()
        {
            Console.WriteLine("area of rectangle is {0}", (this.length * this.breadth));
        }
    }
}
