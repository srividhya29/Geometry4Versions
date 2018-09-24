using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingVersion
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

            obj.areaCircle(c);
            obj.periCircle(c);

            obj.areaRect(r);
            obj.periRect(r);

            obj.areaSquare(s);
            obj.periSquare(s);

            obj.areaTriangle(t);
            obj.periTriangle(t);

        }
    }
}
