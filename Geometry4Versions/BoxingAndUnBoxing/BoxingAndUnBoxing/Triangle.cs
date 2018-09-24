using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    class Triangle
    {
        private float height, breadth;
        public Triangle(float height, float breadth)
        {
            this.height = height;
            this.breadth = breadth;
        }
        public void areaTriangle()
        {
            Console.WriteLine("area of triangle is {0} ", (0.5 * this.breadth * this.height));
        }
        public void periTriangle()
        {
            double z = this.height + this.breadth + Math.Sqrt(Math.Pow(this.height, 2) * Math.Pow(this.breadth, 2));
            Console.WriteLine("perimeter of triangle is {0} ", z);
        }
    }
}
