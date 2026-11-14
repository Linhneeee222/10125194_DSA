using System;
using System.Text;

namespace Buoi01_DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Bài 1: Tính tổng S(n) = 1 + 2 + ... + n ===");
            Bai1();

            Console.WriteLine("\n=== Bài 2: Tính tổng bình phương S(n) = 1^2 + 2^2 + ... + n^2 ===");
            Bai2();

            Console.WriteLine("\n=== Bài 3: Tính tổng nghịch đảo S(n) = 1 + 1/2 + ... + 1/n ===");
            Bai3();

            Console.WriteLine("\n=== Bài 4: Tính lũy thừa S(x, n) = x^n ===");
            Bai4();

            Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
            Bai5();

            Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
            Bai6();

            Console.WriteLine("\n=== Bài 7: Đếm số chữ số của số nguyên n ===");
            Bai7();

            Console.WriteLine("\n=== Bài 8: Tính S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n))) ===");
            Bai8();
        }

        // ==================== BÀI 1 ====================
        static double Tong1(double n)
        {
            if (n <= 1) return n;
            return Tong1(n - 1) + n;
        }

        static void Bai1()
        {
            int[] testCases = { 5, 10 };
            foreach (int n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Tổng của {n} số đầu tiên là: {Tong1(n)}");
            }
        }

        // ==================== BÀI 2 ====================
        static double Tong2(double n)
        {
            if (n <= 1) return n;
            return Tong2(n - 1) + n * n;
        }

        static void Bai2()
        {
            int[] testCases = { 3, 10 };
            foreach (int n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Tổng bình phương của {n} số đầu tiên là: {Tong2(n)}");
            }
        }

        // ==================== BÀI 3 ====================
        static double Tong3(double n)
        {
            if (n <= 1) return n;
            return Tong3(n - 1) + 1.0 / n;
        }

        static void Bai3()
        {
            int[] testCases = { 4, 10 };
            foreach (int n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Tổng 1 trên các số của {n} số đầu tiên là: {Tong3(n):F4}");
            }
        }

        // ==================== BÀI 4 ====================
        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1;
            return LuyThua(x, n - 1) * x;
        }

        static double S4(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n);
        }

        static void Bai4()
        {
            (double x, int n)[] testCases = { (2, 10), (5, 0), (2, -3) };
            foreach (var (x, n) in testCases)
            {
                Console.WriteLine($"Với x = {x}, n = {n}: Kết quả {x}^{n} là: {S4(x, n)}");
            }
        }

        // ==================== BÀI 5 ====================
        static long UocLeLonNhat(long n)
        {
            n = Math.Abs(n);
            if (n % 2 == 1) return n;
            return UocLeLonNhat(n / 2);
        }

        static void Bai5()
        {
            long[] testCases = { 100, 48, 7 };
            foreach (long n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Ước số lẻ lớn nhất của {n} là: {UocLeLonNhat(n)}");
            }
        }

        // ==================== BÀI 6 ====================
        static long UCLN(long a, long b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        static void Bai6()
        {
            (long a, long b)[] testCases = { (48, 18), (17, 5) };
            foreach (var (a, b) in testCases)
            {
                Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
            }
        }

        // ==================== BÀI 7 ====================
        static long SoChuSo(long n)
        {
            n = Math.Abs(n);
            if (n < 10) return 1;
            return SoChuSo(n / 10) + 1;
        }

        static void Bai7()
        {
            long[] testCases = { 7, 12345, -987654 };
            foreach (long n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Số chữ số của {n} là: {SoChuSo(n)}");
            }
        }

        // ==================== BÀI 8 ====================
        static float Can(int i, int n)
        {
            if (i == n) return (float)Math.Sqrt(n);
            return (float)Math.Sqrt(i + Can(i + 1, n));
        }

        static void Bai8()
        {
            int[] testCases = { 3, 5, 10 };
            foreach (int n in testCases)
            {
                Console.WriteLine($"Với n = {n}: Kết quả là: {Can(1, n):F6}");
            }
        }
    }
}
