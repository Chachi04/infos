using System;

namespace polymorphism
{
    public class Multiplication
    {
        static public int multiply(int a, int b)
        {
            return a * b;
        }
        static public string multiply(string a, int b)
        {
            string s = "";
            for (int i = 0; i < b; i++)
            {
                s += a;
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplication.multiply(4, 2));
            Console.WriteLine(Multiplication.multiply("ab", 5));
        }
    }
}
