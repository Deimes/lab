using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Lab22._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ilya\source\repos\Lab22.2\text.txt";
            string text = File.ReadAllText(path);
            Write("Введите число K(кол-во звезд): ");
            int k = int.Parse(ReadLine());
            Write("Введите число N(строки): ");
            int n = int.Parse(ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    File.AppendAllText(path, string.Join(path," * "));                  
                }
                File.AppendAllText(path, Environment.NewLine);
            }


            

        }
    }
}
