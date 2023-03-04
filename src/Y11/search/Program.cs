using System;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateArray(20);
            Array.Sort(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("Enter target num: ");
            int target = int.Parse(Console.ReadLine());
            // Console.WriteLine(Search(arr, target));
            // Console.WriteLine(BinarySearch(arr, target));
            Console.WriteLine(BinarySearch(arr, 0, arr.Length - 1, target) == -1 ? "Not found" : "Found");
        }

        static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target) return i;
            return -1;
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target == arr[mid]) return mid;
                if (target < arr[mid]) right = mid - 1;
                else left = mid + 1;
            }
            return -1;
        }

        static int BinarySearch(int[] arr, int left, int right, int target)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (target == arr[mid]) return mid;
            if (target < arr[mid]) return BinarySearch(arr, left, mid - 1, target);
            return BinarySearch(arr, mid + 1, right, target);
        }

        static int[] GenerateArray(int n)
        {
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(0, 100);
            return arr;
        }
    }
}
