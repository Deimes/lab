using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 0, vklad = 1000, p;

            Console.Write("Введите проценты от 0 до 25%: ");
            p = Convert.ToDouble(Console.ReadLine());

            p = p / 100;


            while (vklad <= 1100)
            {
                vklad = vklad + (p * vklad);
                k += 1;
            }

            Console.WriteLine("Сумма равна: {0:N2} , месяцев прошло {1}", vklad, k);
            Console.ReadKey();
        }
    }
}
