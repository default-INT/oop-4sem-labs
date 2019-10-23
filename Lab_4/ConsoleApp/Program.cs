using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringEdit;

namespace ConsoleApp
{
    class Program
    {
        /*
         *     "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "hundred", "thousand",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
                "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
         */
        static void Main(string[] args)
        {
            int k = 0;
            
            while (k != 3)
            {
                Menu();
                string str = null;
                k = Convert.ToInt16(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.Write("Введите предложение: ");
                        str = Console.ReadLine();
                        Console.WriteLine("Исправленное предложение: " + StrEdit.ConvertLettersUp(str));
                        break;
                    case 2:
                        Console.Write("Enter the amount in rubles: ");
                        str = Console.ReadLine();
                        Console.WriteLine("Amount in usd: " + StrEdit.ConvertRubToUsd(str)+" $");
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта!");
                        break;
                }
                Console.ReadKey();
            }
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|            МЕНЮ             |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("| 1. Перевод прописных букв.  |");
            Console.WriteLine("| 2. Перевод рублей в доллары.|");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("| 3. Выход.                   |");
            Console.WriteLine("-------------------------------");
            Console.Write("\nВыберите пункт меню: ");
        }
    }
}
