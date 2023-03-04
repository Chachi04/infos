using System;
using System.Linq;

namespace _9._03
{
    public class Sum
    {
        public static int Method(int a, int b)
            => a * b;
        public static int Method(int a, int b, int c)
            => a + b + c;
        public static string Method(string a, string b)
            => a + b;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.Write("Enter two numbers: ");
            int[] a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(Sum.Method(a[0], a[1]));

            Console.Write("Enter three numbers: ");
            int[] b = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(Sum.Method(b[0], b[1], b[2]));


            Console.Write("Enter two words: ");
            string[] c = Console.ReadLine().Split();
            Console.WriteLine(Sum.Method(c[0], c[1]));
        }
    }
}
