using System;
using System.Linq;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            // int n = arr.Length;
            Random r = new Random();
            int n = 1000;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = r.Next(-1000, 1000);

            sort(arr, n);
            print(arr);

        }

        static void sort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1 - i; j++)
                    if (arr[j] > arr[j + 1]) swap(ref arr[j], ref arr[j + 1]);
        }

        static void print(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
