namespace AmazonAssessments.Challenges.AttemptOne
{
    // Q 05: Coding Assessment Demo - Attempt 1 - C 01
    // The intersection of A and B is null
    public static class MinimalHeaviestSetA
    {
        public static List<int> Execute(List<int> arr)
        {
            arr.Sort();
            var result = new List<int>();
            var indexA = arr.Count - 1;
            var indexB = 0;
            var sumA = arr[indexA];
            var sumB = arr[indexB];
            result.Add(arr[indexA]);
            while(indexA > indexB)
            {
                if(sumA > sumB && sumA > sumB + arr[indexB + 1])
                {
                    indexB++;
                    sumB += arr[indexB];
                }
                else if (sumA > sumB && sumA <= sumB + arr[indexB + 1])
                {
                    indexA--;
                    sumA += arr[indexA];
                    result.Add(arr[indexA]);
                }
                if(indexA - indexB == 1)
                {
                    break;
                }
            }
            result.Reverse();
            return result;
        }
    }
}
