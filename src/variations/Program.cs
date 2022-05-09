using System;

namespace variations
{
    class Program
    {
        static int n, m;
        static int[] Var;
        static bool[] used;

        static void Print()
            => Console.WriteLine($"( {string.Join(", ", Var)} )");

        static void genVarRec(int ind)
        {
            if (ind == m) { Print(); return; }
            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    Var[ind] = i;
                    genVarRec(ind + 1);
                    used[i] = false;
                }
            }
        }

        static void Variations()
        {
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m: ");
            m = int.Parse(Console.ReadLine());
            Var = new int[m];
            used = new bool[n];
            genVarRec(0);
        }


        static void Main(string[] args)
        {
            Variations();
        }
    }
}
