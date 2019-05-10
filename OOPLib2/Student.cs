using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Student : Human
    {
        private string instOfHigherEd, group, faculty;
        private int course;
        public Student()
        {
            course = 1;
            group = "NO GROUP";
            faculty = "NO FACULTY";
            instOfHigherEd = "NO EDUCATIONAL";
        }
        public Student(string name, string sername, string birhtday, int course, string group, string faculty, string instOfHigherEd) : base(name, sername, birhtday)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            InstOfHigherEd = instOfHigherEd;
        }
        public Student(Student obj)
        {
            name = obj.name;
            sername = obj.sername;
            birhtday = obj.birhtday;
            course = obj.course;
            group = obj.group;
            faculty = obj.faculty;
            instOfHigherEd = obj.instOfHigherEd;
        }
        protected int Course
        {
            set
            {
                course = value;
            }
            get
            {
                if (course > 0 && course < 6)
                {
                    return course;
                }
                else
                {
                    return 1;
                }
            }
        }
        protected string Group
        {
            set
            {
                group = value;
            }
            get
            {
                if (group.Length>0)
                {
                    return group;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
        }
        protected string Faculty
        {
            set
            {
                faculty = value;
            }
            get
            {
                if (group.Length > 0)
                {
                    return faculty;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
        }
        protected string InstOfHigherEd
        {
            set
            {
                instOfHigherEd = value;
            }
            get
            {
                if (instOfHigherEd.Length > 0)
                {
                    return instOfHigherEd;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
        }
        public new void ShowInfo()
        {
            Console.WriteLine("Iм’я: " + Name + "\n"
                + "Прiзвище: " + Sername + "\n"
                + "День нродження: " + Birhtday + "\n"
                + "Курс: " + course + "\n"
                + "Група: " + group + "\n"
                + "Факультет: " + faculty + "\n"
                + "Hазва вищого навчального закладу: " + instOfHigherEd);
        }
    }
}
