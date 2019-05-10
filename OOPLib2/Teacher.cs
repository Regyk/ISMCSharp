using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Teacher : Human
    {
        private string position, cafedra, instOfHigherEd;
        public Teacher()
        {
            position = "NO POSITION";
            cafedra = "NO CAFEDRA";
            instOfHigherEd = "NO EDUCATIONAL";
        }
        public Teacher(string name, string sername, string birhtday, string group, string faculty, string instOfHigherEd) : base(name, sername, birhtday)
        {
            Position = position;
            Cafedra = cafedra;
            InstOfHigherEd = instOfHigherEd;
        }
        public Teacher(Teacher obj)
        {
            name = obj.name;
            sername = obj.sername;
            birhtday = obj.birhtday;
            position = obj.position;
            cafedra = obj.cafedra;
            instOfHigherEd = obj.instOfHigherEd;
        }
        protected string Position
        {
            set
            {
                position = value;
            }
            get
            {
                if (position.Length > 0)
                {
                    return position;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
        }
        protected string Cafedra
        {
            set
            {
                cafedra = value;
            }
            get
            {
                if (position.Length > 0)
                {
                    return cafedra;
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
                + "Посада: " + position + "\n"
                + "Кафедра: " + cafedra + "\n"
                + "Hазва вищого навчального закладу: " + instOfHigherEd);
        }
    }
}
