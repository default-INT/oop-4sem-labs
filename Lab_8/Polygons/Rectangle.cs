using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Rectangle : Polygon
    {
        public Rectangle(Color color, params int[] sides) : base(color, sides)
        {
            this.type = TypePolygon.rectnagle;
        }

        public override double GetS()
        {
            return sides[0] * sides[1];
        }
    }
}
