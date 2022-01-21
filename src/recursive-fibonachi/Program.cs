using System;

namespace recursive_fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a num: ");
                Console.WriteLine(fib(int.Parse(Console.ReadLine())));
            }
        }
        static long fib(int n)
        {
            if (n <= 0) return fib(n + 2) - fib(n + 1);
            if (n == 1 || n == 2) return 1;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
