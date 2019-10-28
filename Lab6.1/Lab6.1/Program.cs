using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, n;

            Console.Write("Введите количество секунд прошедшее с начала суток: ");
            n = double.Parse(Console.ReadLine());

            a = n % 60;
            
            Console.WriteLine(string.Format("Прошло {0} сек", a));
            Console.ReadKey();
            
        }
    }
}
