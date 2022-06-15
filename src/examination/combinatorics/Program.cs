// See https://aka.ms/new-console-template for more information

int n, m;
char[] Var;
bool[] used;

void Print()
    => Console.WriteLine($"({string.Join(",", Var})");

void genVarRec(int ind)
{
    if (ind == 4) { Print(); return; }
    for (char i = 'а'; i < 'а' + n; i++)
    {
        if (!used[(int)(i - 'а')])
        {
            used[(int)(i - 'а')] = true;
            Var[ind] = i;
            genVarRec(ind + 1);
            used[(int)(i - 'а')] = false;
        }
    }
}

Console.Write("m: ");
n = int.Parse(Console.ReadLine());
Var = new char[4];
used = new bool[n];
Array.Resize(ref used, n + 1);
genVarRec(1);
