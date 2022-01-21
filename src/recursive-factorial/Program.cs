using System;

namespace recursive_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a num: ");
                Console.WriteLine(factorial(int.Parse(Console.ReadLine())));
            }
        }

        static long factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        }
    }
}
