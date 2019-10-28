using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Введите год: ");
            a = int.Parse(Console.ReadLine());

            b = Math.Floor((a / 100) + 1);
            Console.WriteLine(string.Format("Номер столетия: {0:N0}", b));
            Console.ReadKey();
   

        }
    }
}
