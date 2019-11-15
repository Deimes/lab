using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace Lab11._6 

{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 

            double a, r, b, k, c; ; 
            Console.Write("Введите число: "); 
            a = int.Parse(Console.ReadLine()); 
            k = 2; 
            b = 1; 
            c = 1; 
            r = 0; 
            while (r <= a) 
            { 
                r = b + c; 
                b = c; 
                c = r; 
                k++; 
            }              
            Console.WriteLine("Порядковый номер = {0}", k); 
            Console.ReadKey(); 
        } 
    } 
} 
