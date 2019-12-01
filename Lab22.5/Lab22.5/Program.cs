using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using static System.Console;
namespace Lab22._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ilya\source\repos\Lab22.5\text.txt";
            string text = File.ReadAllText(path);
            string pattern = @"     ";
            int k = 0;
            Regex space = new Regex(pattern);
            MatchCollection matches = space.Matches(text);
            foreach (Match mat in matches)
            {
                k++;
            }      
            Write(k);
            ReadKey();
            
            

        }
    }
}
