namespace AmazonAssessments.Challenges.Anthony
{
    // Q 01: Anthony C 01
    public static class GetHeaviestPackage
    {
        public static long Execute(List<int> packageWeights)
        {
            var mergedPackages = MergedPackages(packageWeights);
            return mergedPackages.Max();
        }

        private static List<int> MergedPackages(List<int> packageWeights)
        {
            var packageWeightsArray = packageWeights.ToArray();
            while (true)
            {
                int max = int.MinValue;
                int index = 0;
                int[] mergedPackageWeights = new int[packageWeightsArray.Length - 1];
                for (int i = 1; i < packageWeightsArray.Length; i++)
                {
                    if (packageWeightsArray[i - 1] < packageWeightsArray[i])
                    {
                        if (packageWeightsArray[i - 1] + packageWeightsArray[i] > max)
                        {
                            max = packageWeightsArray[i - 1] + packageWeightsArray[i];
                            index = i - 1;
                        }
                    }
                }
                if (max == int.MinValue)
                {
                    break;
                }
                int j = 0;
                for (int i = 0; i < mergedPackageWeights.Length; i++)
                {
                    if (i != index)
                    {
                        mergedPackageWeights[i] = packageWeightsArray[j];
                        j++;
                    }
                    else
                    {
                        j += 2;
                        mergedPackageWeights[i] = max;
                    }
                }
                packageWeightsArray = mergedPackageWeights;
            }
            return packageWeightsArray.ToList();
        }
    }
}
