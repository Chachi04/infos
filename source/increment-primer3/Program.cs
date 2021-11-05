using System;

namespace increment_primer3
{
    class Program
    {
        static void increment(ref int value)
        {
            value++;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("number = " + number);
            increment(ref number);
            Console.WriteLine("increment(number) = " + number);
        }
    }
}
