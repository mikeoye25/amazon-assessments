namespace AmazonAssessments.Challenges.Michael
{
    // Q 04: Michael C 02
    public static class FindMaxProducts
    {
        public static long Execute(List<int> products)
        {
            var result = 0L;
            for (var i = products.Count - 1; i >= 0; i--)
            {
                var lastNumber = products[i];
                var sumProducts = lastNumber;
                if (i > 0)
                {
                    for (var j = i - 1; j >= 0; j--)
                    {
                        if (products[j] >= lastNumber)
                        {
                            lastNumber--;
                        }
                        else
                        {
                            lastNumber = products[j];
                        }
                        sumProducts += lastNumber;
                        result = Math.Max(sumProducts, result);
                        if (lastNumber == 1)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    result = Math.Max(sumProducts, result);
                }
            }
            return result;
        }
    }
}

