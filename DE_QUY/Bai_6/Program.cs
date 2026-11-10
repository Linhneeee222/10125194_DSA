using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    
    internal class Program
    {
        static long UCLN(long a, long b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập a: ");
            long a = long.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            long b = long.Parse(Console.ReadLine());
            long ucln = UCLN(a, b);
            Console.WriteLine($"UCLN({a}, {b}) = {ucln}");
        
    }
    }
}
