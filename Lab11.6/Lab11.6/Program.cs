using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._6
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());



            b = Math.Floor(Math.Log(a * Math.Sqrt(5) + 0.5) / Math.Log((1 + Math.Sqrt(5)) / 2));
            Console.WriteLine("Порядковый номер = {0}", b);
            Console.ReadKey();


        }
    }
}
