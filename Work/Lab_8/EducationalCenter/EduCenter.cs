using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter
{
    public class EduCenter
    {
        public static Status GetStatus(string status)
        {
            status = status.ToLower();
            switch (status)
            {
                case "студент":
                    return Status.Student;
                case "преподаватель":
                    return Status.Teacher;
                case "рабочий":
                    return Status.Working;
                case "бизнесмен":
                    return Status.Businessman;
                case "школьник":
                    return Status.Schoolboy;
                default:
                    return Status.Working;
            }
        }

        public static int[] ParseArr(string marksLine)
        {
            string[] marks = marksLine.Split();
            int[] marksInt = new int[marks.Length];

            for (int i = 0; i < marksInt.Length; i++)
            {
                marksInt[i] = Convert.ToInt32(marks[i]);
            }
            return marksInt;
        }

        public EduCenter(string way)
        {
            Humans = ReadFile(way);
        }

        public EduCenter()
        {
            Humans = new List<Human>();
        }

        public Human[] GetHumans()
        {
            return Humans.ToArray();
        }

        public Learner[] GetLearners()
        {
            List<Learner> learners = new List<Learner>();
            
            foreach (Human human in Humans)
            {
                if (human is Learner) learners.Add(human as Learner);
            }
            learners.Sort();
            return learners.ToArray();
        }

        public string[] GetSchoolName()
        {
            List<string> names = new List<string>();

            foreach (Human human in Humans)
            {
                if (human is Schoolboy)
                {
                    string school = (human as Schoolboy).nameOfInstitution;
                    bool check = false;
                    foreach (string name in names)
                        if (name.ToLower() == school.ToLower())
                        {
                            check = true;
                            break;
                        }
                    if (!check) names.Add(school);
                }
            }
            return names.ToArray();
        }

        public Worker[] GetWorkers()
        {
            List<Worker> workers = new List<Worker>();

            foreach (Human human in Humans)
            {
                if (human is Worker) workers.Add(human as Worker);
            }
            return workers.ToArray();
        }

        public Schoolboy[] GetBadSchoolboys(string schoolName)
        {
            List<Schoolboy> schoolboys = new List<Schoolboy>();
            
            foreach (Human human in Humans)
            {
                if (human is Schoolboy && (human as Schoolboy).AvgMark() < 3 
                    && (human as Schoolboy).nameOfInstitution.ToLower() == schoolName.ToLower()) schoolboys.Add(human as Schoolboy);
            }
            schoolboys.Sort();
            return schoolboys.ToArray();
        }

        public void AddHuman(Human human)
        {
            Humans.Add(human);
        }

        public void DeleteHuman(string fullname)
        {
            for (int i = 0; i < Humans.Count; i++)
            {
                if (Humans[i].fullname == fullname)
                {
                    Humans.RemoveAt(i);
                    break;
                }
            }
        }

        public string[] GetFullnames()
        {
            List<string> fullnames = new List<string>();
            foreach (Human human in Humans)
                fullnames.Add(human.fullname);
            return fullnames.ToArray();
        }

        public Student[] GetGoodStudents()
        {
            List<Student> students = new List<Student>();

            foreach (Human human in Humans)
            {
                if (human is Student && (human as Student).AvgMark() >= 6) students.Add(human as Student);
            }

            return students.ToArray();
        }

        public void ReadToFile(string way)
        {
            Humans = ReadFile(way);
        }

        public void SortHumans()
        {
            Humans.Sort();
        }

        public List<Human> Humans { get; private set; }

        private List<Human> ReadFile(string way)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(way, System.Text.Encoding.Default))
                {
                    List<Human> data = new List<Human>();
                    string line;
                    while (!streamReader.EndOfStream)
                    {
                        byte[] buffer = new byte[256]; 
                        line = streamReader.ReadLine();
                        data.Add(ParseString(line));
                    }
                    return data;
                }
            }
            catch
            {
                return null;
            }    
        }

        private Human ParseString(string line)
        {
            string[] humanStrs = line.Split('|');
            
            string fullname = humanStrs[0];
            int bithdayYear = Convert.ToInt32(humanStrs[1]);
            Status status = GetStatus(humanStrs[2]);
            string nameOfInstitution;

            switch (status)
            {
                case Status.Student:
                    nameOfInstitution = humanStrs[3];
                    string group = humanStrs[4];

                    int n = humanStrs.Length - 5;
                    int[] marks = new int[n];
                    for (int i = 5; i < humanStrs.Length; i++) marks[i - 5] = Convert.ToInt32(humanStrs[i]);
                    return new Student(fullname, bithdayYear, status, nameOfInstitution, group, marks);

                case (Status.Schoolboy):
                    nameOfInstitution = humanStrs[3];
                    int numClass = Convert.ToInt32(humanStrs[4]);

                    n = humanStrs.Length - 5;
                    marks = new int[n];
                    for (int i = 5; i < humanStrs.Length; i++) marks[i - 5] = Convert.ToInt32(humanStrs[i]);
                    return new Schoolboy(fullname, bithdayYear, status, nameOfInstitution, numClass, marks);
                case (Status.Teacher):
                case (Status.Businessman):
                case (Status.Working):
                    string nameOfWork = humanStrs[3];
                    string post = humanStrs[4];

                    n = humanStrs.Length - 5;
                    int[] salary = new int[n];
                    for (int i = 5; i < humanStrs.Length; i++)
                        salary[i - 5] = Convert.ToInt32(humanStrs[i]);
                    return new Worker(fullname, bithdayYear, status, nameOfWork, post, salary);
                default:
                    return null;
            }

        }
    }
}
