namespace AmazonAssessments.Challenges.Michael
{
    // Q 03: Michael C 01
    public static class MaximumQuality
    {
        public static long Execute(List<int> packets, int channels)
        {
            packets.Sort();
            var result = 0d;
            var currentIndex = 0;
            for (var i = packets.Count - 1; i >= 0; i--)
            {
                result += packets[i];
                currentIndex = i - 1;
                channels--;
                if (channels == 1)
                {
                    break;
                }
            }
            if (currentIndex >= 0)
            {
                result += CalculateMedian(packets, currentIndex);
            }
            return (long)Math.Ceiling(result);
        }

        private static double CalculateMedian(List<int> packets, int currentIndex)
        {
            var median = 0d;
            var remainder = (currentIndex + 1) % 2;
            var midNumber = (int)Math.Floor(currentIndex * 1.0 / 2);
            if (remainder == 1)
            {
                median = packets.ElementAt(midNumber);
            }
            else
            {
                median = (packets.ElementAt(midNumber) + packets.ElementAt(midNumber + 1)) / 2.0;
            }
            return median;
        }
    }
}
