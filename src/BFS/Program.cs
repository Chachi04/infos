// See https://aka.ms/new-console-template for more information

void BFS(int n, List<int>[] G, List<int> T, int r)
{
    int x, y, i;
    bool[] visited = new bool[n + 1];
    Queue<int> Q = new Queue<int>();
    for (i = 1; i <= n; i++)
        visited[1] = false;
    Q.Enqueue(r);
    visited[r] = true;
    T[r] = 0;
    while (Q.Count > 0)
    {
        x = Q.Dequeue();
        for (i = 0; i < G[x].Count; i++)
        {
            y = G[x][i];
            if (!visited[y])
            {
                visited[y] = true;
                T[y] = x;
                Q.Enqueue(y);
            }
        }
    }
}

int n, m, r, i, u, v;
Console.Write("n: ");
n = int.Parse(Console.ReadLine());
Console.Write("m: ");
m = int.Parse(Console.ReadLine());
Console.Write("r: ");
r = int.Parse(Console.ReadLine());

List<int>[] G = new List<int>[n + 1];
List<int> T = new List<int>(n + 1);
T.Add(0);
for (i = 1; i <= n; i++)
{
    G[i] = new List<int>(n + 1);
    T.Add(0);
}

for (i = 1; i <= m; i++)
{
    Console.Write("u: ");
    u = int.Parse(Console.ReadLine());
    Console.Write("v: ");
    v = int.Parse(Console.ReadLine());
    G[u].Add(v);
    G[v].Add(u);
}

BFS(n, G, T, r);
for (i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}: {T[i]}");
}
