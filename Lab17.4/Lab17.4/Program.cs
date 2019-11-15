using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab17._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());
            float[,] a = new float[10, 2];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}]: ", i);
                Write("x = ");
                a[i, 0] = int.Parse(ReadLine());
                Write("y = ");
                a[i, 1] = int.Parse(ReadLine());
            }

            int maxind = 0;
            double s, smax;

            for (int i = 0; i < n; i++)
            {
                if(a[i, 0] < 0 && a[i, 1] > 0)
                {
                    s = Math.Sqrt(Math.Pow(a[i, 0], 2) + Math.Pow(a[i, 1], 2));
                    if ( s > maxind || i == 0)
                    {
                        smax = s;
                        maxind = i;
                    }
                }
            }

            Write("A[{0}]: X = {1} Y = {2} ", maxind, a[maxind, 0], a[maxind, 1]);
            ReadKey();

        }
    }
}
