using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Square : ICompute
    {
        private float side;
        public Square(float side)
        {
            this.side = side;
        }
        public void area()
        {
            Console.WriteLine("area of square is {0} ", (this.side * this.side));
        }
        public void peri()
        {
            Console.WriteLine("perimeter of squrae is {0} ", (4 * this.side));
        }
    }
}
