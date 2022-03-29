using System;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = { 1, 6, 8, 4, 2, 0, 12, -5, 18, 3 };

            sort2(arr, n);
            print(arr);
        }

        static void print(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num);
                Console.Write(" ");
            }
        }

        static void sort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int minindex = i;
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < arr[minindex]) minindex = j;
                }
                swap(ref arr[i], ref arr[minindex]);
            }
        }

        static void sort2(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j]) swap(ref arr[i], ref arr[j]);
        }

        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
