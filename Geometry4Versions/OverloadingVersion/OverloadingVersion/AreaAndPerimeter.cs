using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingVersion
{
    class AreaAndPerimeter
    {


        public void areaCircle(Circle c)
        {
            c.areaCircle();
        }
        public void areaTriangle(Triangle t)
        {
            t.areaTriangle();
        }
        public void areaSquare(Square s)
        {
            s.areaSquare();
        }
        public void areaRect(Rectangle r)
        {
            r.areaRect();
        }


        public void periCircle(Circle c)
        {
            c.periCircle();
        }
        public void periTriangle(Triangle t)
        {
            t.periTriangle();
        }
        public void periSquare(Square s)
        {
            s.periSquare();
        }
        public void periRect(Rectangle r)
        {
            r.areaRect();
        }

    }
}
