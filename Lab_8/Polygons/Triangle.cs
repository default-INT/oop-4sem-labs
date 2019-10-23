using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Triangle : Polygon
    {
        public static bool IsRightTriangle(Triangle triangle)
        {
            return triangle.IsRightTriangle();
        }

        public static bool IsTriangle(int[] sides)
        {
            return (sides[0] + sides[1] > sides[2] && sides[1] + sides[2] > sides[0] && sides[0] + sides[2] > sides[1]);
        }

        public Triangle(Color color, params int[] sides) : base(color, sides)
        {
            this.type = TypePolygon.triangle;
        }

        public bool IsRightTriangle()
        {
            return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2) ||
                    Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) ||
                    Math.Pow(sides[2], 2) + Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2));
        }

        public override double GetS()
        {
            double p = (double) GetP() / 2;
            return Math.Round(Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p * sides[2])), 2);
        }
    }
}
