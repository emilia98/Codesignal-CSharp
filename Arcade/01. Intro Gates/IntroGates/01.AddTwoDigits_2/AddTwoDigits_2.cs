using System;

namespace _01.AddTwoDigits_2
{
    class AddTwoDigits_2
    {
        static void Main()
        {
            int[] testData = new int[] { 29, 48, 10, 25, 52, 99, 44, 50, 39, 26 };
            int[] expectedResult = new int[] { 11, 12, 1, 7, 7, 18, 8, 5, 12, 8 };

            for (int i = 0; i < 10; i++)
            {
                var result = addTwoDigits(testData[i]);
                bool isPassing = result == expectedResult[i];

                Console.WriteLine($"{result}, is passing: {isPassing}");
            }
        }

        public static int addTwoDigits(int n)
        {
            char[] numAsChar = n.ToString().ToCharArray();
            int sum = (numAsChar[0] - '0') + (numAsChar[1] - '0');
            return sum;
        }
    }
}
