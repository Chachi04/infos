using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(GCD(25, 94));
            // Console.WriteLine(GCD(25, 94));
            // Console.WriteLine(Sum(10));
        }

        static int GCDItr(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static int GCD(int a, int b)
            => b == 0 ? a : GCD(b, a % b);

        static int Sum(int n)
            => n == 0 ? 0 : (n + Sum(n - 1));

        static int Factorial(int n)
            => n == 0 ? 1 : (n * Factorial(n - 1));

        static int Fibonachi(int n)
            => n == 1 || n == 2 ? 1 : (Fibonachi(n - 1) + Fibonachi(n - 2));
    }
}
