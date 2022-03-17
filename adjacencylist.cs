class Graph {
  Dictionary<int, List<int>> g;

  public Graph(int V) {
    g = new Dictionary<int, List<int>>();

    for (int v = 0; v < V; v++) {
      g.Add(v, new List<int>());
    }
  }
  
  public void AddEdge(int u, int v) {
    g[u].Add(v);
  }
}
