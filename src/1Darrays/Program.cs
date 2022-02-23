using System;
using System.IO;
using System.Linq;

namespace _1Darrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = int.Parse(Console.ReadLine());
            // while (n < 10)
            // {
            //     Console.WriteLine("n must be greater than 10");
            //     n = int.Parse(Console.ReadLine());
            // }
            // int[] arr = new int[n];
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                int[] arr = sr.ReadToEnd().Split('\n').Select(str => int.Parse(str)).ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(arr);
                Array.Reverse(arr);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
