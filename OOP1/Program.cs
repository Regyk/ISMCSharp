using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib1;
namespace OOP1
{
    class Program
    {
        public static Airplane[] Flights;
        public static int max, min;
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiтьсь рейсiв:");
            string SizeArr = Console.ReadLine();
            if (int.TryParse(SizeArr, out int size))
            {
                ReadAirplaneArray(size);
                PrintAirplanes(Flights);
                GetAirplaneInfo(Flights, out min, out max);
                Console.WriteLine(min+" "+max);
                SortAirplanesByTotalTime(Flights);
                PrintAirplanes(Flights);
            }
            else
            {
                Console.Write("кiлькiтьсь рейсiв не вiрна");
            }
            Console.ReadKey();
        }
        static Airplane[] ReadAirplaneArray(int size)
        {
                Flights = new Airplane[size];
                for (int i = 0; i < size; i++)
                {
                    Flights[i] = new Airplane();
                }
                    for (int i = 0; i < size; i++)
                {
                    Console.Write("Введiть мiсто початку польту:");
                    string StarCity = Console.ReadLine();
                    Console.Write("Введiть дату у форматi HH:MM YYYY-MM-DD :");
                    string StartDate = Console.ReadLine();
                    Console.Write("Введiть мiсто кiнця польту:");
                    string FinishCity = Console.ReadLine();
                    Console.Write("Введiть дату у форматi HH:MM YYYY-MM-DD :");
                    string FinishDate = Console.ReadLine();
                    Flights[i] = new Airplane(StarCity, StartDate, FinishCity, FinishDate);
                }
                return Flights;
        }
        static void PrintAirplane(Airplane airplane)
        {
            //Console.Write("Введiть мiсто початку польту:");
            //string StarCity = Console.ReadLine();
            //Console.Write("Введiть дату у форматi HH:MM YYYY-MM-DD :");
            //string StartDate = Console.ReadLine();
            //Console.Write("Введiть мiсто кiнця польту:");
            //string FinishCity = Console.ReadLine();
            //Console.Write("Введiть дату у форматi HH:MM YYYY-MM-DD :");
            //string FinishDate = Console.ReadLine();
            //airplane = new Airplane(StarCity, StartDate, FinishCity, FinishDate);
            airplane.ShowFlights();
        }
        static void PrintAirplanes(Airplane[] airplanes)
        {
                for (int i = 0; i < airplanes.Length; i++)
                {
                    Flights[i].ShowFlights();
                }
        }
        static void GetAirplaneInfo(Airplane[] airplanes, out int min, out int max)
        {
            max = airplanes[0].GetTotalTime();
            min = airplanes[0].GetTotalTime();
            for (int i = 0; i < airplanes.Length; i++)
            {
                if (max < airplanes[i].GetTotalTime())
                {
                    max = airplanes[i].GetTotalTime();
                }
                if (min > airplanes[i].GetTotalTime())
                {
                    min = airplanes[i].GetTotalTime();
                }
            }
        }
        static void SortAirplanesByDate(Airplane[] airplanes)
        {
                for (int i = 0; i < airplanes.Length-1; i++)
                {
                    for (int j = i+1; j < airplanes.Length; j++)
                    {
                        if (Convert.ToDateTime(airplanes[i].SortAirplanesByDate()) > Convert.ToDateTime(airplanes[j].SortAirplanesByDate()))
                        {
                            Airplane temp = new Airplane(airplanes[j]);
                            airplanes[j] = airplanes[i];
                            airplanes[i] = temp;
                        }
                    }
            }
        }
        static void SortAirplanesByTotalTime(Airplane[] airplanes)
        {
            for (int i = 0; i < airplanes.Length - 1; i++)
            {
                //Console.WriteLine(airplanes[i].GetTotalTime());
                for (int j = i + 1; j < airplanes.Length; j++)
                {
                    if (airplanes[i].GetTotalTime() > airplanes[j].GetTotalTime())
                    {
                        Airplane temp = new Airplane(airplanes[j]);
                        airplanes[j] = airplanes[i];
                        airplanes[i] = temp;
                    }
                }
            }
        }

    }
}
