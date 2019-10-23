using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleClassLibrary;

namespace ConsoleTriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1;
            double x2, y2;
            double x3, y3;
            bool k;
            Console.WriteLine("Введите координаты треугольника x1, y1, x2, y2, x3, y3:");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);
            if (triangle.checkTriangle() == true)
            {
                k = true;
                Console.WriteLine("Фигура существует.");
                Console.ReadKey();
            }
            else
            {
                k = false;
                Console.WriteLine("Такой треугольник не существует.");
                Console.ReadKey();
            }
            int n = 0;
            while (k == true && n != 4)
            {
                Console.Clear();
                Console.WriteLine("------------------Меню------------------");
                Console.WriteLine("1) Вывести периметр треугольика.");
                Console.WriteLine("2) Вывести площадь треугольика.");
                Console.WriteLine("3) Проверить лежит ли точка F(x0, y0) внутри треугольника.");
                Console.WriteLine("4) Выход.");
                Console.WriteLine("----------------------------------------");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Периметр треугольника равен P = " + triangle.getP());
                        break;
                    case 2:
                        Console.WriteLine("Площадь треугольника равна S = " + triangle.getS());
                        break;
                    case 3:
                        double x0, y0;
                        Console.WriteLine("Введите координаты точки F(x0,y0):");
                        x0 = Convert.ToDouble(Console.ReadLine());
                        y0 = Convert.ToDouble(Console.ReadLine());
                        if (triangle.chekPoint(x0, y0) == true)
                        {
                            Console.WriteLine("Точка лежит внутри треугольника.");
                        }
                        else
                        {
                            Console.WriteLine("Точка не лежит внутри треугольника.");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Нет такого пнукта.");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу ... ");
                Console.ReadKey();
            }
        }
    }
}
