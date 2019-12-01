using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Lab22._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Ilya\source\repos\Lab22.3\text1.txt";
            string path2 = @"C:\Users\Ilya\source\repos\Lab22.3\text2.txt";
            string text = File.ReadAllText(path1);
            File.WriteAllText(path1, File.ReadAllText(path2) + text);
        }
    }
}
