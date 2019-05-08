using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib1
{
    public class Airplane
    {
        private string startDateToString, finishDateToString, starCity, finishCity;
        public Date startDate, finishDate;
        public Airplane()
        {
            startDateToString = "00:00 0000-00-00";
            finishDateToString = "00:00 0000-00-00";
            starCity = "Незадано";
            finishCity = "Незадано";
        }
        public Airplane(Airplane obj)
        {
            startDateToString = obj.startDateToString;
            finishDateToString = obj.finishDateToString;
            starCity = obj.starCity;
            finishCity = obj.finishCity;
        }
        public Airplane(string StarCity,string StartDate,string FinishCity,string FinishDate)
        {
            starCity = StarCity;
            startDate = new Date(StartDate);
            startDateToString = Convert.ToString(startDate.TimeToProcesed());
            finishCity = FinishCity;
            finishDate = new Date(FinishDate);
            finishDateToString =Convert.ToString(finishDate.TimeToProcesed());
        }
        public void ShowFlights()
        {
        Console.WriteLine(starCity
        + " - " + finishCity
        + "\n" + startDateToString
        + " - " + finishDateToString);
        }
        //public string StartDate
        //{
        //    set
        //    {
        //        Date date = new Date(value);
        //        DateTime startDate = date.TimeToProcesed();
        //        startDateToString = Convert.ToString(startDate);
        //    }
        //    get
        //    {
        //        return startDateToString;
        //    }
        //}
        //public string FinishDate
        //{
        //    set
        //    {
        //        Date date = new Date(value);
        //        DateTime finishDate = date.TimeToProcesed();
        //        finishDateToString = Convert.ToString(finishDate);
        //    }
        //    get
        //    {
        //        return finishDateToString;
        //    }
            
        //}
        //public string StartCity
        //{
        //    set
        //    {
        //        if (value.Length > 0)
        //        {
        //            starCity = value;
        //        }
        //        else
        //        {
        //            starCity = "Ви не ввели мiсто";
        //        }
        //    }
        //    get
        //    {
        //        return starCity;
        //    }
        //}
        //public string FinishCity
        //{
        //    set
        //    {
        //        if (value.Length > 0)
        //        {
        //            finishCity = value;
        //        }
        //        else
        //        {
        //            finishCity = "Ви не ввели мiсто";
        //        }
        //    }
        //    get
        //    {
        //        return finishCity;
        //    }
        //}
        public int GetTotalTime()
        {
                DateTime dtOne, dtTwo;
                dtOne = Convert.ToDateTime(startDateToString);
                dtTwo = Convert.ToDateTime(finishDateToString);
                TimeSpan time = dtTwo - dtOne;
                int totalTime = time.Days * 24 * 60 + time.Hours * 60 + time.Minutes;
                //Console.WriteLine("Час подорожi="+ totalTime);
                return totalTime;
        }
        public bool IsArrivingToday()
        {
            bool toDay;
            DateTime dtOne, dtTwo;
            dtOne = Convert.ToDateTime(startDateToString);
            dtTwo = Convert.ToDateTime(finishDateToString);
            if (dtOne.Day == dtTwo.Day)
            {
                toDay = true;
            }
            else
            {
                toDay = false;
            }
            return toDay;
        }
        public string SortAirplanesByDate()
        {
            return startDateToString;
        }
    }
}
