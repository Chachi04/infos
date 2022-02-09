using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;

            Console.WriteLine("Recursion page 25");
            Console.WriteLine("ex1 a");
            Console.Write("Enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(a(x, n));

            Console.WriteLine("ex1 b");
            Console.Write("Enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(b(x, n));

            Console.WriteLine("ex1 c");
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(c(n));
        }

        static double a(int x, int n)
        {
            if (n == 0) return 1;
            return Math.Pow(x, n) + a(x, n - 1);
        }

        static double b(int x, int n)
        {
            if (n == 0) return 1;
            return b(x, n - 1) + (1 / Math.Pow(x, n));
        }

        static double c(int n)
        {
            if (n == 1) return n * (n + 1);
            return c(n - 1) + n * (n + 1);
        }

    }
}
