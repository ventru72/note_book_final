using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 class1 = new Class1(
               new worker(32, "Виталий", "Сюточкин"),
               new worker(23, "Ашот", "Говнаренко")
               );
            //без индексации
            Console.WriteLine(class1.work[0].Print());
            //с индексацией 
            Console.WriteLine(class1[1].Print());
            Console.ReadKey();
        }
    }
}
