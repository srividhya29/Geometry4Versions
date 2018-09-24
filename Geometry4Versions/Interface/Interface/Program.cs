using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(4);
            Rectangle r = new Rectangle(2, 8);
            Square s = new Square(4);
            Triangle t = new Triangle(2, 5);

            AreaAndPerimeter obj = new AreaAndPerimeter();

            obj.area(c);
            obj.peri(c);

            obj.area(r);
            obj.peri(r);

            obj.area(s);
            obj.peri(s);

            obj.area(t);
            obj.peri(t);

        }
    }
}
