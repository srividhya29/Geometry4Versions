using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Compute circle = new Circle(4);
            Compute rectangle = new Rectangle(2, 8);
            Compute square = new Square(4);
            Compute triangle = new Triangle(2, 5);

            circle.area();
            circle.peri();

            rectangle.area();
            rectangle.peri();

            square.area();
            square.peri();

            triangle.area();
            triangle.peri();


           

        }
    }
}
