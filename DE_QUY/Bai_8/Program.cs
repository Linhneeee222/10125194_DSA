using System;

namespace Bai_8
{
    internal class Program
    {
        static float Can(int i, int n)
        {
            if (i == n) return (float)Math.Sqrt(n);

            return (float)Math.Sqrt(i + Can(i + 1, n));
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kết quả là: {Can(1, n)}");
        }
    }
}