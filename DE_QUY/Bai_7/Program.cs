using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    internal class Program
    {
        static long SoChuSo(long n)
        {
            // Xử lý ngoại lệ nhập số âm
            n = Math.Abs(n);
            if (n < 10) return 1; 
            return SoChuSo(n / 10) + 1;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;

            Console.Write("Hãy nhập số cần đếm chữ số: ");
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine("Số chữ số của {0} là: {1}", n, SoChuSo(n));
        }
    }
}
