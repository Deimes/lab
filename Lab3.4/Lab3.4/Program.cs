using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
    class Program
    {
        static void Main(string[] args)
        {            
            double x, y;
            Console.WriteLine("Введите X");
            x = int.Parse(Console.ReadLine());

            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;

            Console.WriteLine(string.Format("Значение равно: {0}", y));
            Console.ReadKey();

        }
    }
}
