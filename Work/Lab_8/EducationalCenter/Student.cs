using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public class Student : Learner
    {
        public Student(string fullname, int bithdayYear, Status status, string nameOfInstitution,
            string group, params int[] marks) : base(fullname, bithdayYear, status, nameOfInstitution, marks)
        {
            Group = group;
        }

        public string Group { get; set; }

        public new string InfoHuman()
        {
            return "ФИО: " + fullname + "\nВУЗ: " + nameOfInstitution +
                "\nГруппа: " + Group + "\nСтатус: " + GetStatusName(status) + "\nГод рождения: " + bithdayYear + "\n";
        }
    }
}
