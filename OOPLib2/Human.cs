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
        string name, sername,birhtday;
        static string Name(string name)
        {
            if(name.Length>0)
            {
                return name;
            }
            else
            {
                return "Введено не вiрно";
            }
        }
        static string Sername(string sername)
        {
            if (sername.Length > 0)
            {
                return sername;
            }
            else
            {
                return "Введено не вiрно";
            }
        }
        static string Birhtday(string birhtday)
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
}
