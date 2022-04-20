using System;
using System.Collections;
using System.Collections.Generic;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            int n = int.Parse(Console.ReadLine());
            li.Add(int.Parse(Console.ReadLine()));
            if (n == 1) return;
            for (int i = 1; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                int j = 0;
                while (j < li.Count && m > li[j]) j++;
                if (j == li.Count) li.Add(m);
                else li.Insert(j, m);
            }
            foreach (int item in li)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
