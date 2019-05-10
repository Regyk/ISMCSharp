using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OOPLib2
{
    public class Human
    {
        protected string name, sername, birhtday;
        public Human()
        {
            name = "NO NAME";
            sername = "NO SERNAME";
            birhtday = "00-00-0000";
        }
        public Human(string name, string sername, string birhtday)
        {
            Name = name;
            Sername = sername;
            Birhtday = birhtday;
        }
        public Human(Human obj)
        {
            name = obj.name;
            sername = obj.sername;
            birhtday = obj.birhtday;
        }
        protected string Name
        {
            set
            {
                name = value;
            }
            get
            {
                if (name.Length > 0)
                {
                    return name;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
           
        }
        protected string Sername
        {
            set
            {
                sername = value;
            }
            get  
            {
                if(sername.Length>0)
                {
                    return sername;
                }
                else
                {
                    return "Введено не вiрно"; 
                }
            }
        }
        protected string Birhtday
        {
            set
            {
                birhtday = value;

            }
            get
            {
                string dateCheck = @"\d{2}.\d{2}.\d{4}";
                if (Regex.IsMatch(birhtday, dateCheck, RegexOptions.IgnoreCase))
                {
                    return birhtday;
                }
                else
                {
                    return "Введено не вiрно";
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Iм’я: " + Name + "\n" +
                "Прiзвище: " + Sername + "\n" +
                "День нродження: " + Birhtday);
        }
    }
}
