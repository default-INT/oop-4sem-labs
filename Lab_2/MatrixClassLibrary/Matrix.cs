using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClassLibrary
{
    public class Matrix
    {
        /// <summary>
        /// Метод возвращает сумму двух матриц matrix1 и matrix2 (должны совпадать строки и столбы обеих матриц)
        /// </summary>
        /// <param name="matrix1">1-ая матрица</param>
        /// <param name="matrix2">2-ая матрица</param>
        /// <returns></returns>
        public static int[,] sumMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.GetUpperBound(1) + 1;

            int[,] newMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i,j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Метод возвращает разность матриц matrix1 и matrix2 (должны совпадать строки и столбы обеих матриц)
        /// </summary>
        /// <param name="matrix1">1-ая матрица</param>
        /// <param name="matrix2">2-ая матрица</param>
        /// <returns></returns>
        public static int[,] subMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.GetUpperBound(1) + 1;

            int[,] newMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Возвращает произведение матриц matrix1 и matrix2 (должны совпадать количество строк 1-ой матрицы и столбцов 2-ой матриц)
        /// </summary>
        /// <param name="matrix1">1-ая матрица</param>
        /// <param name="matrix2">2-ая матрица</param>
        /// <returns></returns>
        public static int[,] prodMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] newMatrix = new int[matrix1.GetUpperBound(0) + 1,matrix2.GetUpperBound(1) + 1];
            for (int i = 0; i < newMatrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < newMatrix.GetUpperBound(1) + 1; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix2.GetUpperBound(0) + 1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    newMatrix[i, j] = sum;
                }
            }
            return newMatrix;
        }

        /// <summary>
        /// Метод умножение матрицы на число
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[,] prodMatrix(int[,] matrix1, int a)
        {
            int[,] newMatrix = new int[matrix1.GetUpperBound(0) + 1, matrix1.GetUpperBound(1) + 1];
            for (int i = 0; i < newMatrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < newMatrix.GetUpperBound(1) + 1; j++)
                {
                    newMatrix[i, j] = matrix1[i,j] * a;
                }
            }
            return newMatrix;
        }
    }
}
