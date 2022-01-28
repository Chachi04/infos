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
            int a, b, n;

            Console.WriteLine("RECURSION");
            Console.WriteLine("------------");

            Console.WriteLine("GCD1:");
            Console.WriteLine("Enter two nums:");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("GCD1(a,b) = " + GCD1(a, b));

            Console.WriteLine("GCD:");
            Console.WriteLine("Enter two nums:");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("GCD(a,b) = " + GCD(a, b));

            Console.WriteLine("Sum:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum(n) = " + Sum(n));

        }

        static int GCD1(int a, int b)
            => a == b ? a : a > b ? GCD(a - b, b) : GCD(a, b - a);

        static int GCD(int a, int b)
            => b == 0 ? a : GCD(b, a % b);

        static int Sum(int n)
            => n == 1 ? 1 : (n + Sum(n - 1));
    }
}
