using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringEdit
{
    public class StrEdit
    {
        /// <summary>
        /// Метод возвращает строку с преобразоваными прописными буквами.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static String ConvertLettersUp(String line)
        {
            String[] lines = line.Split(new char[] { '.' });
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].TrimStart();
                Char letter = Char.ToUpper(lines[i].ToCharArray()[0]);
                lines[i] = lines[i].Remove(0, 1);
                lines[i] = letter + lines[i] + '.';
            }
            return String.Join(" ", lines);
        }

        /// <summary>
        /// Метод возвращает строку в котором словестная запись сумыы в долларах 
        /// </summary>
        /// <param name="rub"></param>
        /// <returns></returns>
        public static string ConvertRubToUsd(string rub)
        {
            int exchange = 2;
            int usdNum = 1;
            int usd2Num = 1;
            string usd;

            int i = 0;
            foreach (string strNum in rub.Split()) {
                if (rub.Split().Length > 2)
                {
                    if (i < 2)
                        usdNum = ConvertToNumber(strNum.ToLower(), usdNum);
                    else
                        usd2Num = ConvertToNumber(strNum.ToLower(), usd2Num);
                }
                else
                {
                    usd2Num = 0;
                    usdNum = ConvertToNumber(strNum.ToLower(), usdNum);
                }
                    
                i++;
            }
            usdNum = exchange * (usdNum + usd2Num);
            StringBuilder[] numStringsUsd = new StringBuilder[2];
            numStringsUsd = ConvertToString(usdNum);
            if (usdNum > 100)
                usd = numStringsUsd[1].ToString() + numStringsUsd[0].ToString();
            else
                usd = numStringsUsd[0].ToString();
            return usd;
        }

        /// <summary>
        /// Метод конвертирует целое число (int), в строку 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static StringBuilder[] ConvertToString(int number)
        {
            StringBuilder[] strNums = new StringBuilder[2];

            if (number > 100)
            {
                int tens = number % 100;
                int thousands = number / 100;
                strNums[1] = new StringBuilder(thousands <= 10 ? GetHoundreds(thousands) : GetThousands(thousands));
                strNums[0] = new StringBuilder(tens <= 10 ? GetDigital(tens) : GetTens(tens));
            }
            else
            {
                int tens = number % 100;
                strNums[0] = new StringBuilder(tens <= 10 ? GetDigital(tens) : GetTens(tens));
            }
            
            return strNums;
        }

        /// <summary>
        /// Возвращает сотни числа
        /// </summary>
        /// <param name="houndreds"></param>
        /// <returns></returns>
        private static string GetHoundreds(int houndreds)
        {
            if (houndreds == 0) return null;
            return GetDigital(houndreds) + " hundred ";
        }

        /// <summary>
        /// Возвращает тысячи числа
        /// </summary>
        /// <param name="thousands"></param>
        /// <returns></returns>
        private static string GetThousands(int thousands)
        {
            if (thousands > 100)
            {
                return GetTens(thousands / 10) + " thousand " + GetHoundreds(thousands % 10);
            }
            else
            {
                return GetDigital(thousands / 10) + " thousand " + GetHoundreds(thousands % 10);
            }
        }

        /// <summary>
        /// Возвращает десятки числа
        /// </summary>
        /// <param name="tens"></param>
        /// <returns></returns>
        private static string GetTens(int tens)
        {
            switch (tens)
            {
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 15: return "fifteen";
                case 18: return "eighteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                default:
                    if (tens > 13 && tens < 20 && tens != 15 && tens != 18)
                    {
                        return GetDigital(tens % 10) + "teen";
                    }
                    else if (tens > 20 && tens < 30)
                    {
                        return "twenty " + GetDigital(tens % 10);
                    }
                    else if (tens > 30 && tens < 40)
                    {
                        return "thirty " + GetDigital(tens % 10);
                    }
                    else if (tens > 40 && tens < 50)
                    {
                        return "forty " + GetDigital(tens % 10);
                    }
                    else if (tens > 50 && tens < 60)
                    {
                        return "fifty " + GetDigital(tens % 10);
                    }
                    else if (tens > 60 && tens < 70)
                    {
                        return "sixty " + GetDigital(tens % 10);
                    }
                    else if (tens > 70 && tens < 80)
                    {
                        return "seventy " + GetDigital(tens % 10);
                    }
                    else if (tens > 80 && tens < 90)
                    {
                        return "eighty " + GetDigital(tens % 10);
                    }
                    else if (tens > 90)
                    {
                        return "ninety " + GetDigital(tens % 10);
                    }
                    else
                    {
                        return null;
                    }
            }
        }

        /// <summary>
        /// Выозвращает цифру в словестной записи
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static string GetDigital(int digit)
        {
            switch (digit)
            {
                case 0: return " ";
                case 1: return "one";
                case 2: return "two";
                case 3: return "tree";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                default: return null;
            }
        }

        /// <summary>
        /// Преобразует строку в число
        /// </summary>
        /// <param name="numStr"></param>
        /// <param name="usdNum"></param>
        /// <returns></returns>
        private static int ConvertToNumber(string numStr, int usdNum)
        {
            switch (numStr)
            {
                case "one":
                    usdNum = usdNum > 10 ? usdNum + 1 : usdNum;
                    break;
                case "two":
                    usdNum = usdNum > 10 ? usdNum + 2 : usdNum * 2;
                    break;
                case "three":
                    usdNum = usdNum > 10 ? usdNum + 3 : usdNum * 3;
                    break;
                case "four":
                    usdNum = usdNum > 10 ? usdNum + 4 : usdNum * 4;
                    break;
                case "five":
                    usdNum = usdNum > 10 ? usdNum + 5 : usdNum * 5;
                    break;
                case "six":
                    usdNum = usdNum > 10 ? usdNum + 6 : usdNum * 6;
                    break;
                case "seven":
                    usdNum = usdNum > 10 ? usdNum + 7 : usdNum * 7;
                    break;
                case "eight":
                    usdNum = usdNum > 10 ? usdNum + 8 : usdNum * 8;
                    break;
                case "nine":
                    usdNum = usdNum > 10 ? usdNum + 9 : usdNum * 9;
                    break;
                case "ten":
                    usdNum = usdNum >= 100 ? usdNum + 10 : usdNum * 10;
                    break;
                case "eleven":
                    usdNum = usdNum >= 100 ? usdNum + 11 : usdNum * 11;
                    break;
                case "twelve":
                    usdNum = usdNum >= 100 ? usdNum + 12 : usdNum * 12;
                    break;
                case "thirteen":
                    usdNum = usdNum >= 100 ? usdNum + 13 : usdNum * 13;
                    break;
                case "fourteen":
                    usdNum = usdNum >= 100 ? usdNum + 14 : usdNum * 14;
                    break;
                case "fifteen":
                    usdNum = usdNum >= 100 ? usdNum + 15 : usdNum * 15;
                    break;
                case "sixteen":
                    usdNum = usdNum >= 100 ? usdNum + 16 : usdNum * 16;
                    break;
                case "seventeen":
                    usdNum = usdNum >= 100 ? usdNum + 17 : usdNum * 17;
                    break;
                case "eighteen":
                    usdNum = usdNum >= 100 ? usdNum + 18 : usdNum * 18;
                    break;
                case "nineteen":
                    usdNum = usdNum >= 100 ? usdNum + 19 : usdNum * 19;
                    break;
                case "twenty":
                    usdNum = usdNum >= 100 ? usdNum + 20 : usdNum * 20;
                    break;
                case "thirty":
                    usdNum = usdNum >= 100 ? usdNum + 30 : usdNum * 30;
                    break;
                case "forty":
                    usdNum = usdNum >= 100 ? usdNum + 40 : usdNum * 40;
                    break;
                case "fifty":
                    usdNum = usdNum >= 100 ? usdNum + 50 : usdNum * 50;
                    break;
                case "sixty":
                    usdNum = usdNum >= 100 ? usdNum + 60 : usdNum * 60;
                    break;
                case "seventy":
                    usdNum = usdNum >= 100 ? usdNum + 70 : usdNum * 70;
                    break;
                case "eighty":
                    usdNum = usdNum >= 100 ? usdNum + 80 : usdNum * 80;
                    break;
                case "ninety":
                    usdNum = usdNum >= 100 ? usdNum + 90 : usdNum * 90;
                    break;
                case "hundred":
                    usdNum = usdNum >= 1000 ? usdNum + 100 : usdNum * 100;
                    break;
                case "thousand":
                    usdNum *= 1000;
                    break;
            }
            return usdNum;
        }
    }
}
