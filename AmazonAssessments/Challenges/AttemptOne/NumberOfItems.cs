namespace AmazonAssessments.Challenges.AttemptOne
{
    // Q 06: Coding Assessment Demo - Attempt 1 - C 02
    public static class NumberOfItems
    {
        public static List<int> Execute(string s, List<int> startIndices, List<int> endIndices)
        {
            var result = new List<int>();
            if(startIndices.Count != endIndices.Count)
            {
                return result;
            }
            for(var i = 0; i < startIndices.Count; i++)
            {
                var subS = s.Substring(startIndices[i] - 1, endIndices[i] - startIndices[i] + 1);
                var numOfItems = GetNumberOfItems(subS);
                if(numOfItems > 0)
                {
                    result.Add(numOfItems);
                }
            }
            return result;
        }
        private static int GetNumberOfItems(string s)
        {
            var numberOfItems = 0;
            var itemsInCompartment = 0;
            var startCompartment = false;
            for(var i = 0; i < s.Length; i++)
            {
                if (s[i] == '|' && startCompartment == false)
                {
                    startCompartment = true;
                }
                else if (s[i] == '|' && startCompartment == true)
                {
                    numberOfItems += itemsInCompartment;
                    itemsInCompartment = 0;
                }
                else if (s[i] == '*' && startCompartment == true)
                {
                    itemsInCompartment++;
                }
            }
            return numberOfItems;
        }
    }
}
