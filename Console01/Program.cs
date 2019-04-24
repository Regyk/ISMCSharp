using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            Console.WriteLine("Введiть а");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть x");
            x = Convert.ToDouble(Console.ReadLine());
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine("Y={0:0.######}", y);
            Console.ReadKey();
        }
    }
}
