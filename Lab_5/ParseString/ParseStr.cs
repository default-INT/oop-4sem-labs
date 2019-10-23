using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseStringLib
{
    public class ParseStr
    {
        /// <summary>
        /// Метод возвращает массив типа StringBulder электронных почт полученых парсингом строк массива clientsInfo
        /// </summary>
        /// <param name="clientsInfo"></param>
        /// <returns></returns>
        public static StringBuilder[] GetArrayEmail(ref StringBuilder[] clientsInfo)
        {
            StringBuilder[] emails = new StringBuilder[clientsInfo.Length];

            for (int i = 0; i < clientsInfo.Length; i++)
            {
                emails[i] = GetEmail(clientsInfo[i]);
            }
            return emails;
        }

        /// <summary>
        /// Метод возвращает массив типа StringBulder персональных данных полученых парсингом строк массива clientsInfo
        /// </summary>
        /// <param name="clientsInfo"></param>
        /// <returns></returns>
        public static StringBuilder[] GetArrayIndification(ref StringBuilder[] clientsInfo)
        {
            StringBuilder[] indification = new StringBuilder[clientsInfo.Length];

            for (int i = 0; i < clientsInfo.Length; i++)
            {
                indification[i] = new StringBuilder((i + 1).ToString() + ": " + GetFullName(clientsInfo[i]) + " " + GetAdress(clientsInfo[i]));
            }
            return indification;
        }

        /// <summary>
        /// Метод возвращает массив типа StringBulder телефонных номеров полученых парсингом строк массива clientsInfo
        /// </summary>
        /// <param name="clientsInfo"></param>
        /// <returns></returns>
        public static StringBuilder[] GetArrayPhoneNumber(ref StringBuilder[] clientsInfo)
        {
            StringBuilder[] phoneNumbers = new StringBuilder[clientsInfo.Length];

            for (int i = 0; i < clientsInfo.Length; i++)
            {
                phoneNumbers[i] = GetPhoneNumber(clientsInfo[i]);
            }
            return phoneNumbers;
        }

        /// <summary>
        /// Ищет в строке электронную почту
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static StringBuilder GetEmail(StringBuilder str)
        {
            Regex regEmail = new Regex(@"\S*mail\S*");
            Match match = regEmail.Match(str.ToString());
            return new StringBuilder(match.Value);
        }

        /// <summary>
        /// Ищет в строе ФИО
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static StringBuilder GetFullName(StringBuilder str) //Example: Full name: dsdsf fdf fdf 
        {
            Regex regFullName = new Regex(@"ФИО:\s*\w*\s*\w*\s*\w*");
            Match match = regFullName.Match(str.ToString());
            return new StringBuilder(match.Value.Split()[1] + " " + match.Value.Split()[2] + " " + match.Value.Split()[3]);
        }

        /// <summary>
        /// Метод ищет и возврашатет со строки домашний адресс
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static StringBuilder GetAdress(StringBuilder str) //Example: Адрес: пер.Заслонова,12 
        {
            Regex regAdress = new Regex(@"адрес:\s*\S*");
            Match match = regAdress.Match(str.ToString());
            return new StringBuilder(match.Value.Split()[1]);
        }

        /// <summary>
        /// Метод ищет и возврашатет со строки номер телефона
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static StringBuilder GetPhoneNumber(StringBuilder str)
        {
            Regex regNumber = new Regex("[0-9]{3}-[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}");
            Match match = regNumber.Match(str.ToString());
            return new StringBuilder(match.Value);
        }
    }
}
