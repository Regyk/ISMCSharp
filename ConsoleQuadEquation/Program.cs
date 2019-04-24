using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuadEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, D;
            Console.WriteLine("Введiть а");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть с");
            c = Convert.ToDouble(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("X1={0:0.##}", x1);
                Console.WriteLine("X2={0:0.##}", x2);
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("X={0:0.##}", x1);
            }
            else
            {
                Console.WriteLine("Нету решения");
            }
            Console.ReadKey();
        }
    }
}
