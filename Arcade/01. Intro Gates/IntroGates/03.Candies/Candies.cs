using System;

namespace _03.Candies
{
    class Candies
    {
        static void Main()
        {
            int[] testData_N = new int[] { 3, 1, 10, 4, 4, 9, 8, 3, 7, 3 };
            int[] testData_M = new int[] { 10, 2, 5, 4, 15, 100, 2, 3, 10, 23 };
            int[] expectedResult = new int[] { 9, 2, 0, 4, 12, 99, 0, 3, 7, 21 };

            for(int i = 0; i < 10; i++)
            {
                int n = testData_N[i];
                int m = testData_M[i];
                int result = candies(n, m);
                bool isPassing = result == expectedResult[i];

                Console.WriteLine($"{result}, is passing: {isPassing}");
            }
        }

        public static int candies(int n, int m)
        {
            int candiesPerChild = m / n;
            return candiesPerChild * n;
        }
    }
}
