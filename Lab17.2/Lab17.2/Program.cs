using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            Write("Введите число L: ");
            l = int.Parse(ReadLine());

            int[] a = new int[50];
            int[] b = new int[10];
            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int k;
            for (int i = 0; i < n; i++)
            {
                k = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] == a[i])
                    {
                        k++;
                    }
                    else break;
                }
                if (k == l)
                {
                    for (int j = i; j < i + k; j++)
                    {
                        Write(a[j] + " ");
                    }
                    i += k;
                }
                if (k > l)
                {
                    i = i + l;
                    Write("0 ");
                }
                else
                {
                    Write(a[i] + " ");
                }
            }          

            ReadKey();

        }
    }
}

