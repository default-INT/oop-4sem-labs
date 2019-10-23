using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassLibrary
{
    public class MyArray
    {
        /// <summary>
        /// Метод возвращающий максимальный элемент массива array
        /// </summary>
        /// <param name="array">Целочисленный массив</param>
        /// <returns></returns>
        public static int maxElement(MyArray array)
        {
            return array.maxElement();
        }

        /// <summary>
        /// Метод возвращающий максимальный элемент части массива array от n до k
        /// </summary>
        /// <param name="array">Экземпляр класса array</param>
        /// <param name="n">Начальный индекс</param>
        /// <param name="k">Конечный индекс</param>
        /// <returns></returns>
        public static int maxElement(MyArray array, int n, int k)
        {
            return array.maxElement(n, k);
        }

        /// <summary>
        /// Метод возвращает скалярное произведение двух массивов array1 и array2
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static int ScalarProd(MyArray array1, MyArray array2)
        {
            int scalarProd = 0;
            if (array1.Length() == array2.Length())
            {
                int len = array1.Length();
                for (int i = 0; i < len; i++)
                {
                    scalarProd += array1[i] * array2[i];
                }
                return scalarProd;
            }
            else
            {
                throw new Exception("Длинна массивов не совпадает");
            }
        }

        /// <summary>
        /// Метод возвращает true, если array1 больше array2, иначе возвращает false
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static bool ArrayMore(MyArray array1, MyArray array2)
        {
            if (array1.Length() > array2.Length())
            {
                return true;
            }else if(array1.Length() == array2.Length())
            {
                int k1 = 0;
                int k2 = 0;
                for (int i = 0; i < array1.Length(); i++)
                {
                    k1 = array1[i] > 0 ? k1 + 1 : k1;
                    k2 = array2[i] > 0 ? k2 + 1 : k2;
                }
                return k1 > k2 ? true : false;
            }
            else
            {
                return false;
            }
        }

        private int[] array { get; set; }

        /// <summary>
        /// Конструктор класса Array
        /// </summary>
        /// <param name="parametrs"></param>
        public MyArray(params int[] parametrs)
        {
            this.array = new int[parametrs.Length];
            for (int i = 0; i < parametrs.Length; i++)
            {
                this.array[i] = parametrs[i];
            }
        }

        /// <summary>
        /// Индексатор класса Array
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            set
            {
                array[index] = value;
            }

            get
            {
                return array[index];
            }
        }

        /// <summary>
        /// Метод возвращает длину массива
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            int n = 0;
            foreach(int elements in array)
            {
                n++;
            }
            return n;
        }

        /// <summary>
        /// Метод возвращает максимальный элемент массива
        /// </summary>
        /// <returns></returns>
        public int maxElement()
        {
            int max = array[0];
            foreach(int element in array)
            {
                max = element > max ? element : max;
            }
            return max;
        }

        /// <summary>
        /// Метод возвращает максимальный элемент массива от n до k
        /// </summary>
        /// <param name="n">Начальный индекс</param>
        /// <param name="k">Конечный индекс</param>
        /// <returns></returns>
        public int maxElement(int n, int k)
        {
            int max = array[n];
            for (int i = n; i < k+1; i++)
            {
                max = max < array[i] ? array[i] : max;
            }
            return max;
        }

        /// <summary>
        /// Метод возвращает максимальный элемент массива
        /// </summary>
        /// <returns></returns>
        public int minElement()
        {
            int min = array[0];
            foreach (int element in array)
            {
                min = element < min ? element : min;
            }
            return min;
        }
    }
}
