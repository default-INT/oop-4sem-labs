using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClassLibrary
{
    /// <summary>
    /// Описывает треугольник по 3 вершинам
    /// </summary>
    public class Triangle
    {
        double x1, y1;
        double x2, y2;
        double x3, y3;

        /// <summary>
        /// Конструктор класса Tiriangle c параметрами
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        /// <summary>
        /// Находит длину отрезка по 2-м точкам
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        private double len(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        /// <summary>
        /// Находит длину стороны треугольника между точками x1, y1 и x2, y2
        /// </summary>
        /// <returns>Возвращает длину стороны A</returns>
        public double lenA()
        {
            return len(x1, y1, x2, y2);
        }

        /// <summary>
        /// Находит длину стороны треугольника между точками x1, y1 и x3, y3
        /// </summary>
        /// <returns>Возвращает длину стороны B</returns>
        public double lenB()
        {
            return len(x1, y1, x3, y3);
        }

        /// <summary>
        /// Находит длину стороны треугольника между точками x2, y2 и x3, y3
        /// </summary>
        /// <returns>Возвращает длину стороны C</returns>
        public double lenC()
        {
            return len(x2, y2, x3, y3);
        }

        /// <summary>
        /// Находит периметр треугольника
        /// </summary>
        /// <returns>Возращает периметр (double)</returns>
        public double getP()
        {
            return lenA() + lenB() + lenC();
        }

        /// <summary>
        /// Находит площадь треугольника по формуле Герона
        /// </summary>
        /// <returns>Возвращает площадь треугольника (double)</returns>
        public double getS()
        {
            double p = getP() / 2;
            return Math.Sqrt(p * (p - lenA()) * (p - lenB()) * (p - lenC()));
        }

        /// <summary>
        /// Проверяет лежит ли точка x0 в треугольнике
        /// </summary>
        /// <param name="x0">Координата точки по оси OX</param>
        /// <param name="y0">Координата точки по оси OY</param>
        /// <returns>Если точка лежит в треугольнике возвращет true, иначе false</returns>
        public bool chekPoint(double x0, double y0)
        {
            double a, b, c;
            a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            c = (x3 - x0) * (x1 - y3) - (x1 - x3) * (y3 - y0);
            return ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0) || a == 0 || b == 0 || c == 0);
        }

        /// <summary>
        /// Проверяет треугольник на существование
        /// </summary>
        /// <returns>Если треугольник существует возвращает true, иначе false</returns>
        public bool checkTriangle()
        {
            if ((x1 == x2 && x1 == x3)||(y1 == y2 && y1 == y3))
            {
                return false;
            }
            else
                return true;
        }
    }
}
