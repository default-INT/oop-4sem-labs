using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseStringLib;

namespace ParseStringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder[] example = new StringBuilder[]
            {
                new StringBuilder("ФИО: Трофимов Евгений Владимирович | адрес: пер.Заслонова,12 | evgen.trofimov.2000@gmail.com | 375-29-817-47-53"),
                new StringBuilder("ФИО: Ропот Игорь Владимирович | адрес: ул.Интернациональная,2,12 | rognarek@mail.ru | 375-29-517-84-21"),
                new StringBuilder("ФИО: Липский Данил Сергеевич | адрес: ул.Полесская,4 | lipa2000@gmail.ru | 375-33-317-14-51"),
                new StringBuilder("ФИО: Стольный Семён Данилович | адрес: ул.Гастело,12 | sema666@gmail.ru | 375-44-315-74-25"),
                new StringBuilder("адрес: ул.Интернациональная,4,21 | stolny666@gmail.ru | 375-33-315-74-17 | ФИО: Стольный Сергей Витальевич "),
            };
            StringBuilder[] dataClient;

            Console.WriteLine("Выберете способ чтения данных:");
            Console.WriteLine("1.) Прочитать данные из примера.");
            Console.Write("2.) Ввести данные вручную.\n-> ");
            if (Convert.ToInt16(Console.ReadLine()) == 2)
            {
                dataClient = InputData();
            }
            else
            {
                dataClient = example;
            }
            int k = 0;
            while (k != 4)
            {
                Menu();
                k = Convert.ToInt16(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        OutputData(ParseStr.GetArrayEmail(ref dataClient));
                        break;
                    case 2:
                        OutputData(ParseStr.GetArrayPhoneNumber(ref dataClient));
                        break;
                    case 3:
                        OutputData(ParseStr.GetArrayIndification(ref dataClient));
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта!");
                        break;
                }
                Console.ReadKey();
            }

        }

        private static void OutputData(StringBuilder[] data)
        {
            foreach(StringBuilder str in data)
            {
                Console.WriteLine(str);
            }
        }

        private static StringBuilder[] InputData()
        {
            Console.WriteLine("Введите количество клиентов: ");
            int k = Convert.ToInt32(Console.ReadLine());
            StringBuilder[] clientData = new StringBuilder[k];
            string inputStr = null;

            int i = 0;
            while (i < clientData.Length && !String.Equals(inputStr, "Выход"))
            {
                Console.WriteLine($"Введите строку с данными о клиенте {i+1}: ");
                inputStr = Console.ReadLine();
                if (!String.Equals(inputStr, "Выход"))
                {
                    clientData[i] = new StringBuilder(inputStr);
                }
                i++;
            }
            return clientData;
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|                    МЕНЮ                    |");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| 1.) Вывести электронные почты клиетов.     |");
            Console.WriteLine("| 2.) Вывести телефоные номера клиетов.      |");
            Console.WriteLine("| 3.) Вывести персональные данные клиентов.  |");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| 4.) ВЫХОД                                  |");
            Console.WriteLine("----------------------------------------------");
            Console.Write("-> ");
        }
    }
}
