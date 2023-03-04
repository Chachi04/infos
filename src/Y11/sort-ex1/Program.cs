using System;
using System.Linq;

namespace sort_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a line of nums: ");
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            // BubbleSort(arr, arr.Length);
            SelectionSort(arr);
            Console.Write("The numbers sorted in increasing order are: ");
            PrintArray(arr);
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1 - i; j++)
                    if (arr[j] > arr[j + 1]) swap(ref arr[j], ref arr[j + 1]);
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j]) swap(ref arr[i], ref arr[j]);
        }

        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
