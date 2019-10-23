using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MatrixClassLibrary;

namespace MatrixConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1, matrix2, matrix3;
            int k = 0;

            matrix1 = inputMatrix("A");
            outputMatrix(matrix1, "A");

            matrix2 = inputMatrix("B");
            outputMatrix(matrix2, "B");
            Console.ReadKey();
            while (k != 7)
            {
                menu();
                k = Int32.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        matrix1 = inputMatrix("A");
                        outputMatrix(matrix1, "A");
                        break;
                    case 2:
                        matrix2 = inputMatrix("B");
                        outputMatrix(matrix2, "B");
                        break;
                    case 3:
                        if (matrix1.GetUpperBound(0) == matrix2.GetUpperBound(0) && matrix1.GetUpperBound(1) == matrix2.GetUpperBound(1))
                        {
                            matrix3 = Matrix.sumMatrix(matrix1, matrix2);
                            outputMatrix(matrix3, "A+B");
                        }
                        else
                        {
                            Console.WriteLine("Эти матрицы нельзя сложить");
                        }
                        
                        break;
                    case 4:
                        if (matrix1.GetUpperBound(0) == matrix2.GetUpperBound(0) && matrix1.GetUpperBound(1) == matrix2.GetUpperBound(1))
                        {
                            matrix3 = Matrix.subMatrix(matrix1, matrix2);
                            outputMatrix(matrix3, "A-B");
                        }
                        else
                        {
                            Console.WriteLine("Эти матрицы нельзя вычесть.");
                        }
                        break;

                    case 5:
                        if (matrix2.GetUpperBound(0) == matrix1.GetUpperBound(1))
                        {
                            matrix3 = Matrix.prodMatrix(matrix1, matrix2);
                            outputMatrix(matrix3, "A*B");
                        }
                        else
                        {
                            Console.WriteLine("Эти матрицы нельзя умножить");
                        }
                        break;
                    case 6:
                        int c;
                        Console.Write("Введите число c: ");
                        c = Int32.Parse(Console.ReadLine());
                        matrix3 = Matrix.prodMatrix(matrix1, c);
                        outputMatrix(matrix3, "A*B");
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Неверно введёт пункт меню, лиюо такго пункта не существует.");
                        break;

                }
                Console.ReadKey();
            }
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("-------------Меню------------");
            Console.WriteLine("| 1) Ввести матрицу A.       |");
            Console.WriteLine("| 2) Ввести матрицу B.       |");
            Console.WriteLine("| 3) C=A+B                   |");
            Console.WriteLine("| 4) C=A-B                   |");
            Console.WriteLine("| 5) C=A*B                   |");
            Console.WriteLine("| 6) C=A*c, с - число        |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| 7) Выход                   |");
            Console.WriteLine("-----------------------------");
            Console.Write("--> ");
        }

        public static int[,] inputMatrix(string name)
        {
            int m, n;
            string input;
            Console.WriteLine("Введите размер матрицы " + name + " mxn: ");
            input = Console.ReadLine();
            m = Int32.Parse(input.Split()[0]);
            n = Int32.Parse(input.Split()[1]);
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Элемент {i+1},{j+1} -> ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        public static void outputMatrix(int[,] matrix, string name)
        {
            Console.WriteLine("Матрица " + name + ": ");
            for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetUpperBound(1)+1; j++)
                {
                    Console.Write("{0}\t",matrix[i, j]);
                }
                Console.WriteLine("|");
            }
        }
    }
}
