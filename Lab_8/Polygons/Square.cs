using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Square : Polygon
    {
        public Square(Color color, params int[] sides) : base(color, sides)
        {
            this.type = TypePolygon.square;
        }

        public override double GetS()
        {
            return sides[0] * sides[0];
        }
    }
}
