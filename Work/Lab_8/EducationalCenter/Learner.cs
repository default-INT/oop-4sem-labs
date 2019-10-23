using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public class Learner : Human, IComparable
    {
        public Learner(string fullname, int bithdayYear, Status status, 
            string nameOfInstitution, params int[] marks) : base(fullname, bithdayYear, status)
        {
            this.nameOfInstitution = nameOfInstitution;
            this.marks = marks;
        }

        public string nameOfInstitution { get; private set; }
        public int[] marks { get; private set; }

        
        public double AvgMark()
        {
            double S = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                S += marks[i];
            }

            return S / marks.Length;
        }

        public override string Info()
        {
            
            return "Средний бал равен " + AvgMark();
        }

        public override string ToString()
        {
            return "ФИО: " + fullname + "\nГод рождения: " + bithdayYear + "\nСтатус: " +
                GetStatusName(status) + "\nУчебное заведение: " + nameOfInstitution + "\nСред. балл: " + Math.Round(AvgMark(), 2);
        }
    }
}
