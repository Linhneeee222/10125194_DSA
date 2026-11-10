using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static double UCLN(double n)
        {
            if ((n % 2) == 1) return n;
            else return UCLN(n / 2);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hãy nhập số cần tìm ước lẻ lớn nhất của nó: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write($"Ước số lẻ lớn nhất của {n} là: {UCLN(n)}");
        }
    }
}
