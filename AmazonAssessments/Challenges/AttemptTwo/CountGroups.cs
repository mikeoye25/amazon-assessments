using AmazonAssessments.Models;

namespace AmazonAssessments.Challenges.AttemptTwo
{
    // Q 08: Coding Assessment Demo - Attempt 2 - C 02
    public static class CountGroups
    {
        public static int Execute(List<string> related)
        {
            var groups = 0;
            var graphs = new Graphs(related);
            for(var i = 0; i < related.Count; i++)
            {
                if (graphs.Visited[i] == 0)
                {
                    graphs.DFS(i);
                    groups++;
                }
            }
            return groups;
        }
    }
}
