using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OOPLib1
{
    public class Date
    {
        
        protected int year, month, day, hours, minutes;
        public string timeToProcesed;
        public Date()
        {
            year = 0;
            month = 0;
            day = 0;
            hours = 0;
            minutes = 0;
        }
        public Date(string date)
        {
            string dateCheck = @"\d{2}:\d{2}\s\d{4}-\d{2}-\d{2}";
            if (Regex.IsMatch(date, dateCheck, RegexOptions.IgnoreCase))
            {
                String[] split = date.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] res = new int[split.Length];
                for (int i=0;i<split.Length;i++)
                {
                    Int32.TryParse(split[i], out res[i]);
                }
                Hours = res[0];
                Minutes = res[1];
                Year = res[2];
                Month = res[3];
                Day = res[4];
                TimeToProcesed();
            }
            else
            {
                Console.WriteLine("Дату введено не вiрно!");
            }

        }
        public Date (Date obj)
        {
            year = obj.year;
            month = obj.month;
            day = obj.day;
            hours = obj.hours;
            minutes = obj.minutes;
            timeToProcesed = obj.timeToProcesed;
        }
        //public void TimeSet(int year, int month, int day, int hours, int minutes)
        //{
        //    Year = year;
        //    Month = month;
        //    Day = day;
        //    Hours = hours;
        //    Minutes = minutes;
        //}
        protected int Year
        {
            set
            {
                    if (value >= 2000 && value <= 2050)
                    {
                        year = value;
                    }
                    else
                    {
                         Console.WriteLine("Рiк введено не вiрно, спробуйте знову");
                    }
            }
            get { return year; }
        }
        protected int Month
        {
            set
            {
                    if (value > 0 && value < 13)
                    {  
                            month = value;
                    }
                    else
                        Console.WriteLine("Мiсяць введено не вiрно, спробуйте знову");
            }
            get
            {
                return month;
            }
        }
        protected int Day
        {
            set
            {
                int daysInMonth = System.DateTime.DaysInMonth(year, month);
                if (value > 0 && value <= daysInMonth)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("День введено не вiрно, спробуйте знову");
                }
            }
            get { return day; }
        }
        protected int Hours
        {
            set
            {
                    if (value > -1 && value < 25)
                    {
                        hours = value;
                    }
                    else
                        Console.WriteLine("Години введено не вiрно, спробуйте знову");
            }
            get { return hours; }
        }
        protected int Minutes
        {
            set
            {
                    if (value > -1 && value < 61)
                    {
                        minutes = value;
                    }
                    else
                        Console.WriteLine("Хвилини введено не вiрно, спробуйте знову");
            }
            get { return minutes; }
        }
        public DateTime TimeToProcesed()
        {
            DateTime timeToProcesed = new DateTime(year, month, day, hours, minutes, 0);
            return timeToProcesed;
        }
    }
}
