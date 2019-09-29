using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, summ, razn, proiz, chast;
            Console.Write("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());

            a = Math.Sqrt(a);
            b = Math.Sqrt(b);

            summ = a + b;
            razn = a - b;
            proiz = a * b;
            chast = a / b;
            if (a != 0 && b != 0)
            {
                Console.WriteLine(string.Format("Сумма равна: {0}", summ));
                Console.WriteLine(string.Format("Разность равна: {0}", razn));
                Console.WriteLine(string.Format("Произведение равно: {0}", proiz));
                Console.WriteLine(string.Format("Частное равно: {0}", chast));
            }
            else
            {
                Console.WriteLine("Вы ввели недопустимое значение!");
            }

            Console.ReadKey();
        }
    }
}
