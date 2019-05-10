using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OOPLib2
{
    public class Abiturient : Human
    {
        private string genEducationalInst;
        private int zno, gpa;
        public Abiturient()
        {
            zno = 100;
            gpa = 0;
            genEducationalInst = "NO EDUCATIONAL";
        }
        public Abiturient(string name, string sername, string birhtday, int zno, int gpa, string genEducationalInst):base(name,sername,birhtday)
        {
            ZNO = zno;
            GPA = gpa;
            GenEducationalInst = genEducationalInst;
        }
        public Abiturient(Abiturient obj)
        {
            name = obj.name;
            sername = obj.sername;
            birhtday = obj.birhtday;
            zno = obj.zno;
            gpa = obj.gpa;
            genEducationalInst = obj.genEducationalInst;
        }
        protected int ZNO
            {
            set
            {
                zno = value;
            }
            get
            {
                if (zno > 100 && zno<200)
                {
                    return zno;
                }
                else
                {
                    return 100;
                }
            }
            }
        protected int GPA
        {
            set
            {
                gpa = value;
            }
            get
            {
                if (gpa > 0 && gpa < 13)
                {
                    return gpa;
                }
                else
                {
                    return 0;
                }
            }
        }
        protected string GenEducationalInst
        {
            set
            {
                genEducationalInst = value;
            }
            get
            {
                if(genEducationalInst.Length>0)
                {
                    return genEducationalInst;
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
                + "ЗНО: " + zno + "\n"
                + "Kiлькість балiв за документ про освiту: " + gpa + "\n"
                + "Hазва загальноосвiтнього навчального закладу: " + genEducationalInst);
        }
    }
}
