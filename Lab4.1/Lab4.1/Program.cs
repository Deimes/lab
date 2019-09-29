using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, p;       
            
            Console.WriteLine("Введите значение угла а");
            a = int.Parse(Console.ReadLine());
            p = 180;

            b = a / p;

            Console.WriteLine(string.Format("Значение этого угла равно {0:N2} п", b));
            Console.ReadKey();
        }
    }
}
