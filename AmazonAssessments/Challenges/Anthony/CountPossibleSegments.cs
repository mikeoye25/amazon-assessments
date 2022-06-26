namespace AmazonAssessments.Challenges.Anthony
{
    // Q 02: Anthony C 02
    public static class CountPossibleSegments
    {
        public static long Execute(int k, List<int> weights)
        {
            var result = 0L;
            for (int i = 0; i < weights.Count; i++)
            {
                var min = weights[i];
                var max = weights[i];
                for (int j = i; j < weights.Count; j++)
                {
                    min = Math.Min(min, weights[j]);
                    max = Math.Max(max, weights[j]);
                    if (max - min <= k)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
