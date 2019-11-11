using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._3
{
    class Program
    {
        static double RingS(double r1, double r2)
        {            
            return 3.14 * (Math.Pow(r1, 2) - Math.Pow(r2, 2));

            
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i += 1)
            {



                Console.Write("Введите внешний радиус {0} кольца: ", i);
                double r1 = double.Parse(Console.ReadLine());

                Console.Write("Введите внутренний радиус {0} кольца: ", i);
                double r2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Площадь {0} кольца равна: {1}",i, RingS(r1, r2));
            }
            Console.ReadKey();



        }
    }
}
