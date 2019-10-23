using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polygons
{
    public abstract class Polygon : IComparable
    {
        public int[] sides { get; set; }
        public Color color { get; set; }
        public TypePolygon type { get; set; }

        public Polygon(Color color, params int[] sides)
        {
            this.color = color;
            this.sides = sides;
        }

        public abstract double GetS();

        public int GetP()
        {
            int p = 0;

            foreach (int side in sides)
            {
                p += side;
            }
            return p;
        }

        private string GetType(TypePolygon type)
        {
            switch (type)
            {
                case TypePolygon.triangle:
                    return "Треугольник";
                case TypePolygon.rectnagle:
                    return "Прямоугольник";
                case TypePolygon.square:
                    return "Квадрат";
            }
            return null;
        }

        private string GetSideToString()
        {
            string str = "";
            foreach (int l in sides)
            {
                str += l.ToString() + " ";
            }
            return str;
        }

        public new string ToString => GetType(type) + " | Длины сторон: " + GetSideToString()
                + "см | Периметр: " + GetP() + " см | Площадь: " + GetS() + " см^2";

        public int CompareTo(object obj)
        {
            Polygon polygon = obj as Polygon;
            return GetS().CompareTo(polygon.GetS());
        }
    }
}
