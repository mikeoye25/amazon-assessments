using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAssessments.Challenges.AttemptTwo
{
    // Q 08: Coding Assessment Demo - Attempt 2 - C 02

    #region Graphs class

    class Graphs
    {
        int vertices;
        int[,] adjMat;

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
        }
        public Graphs(List<string> s)
        {
            var n = s.Count;
            vertices = n;
            adjMat = new int[n, n];
            PopulateGraph(s);
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

        public void InsertEdges(int u, int v, int x)
        {
            adjMat[u, v] = x;
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
    }

    #endregion

    public static class CountGroups
    {
        public static int Execute(List<string> related)
        {
            var result = 0;
            var g = new Graphs(related);
            Console.WriteLine("Graphs Adjacency Matrix: ");
            g.Display();
            return result;
        }
    }
}
