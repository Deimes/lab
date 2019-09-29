using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, ac, bc, summ;
            Console.Write("Введите значение точки а: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение точки b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение точки c: ");
            c = int.Parse(Console.ReadLine());

            ac = Math.Abs(c - a);
            bc = Math.Abs(c - b);
            summ = ac + bc;

            Console.WriteLine(string.Format("AC = {0}, BC = {1}, Сумма отрезков равна: {2}", ac, bc, summ));
            Console.ReadKey();
        }
    }
}
