using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    class Square
    {
        private float side;
        public Square(float side)
        {
            this.side = side;
        }
        public void areaSquare()
        {
            Console.WriteLine("area of square is {0} ", (this.side * this.side));
        }
        public void periSquare()
        {
            Console.WriteLine("perimeter of squrae is {0} ", (4 * this.side));
        }
    }
}
