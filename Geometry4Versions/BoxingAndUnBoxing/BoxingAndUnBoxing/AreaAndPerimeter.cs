using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    class AreaAndPerimeter
    {


        public void area(Object o)
        {
            if (o is Circle)
            {
                (o as Circle).areaCircle();
            }
            else if (o is Rectangle)
            {
                (o as Rectangle).areaRect();
            }
            else if (o is Square)
            {
                (o as Square).areaSquare();
            }
            else if (o is Triangle)
            {
                (o as Triangle).areaTriangle();
            }

        }


        public void peri(Object o)
        {
            if (o is Circle)
            {
                (o as Circle).periCircle();
            }
            else if (o is Rectangle)
            {
                (o as Rectangle).periRect();
            }
            else if (o is Square)
            {
                (o as Square).periSquare();
            }
            else if (o is Triangle)
            {
                (o as Triangle).periTriangle();
            }

        }







    }
}
