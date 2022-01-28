using System;
using System.Linq;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;

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

            Console.WriteLine("Factorial:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial(n) = " + Factorial(n));

            Console.WriteLine("Fibonachi:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonachi(n) = " + Fibonachi(n));

            Console.WriteLine("Digits:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digits(n) = " + Digits(n));

            Console.WriteLine("Sum Of Digits:");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("SumOfDigits(n) = " + SumOfDigits(n));

            Console.WriteLine(LCD(new int[] { 5, 12, 6 }));

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

        static int GCD1(int a, int b)
            => a == b ? a : a > b ? GCD(a - b, b) : GCD(a, b - a);

        static int GCD(int a, int b)
            => b == 0 ? a : GCD(b, a % b);

        static int Sum(int n)
            => n == 1 ? 1 : (n + Sum(n - 1));

        static int Factorial(int n)
            => n == 0 ? 1 : (n * Factorial(n - 1));

        static int Fibonachi(int n)
            => n == 1 || n == 2 ? 1 : (Fibonachi(n - 1) + Fibonachi(n - 2));

        static int Digits(int n)
            => n / 10 == 0 ? 1 : (1 + Digits(n / 10));

        static int SumOfDigits(int n)
            => n / 10 == 0 ? n : (SumOfDigits(n / 10) + n % 10);

        // static int LCD(int[] nums)
        //     => nums.Aggregate((a, b) => LCD(a, b));

        static int LCD(int a, int b)
            => a * b / GCD(a, b);

        static int LCD(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
            {
                return nums[0];
            }
            if (n == 2)
            {
                return nums[0] * nums[1] / GCD(nums[0], nums[1]);
            }
            return LCD(LCD1((int)nums[n], (int)nums[n - 1]));
        }


    }
}
