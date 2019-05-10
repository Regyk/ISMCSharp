using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib2;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.ShowInfo();
            Abiturient abiturient = new Abiturient();
            abiturient.ShowInfo();
            Student student = new Student();
            student.ShowInfo();
            Teacher teacher = new Teacher();
            teacher.ShowInfo();
            Library_User library_User = new Library_User();
            library_User.ShowInfo();
            Console.ReadKey();
            
        }
    }
}
