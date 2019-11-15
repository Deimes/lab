using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());
            Write("Введите число К: ");
            k = int.Parse(ReadLine());

            int[] a = new int[40];
            int[] b = new int[40];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int nk = 1, nachalo = 1, dl = (k == 1 ? 1 : 0), konec = 0;

            for (int i = 1; i < n; ++i)
            {
                if (a[i - 1] != a[i])
                {
                    nk++;
                    if (nk == k) nachalo = i;
                    konec = i;
                }
                if (nk == k) dl++;
            }

            int c = -1;
            for (int i = 0; i < nachalo; ++i)
                b[++c] = a[i];

            for (int i = konec; i < n; ++i)
                b[++c] = a[i];

            for (int i = nachalo + dl; i < konec; ++i)
                b[++c] = a[i];

            for (int i = nachalo; i < nachalo + dl; ++i)
                b[++c] = a[i];

            for (int i = 0; i < n; ++i)
                a[i] = b[i];

            for (int i = 0; i < n; i++)
            {
                Write(a[i] + " ");
            }

            ReadKey();

        }
    }
}
