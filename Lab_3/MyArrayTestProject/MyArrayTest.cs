using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayClassLibrary;

namespace MyArrayTestProject
{
    [TestClass]
    public class MyArrayTest
    {
        /// <summary>
        /// Проверяет метод возвращающий длину массива
        /// </summary>
        [TestMethod]
        public void LengthTest()
        {
            MyArray array = new MyArray(1, 2, 3, 4, 5, 6);
            int expected = 6;
            Assert.AreEqual(expected, array.Length());
        }

        /// <summary>
        /// Проверяет индексацию
        /// </summary>
        [TestMethod]
        public void IndexTest()
        {
            MyArray array = new MyArray(1, 2, 3, 4, 5, 6);
            int expected = 2;
            Assert.AreEqual(expected, array[1]);
        }

        /// <summary>
        /// Проверяет метод возвращающий максимальный элемент массива
        /// </summary>
        [TestMethod]
        public void MaxElementTest()
        {
            MyArray array = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5, 8, 7);
            int expected = 9;
            int actual = array.maxElement();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод возвращающий максимальный элемент массива
        /// </summary>
        [TestMethod]
        public void MaxElementStaticTest()
        {
            MyArray array = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5, 8, 7);
            int expected = 9;
            int actual = MyArray.maxElement(array);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет метод возвращающий максимальный элемент в части массива 
        /// </summary>
        [TestMethod]
        public void MaxElementPartTest()
        {
            MyArray array = new MyArray(-5, 8, 7, 6, 5, 6, 8, 9, 5, 5, 8, 7);
            int expected = 8;
            int actual = array.maxElement(2, 6);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод возвращающий максимальный элемент в части массива 
        /// </summary>
        [TestMethod]
        public void MaxElementPartStaticTest()
        {
            MyArray array = new MyArray(-5, 8, 7, 6, 5, 6, 8, 9, 5, 5, 8, 7);
            int expected = 8;
            int actual = MyArray.maxElement(array, 2, 6);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод сравнивания массивов
        /// </summary>
        [TestMethod]
        public void ArrayMoreTest_Array1MoreArray2NegPos()
        {
            MyArray array1 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5, 8, 7);
            MyArray array2 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, -5, 8, 7);
            bool expected = true;
            bool actual = MyArray.ArrayMore(array1, array2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод сравнивания массивов
        /// </summary>
        [TestMethod]
        public void ArrayMoreTest_Array1MoreArray2Len()
        {
            MyArray array1 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5, 8, 7);
            MyArray array2 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5);
            bool expected = true;
            bool actual = MyArray.ArrayMore(array1, array2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод сравнивания массивов
        /// </summary>
        [TestMethod]
        public void ArrayMoreTest_Array1LessArray2()
        {
            MyArray array1 = new MyArray(-5, 8, 7, 6, 9, 5, 5, 8, 7);
            MyArray array2 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5);
            bool expected = false;
            bool actual = MyArray.ArrayMore(array1, array2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет статический метод сравнивания массивов
        /// </summary>
        [TestMethod]
        public void ArrayMoreTest_Array1EquallyArray2()
        {
            MyArray array1 = new MyArray(-5, 8, 7, 6, 9, 5, 5, 8, 7, 5);
            MyArray array2 = new MyArray(-5, 8, 7, 6, 5, 9, 8, 9, 5, 5);
            bool expected = false;
            bool actual = MyArray.ArrayMore(array1, array2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверяет метод возвращающий скалярное произведение векторов (массивов)
        /// </summary>
        [TestMethod]
        public void SclarProdTest()
        {
            MyArray array1 = new MyArray(-5, 8, 7);
            MyArray array2 = new MyArray(3, 5, 7);
            int expected = 74;
            int actual = MyArray.ScalarProd(array1, array2);
            Assert.AreEqual(expected, actual);
        }
    }
}
