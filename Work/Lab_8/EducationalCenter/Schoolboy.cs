using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public class Schoolboy : Learner
    {
        private int numClass;

        public Schoolboy(string fullname, int bithdayYear, Status status, string nameOfInstitution, int numClass, params int[] marks) : base(fullname, bithdayYear, status, nameOfInstitution, marks)
        {
            NumClass = numClass;
        }

        public int NumClass
        {
            get
            {
                return numClass;
            }
            private set
            {
                if (value > 11) numClass = 11;
                else if (value <= 0) numClass = 1;
                else numClass = value;
            }
        }

        public new string InfoHuman()
        {
            return "ФИО: " + fullname + "\nШкола: " + nameOfInstitution +
                "\nКласс: " + NumClass + "\nСтатус: " + GetStatusName(status) + "\nГод рождения: " + bithdayYear + "\n";
        }
    }
}
