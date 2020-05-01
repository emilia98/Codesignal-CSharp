using System;

namespace _02.LargestNumber_2
{
    class LargestNumber_2
    {
        static void Main()
        {
            int[] testData = new int[]
            {
                2, 1, 7, 4, 3
            };
            int[] expectedResult = new int[]
            {
                99, 9, 9999999, 9999, 999
            };

            for (int i = 0; i < 5; i++)
            {
                var result = largestNumber(testData[i]);
                var isPassing = result == expectedResult[i];

                Console.WriteLine($"{result}, is passing: {isPassing}");
            }
        }

        public static int largestNumber(int n)
        {
            return int.Parse(new String('9', n));
        }
    }
}
