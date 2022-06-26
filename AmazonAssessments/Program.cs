using AmazonAssessments.Challenges.Anthony;
using AmazonAssessments.Challenges.Michael;

namespace AmazonAssessments
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q 01: Anthony C 01

            Console.WriteLine("Start Q 01: Anthony C 01");

            var example1 = new List<int> { 2, 9, 10, 3, 7 };
            Console.WriteLine($"Result of Example: {GetHeaviestPackage.Execute(example1)}"); // 21
            var sampleCase01 = new List<int> { 20, 13, 8, 9 };
            Console.WriteLine($"Result of Sample Case 0: {GetHeaviestPackage.Execute(sampleCase01)}"); // 50
            var sampleCase11 = new List<int> { 30, 15, 5, 9 };
            Console.WriteLine($"Result of Sample Case 0: {GetHeaviestPackage.Execute(sampleCase11)}"); // 30

            Console.WriteLine("End Q 01: Anthony C 01 \n");

            #endregion

            #region Q 02: Anthony C 02

            Console.WriteLine("Start Q 02: Anthony C 02");

            var example2 = new List<int> { 1, 3, 6 };
            Console.WriteLine($"Result of Example: {CountPossibleSegments.Execute(3, example2)}"); // 5
            var sampleCase02 = new List<int> { 1, 5, 4 };
            Console.WriteLine($"Result of Sample Case 0: {CountPossibleSegments.Execute(3, sampleCase02)}"); // 4
            var sampleCase12 = new List<int> { 1, 10, 2 };
            Console.WriteLine($"Result of Sample Case 1: {CountPossibleSegments.Execute(9, sampleCase12)}"); // 6

            Console.WriteLine("End Q 02: Anthony C 02 \n");

            #endregion

            #region Q 03: Michael C 01

            Console.WriteLine("Start Q 03: Michael C 01");

            var example3 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Result of Example: {MaximumQuality.Execute(example3, 2)}"); // 8

            var sampleCase03 = new List<int> { 2, 2, 1, 5, 3 };
            Console.WriteLine($"Result of Sample Case 0: {MaximumQuality.Execute(sampleCase03, 2)}"); // 7

            var sampleCase13 = new List<int> { 1 };
            Console.WriteLine($"Result of Sample Case 1: {MaximumQuality.Execute(sampleCase13, 1)}"); // 1

            Console.WriteLine("End Q 03: Michael C 01 \n");

            #endregion

            #region Q 04: Michael C 02

            Console.WriteLine("Start Q 04: Michael C 02");

            var example4 = new List<int> { 7, 4, 5, 2, 6, 5 };
            Console.WriteLine($"Result of Example: {FindMaxProducts.Execute(example4)}"); // 12

            var sampleCase04 = new List<int> { 2, 9, 4, 7, 5, 2 };
            Console.WriteLine($"Result of Sample Case 0: {FindMaxProducts.Execute(sampleCase04)}"); // 16

            var sampleCase14 = new List<int> { 2, 5, 6, 7 };
            Console.WriteLine($"Result of Sample Case 1: {FindMaxProducts.Execute(sampleCase14)}"); // 20

            Console.WriteLine("End Q 04: Michael C 02 \n");

            #endregion

        }
    }
}