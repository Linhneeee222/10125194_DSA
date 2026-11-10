using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static double Tong(double n)
        {
            if (n <= 1) return n;
            return Tong(n - 1) + 1.0/n;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n số lượng ban đầu cần tính tổng: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng 1 trên các số của {0} số đầu tiên là: {1} ", n, Tong(n));
        }
    }
}