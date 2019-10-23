using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public enum Status
    {
        Student,
        Teacher,
        Businessman,
        Working,
        Schoolboy
    }

    public abstract class Human : IComparable
    {
        public string fullname;
        public int bithdayYear;
        public Status status;

        protected Human(string fullname, int bithdayYear, Status status)
        {
            this.fullname = fullname;
            this.bithdayYear = bithdayYear;
            this.status = status;
        }

        public abstract string Info();

        public string InfoHuman()
        {
            return fullname + " | " + GetStatusName(status) + " | " + bithdayYear;
        }

        public int CompareTo(object obj)
        {
            Human learner = obj as Human;
            if (learner != null) return this.fullname.CompareTo(learner.fullname);
            else throw new Exception("Невозможно сравнить два объек");
        }

        public string GetStatusName(Status status)
        {
            switch (status)
            {
                case Status.Student:
                    return "студент";
                case Status.Teacher:
                    return "преподаватель";
                case Status.Businessman:
                    return "бизнесмен";
                case Status.Working:
                    return "рабочий";
                case Status.Schoolboy:
                    return "школьник";
                default:
                    return null;
            }
        }
    }
}
