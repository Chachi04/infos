using System;

namespace primer3._2
{
    class Program
    {
        static void increment(ref int value)
        {
            value++;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("number = " + number);
            increment(ref number);
            Console.WriteLine("increment(number) = " + number);
        }
    }
}
