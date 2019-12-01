using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Lab22._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ilya\source\repos\Lab22.4\text.txt";
            string text = File.ReadAllText(path);
            File.Delete(path);
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            File.AppendAllText(path, text);
           
        }
    }
}
