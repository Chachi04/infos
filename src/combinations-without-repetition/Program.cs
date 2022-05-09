using System;

namespace combinations_without_repetition
{
    class Program
    {


        static void Print(int[] comb) => Console.WriteLine($"({string.Join(", ", comb)})");

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] comb = new int[m];
            for (int i = 0; i < m; i++)
            {
                comb[i] = i + 1;
            }
            Print(comb);
            int j = m - 1;
            comb[j] = comb[j - 1] + 1;
            while (comb[j] < n) { comb[j]++; Print(comb); }
            // for (int i = m - 1; i > n - m; i--)
            // {
            //     // comb[i]++;
            //     comb[j] = comb[j - 1] + 1;
            //     while (comb[j] < n) { comb[j]++; Print(comb); }
            // }
        }
    }
}
