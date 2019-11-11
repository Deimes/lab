using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, k = 0;

            Console.Write("Введите число N: ");
            n = int.Parse(Console.ReadLine());

            while (s <= n)
            {
                k += 1;
                s = s + k;
            }
            Console.WriteLine("Сумма равна {0}, наименьшее целое К = {1}", s, k);
            Console.ReadKey();
        }
    }
}
