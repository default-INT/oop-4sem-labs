using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixClassLibrary;

namespace MatrixTestProject
{
    [TestClass]
    public class MatrixTest
    {
        /// <summary>
        /// Слаживает две квадртные матрицы с положительными числами
        /// </summary>
        [TestMethod]
        public void SumMatrix_SqarePositiveMatrix()
        {
            int[,] matrix1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            int[,] matrix2 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            int[,] expected = {
                { 2, 4, 6 },
                { 8, 10, 12 },
                { 14, 16, 18}
            };

            int[,] actual = Matrix.sumMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Слаживает два горизонтальных вектора с положительными числами
        /// </summary>
        [TestMethod]
        public void SumMatrix_Vector1Positive()
        {
            int[,] matrix1 = {
                { 1, 2, 3 }
            };

            int[,] matrix2 = {
                { 1, 2, 3 }
            };

            int[,] expected = {
                { 2, 4, 6 }
            };

            int[,] actual = Matrix.sumMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Слаживает два вертикальных вектора с положительными числами
        /// </summary>
        [TestMethod]
        public void SumMatrix_Vector2Positive()
        {
            int[,] matrix1 = {
                { 1 },
                { 4 },
                { 7 }
            };

            int[,] matrix2 = {
                { 1 },
                { 4 },
                { 7 }
            };

            int[,] expected = {
                { 2 },
                { 8 },
                { 14 }
            };

            int[,] actual = Matrix.sumMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Слаживает две квадратные матрицы с положительными и отрицательными числами
        /// </summary>
        [TestMethod]
        public void SumMatrix_SqarePositiveAndNegativeMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 },
            };

            int[,] matrix2 = {
                { 1, 2, 3 },
                { 4, 5, -6 },
                { 7, 8, 9 },
            };

            int[,] expected = {
                { 2, 0, 6 },
                { 0, 10, -12 },
                { 14, 0, 18}
            };

            int[,] actual = Matrix.sumMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Слаживает две прямоугольные матрицы с положительными и отрицательными числами
        /// </summary>
        [TestMethod]
        public void SumMatrix_RectanglePositiveAndNegativeMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 }
            };

            int[,] matrix2 = {
                { 1, 2, 3 },
                { 4, 5, -6 }
            };

            int[,] expected = {
                { 2, 0, 6 },
                { 0, 10, -12 }
            };

            int[,] actual = Matrix.sumMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Вычитает две прямоугольные матрицы с положительными и отрицательными числами
        /// </summary>
        [TestMethod]
        public void SubMatrix_RectanglePositiveAndNegativeMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 }
            };

            int[,] matrix2 = {
                { 1, 2, 3 },
                { 4, 5, -6 }
            };

            int[,] expected = {
                { 0, -4, 0 },
                { -8, 0, 0 }
            };

            int[,] actual = Matrix.subMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение двух квадратных матриц с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqarePositiveAndNegativeMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 },
            };

            int[,] matrix2 = {
                { 5, 6, 3 },
                { 4, 5, -6 },
                { 7, 2, 0 },
            };

            int[,] expected = {
                { 18, 2, 15 },
                { -42, -11, -42 },
                { 66, 20, 69}
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение квадратной матрицы на прямоугольныю с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqareRectangleMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 },
            };

            int[,] matrix2 = {
                { 5, 6 },
                { 4, 5 },
                { 7, 2 },
            };

            int[,] expected = {
                { 18, 2 },
                { -42, -11 },
                { 66, 20 }
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProdMatrix_RectangleMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 },
                { 17, 5, 0 },
                { 44, 3, 9 },
            };

            int[,] matrix2 = {
                { 5, 6 },
                { 4, 5 },
                { 7, 2 },
            };

            int[,] expected = {
                { 18, 2 },
                { -42, -11 },
                { 66, 20 },
                { 105, 127 },
                { 295, 297 },
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение двух векторов с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_Vector()
        {
            int[,] matrix1 = {
                { 1, -12, 3 }
            };

            int[,] matrix2 = {
                { 9 },
                { 0 },
                { 1 },
            };

            int[,] expected = {
                { 12 }
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение двух векторов с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_VectorReverse()
        {
            int[,] matrix1 = {
                { 9 },
                { 0 },
                { 1 }
            };

            int[,] matrix2 = {
                { 1, -12, 3 }
            };

            int[,] expected = {
                { 9, -108, 27},
                { 0, 0, 0 },
                { 1, -12, 3 }
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение квадратной матрицы на вектор с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqareVectoreMatrix()
        {
            int[,] matrix1 = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 },
            };

            int[,] matrix2 = {
                { 5 },
                { 4 },
                { 7 },
            };

            int[,] expected = {
                { 18 },
                { -42 },
                { 66 }
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение квадратной матрицы на единичную с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqareOneMatrix()
        {
            int[,] matrix1 = {
                { 5, 5, 5 },
                { 5, 5, 5 },
                { 5, 5, 5 },
            };

            int[,] matrix2 = {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 },
            };

            int[,] expected = {
                { 5, 5, 5 },
                { 5, 5, 5 },
                { 5, 5, 5 },
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение квадратной матрицы на единичную с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqareReverseOneMatrix()
        {
            int[,] matrix1 = {
                { 5, 5, 5 },
                { 5, 5, 5 },
                { 5, 5, 5 },
            };

            int[,] matrix2 = {
                { 0, 0, 1 },
                { 0, 1, 0 },
                { 1, 0, 0 },
            };

            int[,] expected = {
                { 5, 5, 5 },
                { 5, 5, 5 },
                { 5, 5, 5 },
            };

            int[,] actual = Matrix.prodMatrix(matrix1, matrix2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод проверяет умножение квадратной матрицы на число с положительными и отрицательнцыми числами
        /// </summary>
        [TestMethod]
        public void ProdMatrix_SqareNumberOneMatrix()
        {
            int[,] matrix1 = {
                { 5, 5, 5 },
                { 5, 5, 5 },
                { 5, 5, 5 },
            };

            int a = 8;

            int[,] expected = {
                { 40, 40, 40 },
                { 40, 40, 40 },
                { 40, 40, 40 },
            };

            int[,] actual = Matrix.prodMatrix(matrix1, a);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}
