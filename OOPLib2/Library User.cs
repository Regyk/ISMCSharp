using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OOPLib2
{
    public class Library_User:Human
    {
        private string dateOfIssue;
        private int numReaderTicket, contribution;
        public Library_User()
        {
            numReaderTicket = 1;
            contribution = 0;
            dateOfIssue = ("2019,05,10");
        }
        public Library_User(string name, string sername, string birhtday, string dateOfIssue, int numReaderTicket, int contribution) : base(name, sername, birhtday)
        {
            DateOfIssue(dateOfIssue);
            NumReaderTicket = numReaderTicket;
            Contribution = contribution;
        }
        public Library_User(Library_User obj)
        {
            name = obj.name;
            sername = obj.sername;
            birhtday = obj.birhtday;
            numReaderTicket = obj.numReaderTicket;
            contribution = obj.contribution;
            dateOfIssue = obj.dateOfIssue;
        }
        protected int NumReaderTicket
        {
            set
            {
                numReaderTicket = value;
            }
            get
            {
                if (numReaderTicket > 100 && numReaderTicket < 200)
                {
                    return numReaderTicket;
                }
                else
                {
                    return 100;
                }
            }
        }
        protected int Contribution
        {
            set
            {
                contribution = value;
            }
            get
            {
                if (contribution > 0 && contribution < 13)
                {
                    return contribution;
                }
                else
                {
                    return 0;
                }
            }
        }
        protected string DateOfIssue(string date)
        {
            string dateCheck = @"\d{2}-\d{2}-\d{4}";
            if (Regex.IsMatch(date, dateCheck, RegexOptions.IgnoreCase))
            {
                dateOfIssue = date;
                return dateOfIssue;
            }
            else
            {
                Console.WriteLine("Дату введено не вiрно!");
                dateOfIssue = ("0000, 00, 00");
                return dateOfIssue;
            }
        }
        public new void ShowInfo()
        {
            Console.WriteLine("Iм’я: " + Name + "\n"
                + "Прiзвище: " + Sername + "\n"
                + "День нродження: " + Birhtday + "\n"
                + "Дата реєстрацiї: " + dateOfIssue + "\n"
                + "Номер читацького квитка: " + numReaderTicket + "\n"
                + "Сума щомiсячного внеску: " + contribution);
        }
    }
}
