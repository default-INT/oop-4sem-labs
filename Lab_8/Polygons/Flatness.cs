using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Flatness
    {
        private List<Polygon> polygons;

        public static int[] SidesToInt(string line)
        {
            string[] sidesStr = line.Split();
            int[] sides = new int[sidesStr.Length];
            for (int i = 0; i < sidesStr.Length; i++)
            {
                sides[i] = Convert.ToInt32(sidesStr[i]);
            }
            return sides;
        }

        public Flatness()
        {
            this.polygons = ReadPolygonsToFile(@"D:\Other\GSTU\semester_4\OOP\Lab_8\file\defaultFigures.txt");
        }

        public Flatness(string way)
        {
            this.polygons = ReadPolygonsToFile(way);
        }

        /// <summary>
        /// Метод возвращает список многоугольников 
        /// </summary>
        /// <returns></returns>
        public List<Polygon> GetPolygons()
        {
            return polygons;
        }

        /// <summary>
        /// Метод добавляет новый многоугольник в список
        /// </summary>
        /// <param name="color"></param>
        /// <param name="sides"></param>
        public void AddPolygons(string color, params int[] sides)
        {
            polygons.Add(ReturnPolygon(sides, Color.FromName(color)));
        }

        /// <summary>
        /// Метод сортирует многоугольники по возрастанию площадей
        /// </summary>
        public void SortPolygons()
        {
            polygons.Sort();
        }

        /// <summary>
        /// Метод возвращает сумму периметров всех красных прямоугольных треугольников
        /// </summary>
        /// <returns></returns>
        public int GetP_RedRightTriangle()
        {
            int P = 0;

            foreach (Polygon polygon in polygons)
            {
                if (polygon.type == TypePolygon.triangle && polygon.color == Color.FromName("Red")
                    && Triangle.IsRightTriangle((Triangle) polygon)) P += polygon.GetP();
            }
            return P;
        }

        /// <summary>
        /// Метод читает с файла по указаному пути 
        /// </summary>
        /// <param name="way"></param>
        public void ReadToFile(string way)
        {
            polygons = ReadPolygonsToFile(way);
        }

        /// <summary>
        /// /// Метод читает с файла по указаному пути и возвращает список многоугольников 
        /// </summary>
        /// <param name="way"></param>
        /// <returns></returns>
        private List<Polygon> ReadPolygonsToFile(string way)
        {
            List<Polygon> polygons = new List<Polygon>();
            StreamReader reader = new StreamReader(way);
            string[] lines;

            while (!reader.EndOfStream)
            {
                lines = reader.ReadLine().Split();
                int[] sides = new int[lines.Length - 1];
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != lines.Length - 1) sides[i] = Convert.ToInt32(lines[i]);
                    else polygons.Add(ReturnPolygon(sides, Color.FromName(lines[i])));
                }
            }
            reader.Close();
            return polygons;
        }

        /// <summary>
        /// Метод возвращает многоугольник по сторонам и цвету
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        private Polygon ReturnPolygon(int[] sides, Color color)
        {
            switch (sides.Length)
            {
                case 1:
                    return new Square(color, sides);
                case 2:
                    return new Rectangle(color, sides);
                case 3:
                    if (Triangle.IsTriangle(sides)) return new Triangle(color, sides);
                    else throw new Exception("Треугольник с такими сторонами не может существовать.");
                default:
                    throw new Exception("Не существует фигуры с данным количеством сторон.");
            }
        }
    }
}
