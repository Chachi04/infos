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
            int number = 1;
            Console.WriteLine(number);
            increment(ref number);
            Console.WriteLine(number);
        }
    }
}
