// See https://aka.ms/new-console-template for more information

Graph g = new Graph(4);
g.AddEdge(0, 1);
g.AddEdge(1, 2);
g.AddEdge(0, 3);
g.AddEdge(3, 2);
/* g.AddEdge(0, 2); */
/* g.AddEdge(1, 2); */
/* g.AddEdge(2, 0); */
/* g.AddEdge(2, 3); */
/* g.AddEdge(3, 3); */

Console.Write("Following is Breadth First " + "Traversal(starting from " +
              "vertex 2)\n");
g.BFS(2);

class Graph {
  private int _V;
  private List<int>[] _adj;

  public Graph(int V) {
    _adj = new List<int>[V];
    for (int i = 0; i < V; i++)
      _adj[i] = new List<int>();
    _V = V;
  }

  public void AddEdge(int u, int v) {
    _adj[v].Add(u);
    _adj[u].Add(v);
  }

  public void BFS(int s) {
    bool[] visited = new bool[_V];
    for (int i = 0; i < _V; i++)
      visited[i] = false;
    Queue<int> q = new Queue<int>();

    visited[s] = true;
    q.Enqueue(s);

    while (q.Count() != 0) {
      s = q.Dequeue();
      Console.Write(s + " ");

      List<int> list = _adj[s];

      foreach (var val in list) {
        if (!visited[val]) {
          visited[val] = true;
          q.Enqueue(val);
        }
      }
    }
    Console.WriteLine();
  }
}
