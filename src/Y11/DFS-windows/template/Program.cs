using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template {
  class Program {
    static void Main(string[] args) {
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
      for (i = 1; i <= n; i++) {
        G[i] = new List<int>(n + 1);
        T.Add(0);
      }

      for (i = 1; i <= m; i++) {
        Console.Write("u: ");
        u = int.Parse(Console.ReadLine());
        Console.Write("v: ");
        v = int.Parse(Console.ReadLine());
        G[u].Add(v);
        G[v].Add(u);
      }

      bool[] visited = new bool[n];
      for (i = 0; i < n; i++) {
        visited[i] = false;
      }

      DFS(G, T, visited, r);
      for (i = 1; i <= n; i++) {
        Console.WriteLine($"{i}: {T[i]}");
      }
    }

    void DFS(List<int>[] G, List<int> T, bool[] visited, int r) {
      int x, i;
      visited[r - 1] = true;
      for (i = 0; i < G[r].Count; i++) {
        x = G[r][i];
        if (!visited[x - 1]) {
          T[x] = r;
          DFS(G, T, visited, x);
        }
      }
    }
  }
}
