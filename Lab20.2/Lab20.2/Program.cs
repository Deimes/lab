using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab20._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку: ");
            s = ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Write(s[i] + " ");
            }
            ReadKey();


        }
    }
}
