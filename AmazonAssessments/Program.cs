using AmazonAssessments.Challenges.Anthony;
using AmazonAssessments.Challenges.AttemptOne;
using AmazonAssessments.Challenges.AttemptTwo;
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

            #region Q 05: Coding Assessment Demo - Attempt 1 - C 01

            Console.WriteLine("Start Q 05: Coding Assessment Demo - Attempt 1 - C 01");

            var example5 = new List<int> { 3, 7, 5, 6, 2 };
            Console.WriteLine($"Result of Example: {string.Join(',', MinimalHeaviestSetA.Execute(example5))}"); // [6,7]

            var sampleCase05 = new List<int> { 5, 3, 2, 4, 1, 2 };
            Console.WriteLine($"Result of Sample Case 0: {string.Join(',', MinimalHeaviestSetA.Execute(sampleCase05))}"); // [4,5]

            Console.WriteLine("End Q 05: Coding Assessment Demo - Attempt 1 - C 01 \n");

            #endregion

            #region Q 06: Coding Assessment Demo - Attempt 1 - C 02

            Console.WriteLine("Start Q 06: Coding Assessment Demo - Attempt 1 - C 02");

            var example6 = "|**|*|*";
            Console.WriteLine($"Result of Example: {string.Join(',', NumberOfItems.Execute(example6, new List<int> { 1, 1 }, new List<int> { 5, 6 }))}"); // [2,3]

            var sampleCase06 = "*|*|";
            Console.WriteLine($"Result of Sample Case 0: {string.Join(',', NumberOfItems.Execute(sampleCase06, new List<int> { 1 }, new List<int> { 3 }))}"); // [0]

            var sampleCase16 = "*|*|*|";
            Console.WriteLine($"Result of Sample Case 1: {string.Join(',', NumberOfItems.Execute(sampleCase16, new List<int> { 1 }, new List<int> { 6 }))}"); // [2]

            Console.WriteLine("End Q 06: Coding Assessment Demo - Attempt 1 - C 02 \n");

            #endregion

            #region Q 07: Coding Assessment Demo - Attempt 2 - C 01

            Console.WriteLine("Start Q 07: Coding Assessment Demo - Attempt 2 - C 01");

            var example7 = new List<string> { "88 99 200", "88 99 300", "99 32 100", "12 12 15" };
            Console.WriteLine($"Result of Example: {string.Join(',', ProcessLogs.Execute(example7, 2))}"); // ["88","99"]

            var sampleCase07 = new List<string> { "1 2 50", "1 7 70", "1 3 20", "2 2 17" };
            Console.WriteLine($"Result of Sample Case 0: {string.Join(',', ProcessLogs.Execute(sampleCase07, 2))}"); // ["1","2"]

            var sampleCase17 = new List<string> { "9 7 50", "22 7 20", "33 7 50", "22 7 30" };
            Console.WriteLine($"Result of Sample Case 1: {string.Join(',', ProcessLogs.Execute(sampleCase17, 3))}"); // ["7"]

            Console.WriteLine("End Q 07: Coding Assessment Demo - Attempt 2 - C 01 \n");

            #endregion

            #region Q 07: Coding Assessment Demo - Attempt 2 - C 01

            Console.WriteLine("Start Q 08: Coding Assessment Demo - Attempt 2 - C 02");

            var example8 = new List<string> { "110", "110", "001" };
            Console.WriteLine($"Result of Example: {string.Join(',', CountGroups.Execute(example8))}"); // 2

            var sampleCase08 = new List<string> { "1100", "1110", "0110", "0001" };
            Console.WriteLine($"Result of Sample Case 0: {string.Join(',', CountGroups.Execute(sampleCase08))}"); // 2

            var sampleCase18 = new List<string> { "10000", "01000", "00100", "00010", "00001" };
            Console.WriteLine($"Result of Sample Case 1: {string.Join(',', CountGroups.Execute(sampleCase18))}"); // 5

            Console.WriteLine("End Q 08: Coding Assessment Demo - Attempt 2 - C 02 \n");

            #endregion

        }
    }
}
