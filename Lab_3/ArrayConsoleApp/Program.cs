using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayClassLibrary;

namespace ArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            MyArray array1 = null;
            MyArray array2 = null;
            while (k != 8)
            {
                menu();
                k = Int32.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        array1 = new MyArray(InputStringToInt('A'));
                        outputArray(array1, 'A');
                        break;
                    case 2:
                        array2 = new MyArray(InputStringToInt('B'));
                        outputArray(array2, 'B');
                        break;
                    case 3:
                        outputArray(array1, 'A');
                        Console.WriteLine("Максимальный элемент 1-го массива "+array1.maxElement());                       
                        break;
                    case 4:
                        if (array2 != null)
                        {
                            outputArray(array2, 'B');
                            Console.Write("Введите индекс конечного элемента: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Максимальный элемент 2-го массива " + array2.maxElement(2, k));
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели массив.");
                        }
                        break;
                    case 5:
                        if (array2 != null && array1 != null)
                        {
                            outputArray(array1, 'A');
                            outputArray(array2, 'B');
                            if (array1.Length() != array2.Length())
                                Console.WriteLine("Эти массивы нельзя скалярно умножить.");
                            else
                                Console.Write("Скалярное произведение равно " + MyArray.ScalarProd(array1, array2));
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели массив.");
                        }
                        break;
                    case 6:
                        if (array2 != null && array1 != null)
                        {
                            outputArray(array1, 'A');
                            outputArray(array2, 'B');
                            if (MyArray.ArrayMore(array1, array2))
                                Console.WriteLine("Массива A больше массива B.");
                            else
                                Console.WriteLine("Массива B больше массива A, либо они равны.");
                        }
                        else
                            Console.WriteLine("Вы не ввели массив.");
                        break;
                    case 7:
                        if (array2 != null && array1 != null)
                        {
                            outputArray(array1, 'A');
                            outputArray(array2, 'B');
                            if (MyArray.ArrayMore(array1, array2))
                            {
                                int max = array1.maxElement();
                                int min = array2.minElement();
                                for (int i = 0; i < array1.Length(); i++)
                                {
                                    if (max == array1[i])
                                    {
                                        for (int j = i+1; j < array1.Length(); j++)
                                            array1[j] = min;
                                        break;
                                    }
                                }
                                outputArray(array1, 'A');
                            }
                            else
                                Console.WriteLine("Массива B больше массива A, либо они равны.");
                        }
                        else
                            Console.WriteLine("Вы не ввели массив.");
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта меню.");
                        break;
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Ввод массива
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static int[] InputStringToInt(Char Name)
        {
            Console.WriteLine("Введите элементы массива "+Name+":");
            String[] input = Console.ReadLine().Split();
            int[] num = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                num[i] = Convert.ToInt32(input[i]);
            }
            return num;
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="Name"></param>
        public static void outputArray(MyArray array, char Name)
        {
            if (array != null)
            {
                Console.Write("Массив " + Name + " = [ ");
                for (int i = 0; i < array.Length(); i++)
                {
                    if (i < array.Length() - 1)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(array[i] + "]");
                    }
                }
            }
            else
                Console.WriteLine("Массив " + Name + " пустой");
            
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("-------------Меню------------");
            Console.WriteLine("| 1) Ввести 1-ый массив A.   |");
            Console.WriteLine("| 2) Ввести 2-ой массив B.   |");
            Console.WriteLine("| 3) Поиск макс. элемента в  |");
            Console.WriteLine("|первом массиве.             |");
            Console.WriteLine("| 4) Поиск макс. элемента в  |");
            Console.WriteLine("|части 2-го массива с 3-го по|");
            Console.WriteLine("|элемент с заданным номером. |");
            Console.WriteLine("| 5) Скалярное произведение. |");
            Console.WriteLine("| 6) Сравнение массивов.     |");
            Console.WriteLine("| 7) Сравнение с изменением. |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| 8) Выход                   |");
            Console.WriteLine("-----------------------------");
            Console.Write("--> ");
        }
    }
}
