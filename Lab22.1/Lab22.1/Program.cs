using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Lab22._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ilya\source\repos\Lab22.1\text.txt";
            string text = File.ReadAllText(path);
            text = text.Remove(0, text.IndexOf(' ') + 1);
            File.WriteAllText(path, text);
            ReadKey();
        }
    }
}
