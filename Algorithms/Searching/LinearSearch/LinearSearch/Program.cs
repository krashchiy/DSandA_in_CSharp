using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = new int[] {8, 4, 16, 256, 2, 64, 128, 32};

            bool result = LinearSearchSuccess(testData, 32);

            Console.WriteLine(result ? "Found it!" : "No Luck!");
        }

        public static bool LinearSearchSuccess(int[] array, int target)
        {
            foreach (int number in array)
            {
                if (number == target)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
