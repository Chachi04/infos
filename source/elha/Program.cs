using System;

namespace elha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число.");
            int.TryParse(Console.ReadLine(), out int n);
            int i;
            for (i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', i * 2 - 1));
            }
            for (i = 1; i <= 2; i++)
            {
                Console.Write(new string(' ', n - 1));
                Console.WriteLine('*');
            }
        }
    }
}
