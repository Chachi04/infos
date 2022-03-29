using System;

namespace merge_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = GenerateArray(10),
                arr2 = GenerateArray(10);
            Array.Sort(arr1);
            Array.Sort(arr2);
            int[] arr3 = TrivialMerge(arr1, arr2),
                arr4 = Merge(arr1, arr2);

            PrintArray(arr1);
            PrintArray(arr2);
            PrintArray(arr3);
            PrintArray(arr4);
        }

        static int[] TrivialMerge(int[] arr1, int[] arr2)
        {
            int[] newarr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newarr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newarr[i + arr1.Length] = arr2[i];
            }
            Array.Sort(newarr);
            return newarr;
        }

        static int[] Merge(int[] arr1, int[] arr2)
        {
            int m1 = 0, m2 = 0, n = -1;
            int[] newarr = new int[arr1.Length + arr2.Length];
            while (m1 < arr1.Length && m2 < arr2.Length)
            {
                if (arr1[m1] < arr2[m2]) newarr[++n] = arr1[m1++];
                else newarr[++n] = arr2[m2++];
            }
            if (m1 == arr1.Length)
                for (int i = m2; i < arr2.Length; i++)
                    newarr[++n] = arr2[i];
            else
                for (int i = m1; i < arr1.Length; i++)
                {
                    newarr[++n] = arr1[i];
                }
            return newarr;
        }

        static int[] GenerateArray(int n)
        {
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            return arr;
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
