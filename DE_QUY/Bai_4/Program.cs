using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1;

            return LuyThua(x, n - 1) * x;         
        }

        static double S(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);

            else return LuyThua(x, n);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập số mũ n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kết quả {x}^{n} là: {S(x, n)}");
        }
    }
}
