using System;
using System.Collections;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ArrayList();
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Enter {n} numbers");
            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }
            a.Sort();
            a.Reverse();
            Console.WriteLine();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
