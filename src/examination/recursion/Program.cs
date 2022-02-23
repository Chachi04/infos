using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            Console.WriteLine("Recursion");
            Console.Write("Enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(x, n));
        }

        static double Sum(int x, int n)
            => n == 1 ? n * 2 * Math.Pow(x, n) : Sum(x, n - 1) + n * 2 * Math.Pow(x, n);
    }
}
