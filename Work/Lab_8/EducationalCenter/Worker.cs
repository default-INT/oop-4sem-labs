using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public class Worker : Human
    {
        public string PlaceOfWork { get; set; }
        public string Post { get; set; }
        private int[] salary;

        public Worker(string fullname, int bithdayYear, Status status, 
            string placeOfWork, string post, params int[] salary) : base(fullname, bithdayYear, status)
        {
            PlaceOfWork = placeOfWork;
            Post = post;
            Salary = salary;
        }

        public int[] Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value.Length > 12)
                {
                    for (int i = value.Length - 12; i <= value.Length; i++) salary[i] = value[i];
                }
                else salary = value;
            }
        }

        public override string Info()
        {
            return "Максимальная зарплата за 12 месяцев равна " + salary.Max();
        }

        public override string ToString()
        {
            return "ФИО: " + fullname + "\nГод рождения: " + bithdayYear + "\n" +
                "Место работы: " + PlaceOfWork + "\nДолжность: " + Post + "\nМакс. зарплата: " + salary.Max();
        }
    }
}
