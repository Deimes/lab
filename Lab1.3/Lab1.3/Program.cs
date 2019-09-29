using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sr;
            Console.Write("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            sr = (a + b) / 2;
            Console.WriteLine(string.Format("Ср. Ариф: {0}", sr));
            Console.ReadKey();
        }
    }
}
