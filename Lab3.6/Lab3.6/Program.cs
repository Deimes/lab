using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t;

            

            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            t = a;
            a = a * a;
            a = a * a;
            a = a * a;

           

            Console.WriteLine(string.Format("{0} в 8 степени равно: {1} ", t, a));
            Console.ReadKey();
        }
    }
}
