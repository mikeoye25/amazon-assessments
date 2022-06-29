namespace AmazonAssessments.Models
{
    public class Graphs
    {
        int vertices;
        int[,] adjMat;
        int[] visited;

        public Graphs(List<string> s)
        {
            var n = s.Count;
            vertices = n;
            adjMat = new int[n, n];
            visited = new int[vertices];
            PopulateGraph(s);
        }

        public int[] Visited 
        {
            get 
            {
                return visited;
            }
        }

        public void InsertEdges(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }

        public void PopulateGraph(List<string> s)
        {
            for (var i = 0; i < s.Count; i++)
            {
                var item = s[i];
                for (var j = 0; j < item.Length; j++)
                {
                    var itemInt = Convert.ToInt32(item[j]) - 48;
                    InsertEdges(i, j, itemInt);
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    Console.Write(adjMat[i, j] + "\t");
                    Console.WriteLine();
                }
            }
        }

        public void DFS(int s)
        {
            if (visited[s] == 0)
            {
                visited[s] = 1;
                for (int j = 0; j < vertices; j++)
                {
                    if (adjMat[s, j] == 1 && visited[j] == 0)
                    {
                        DFS(j);
                    }
                }
            }
        }
    }
}
