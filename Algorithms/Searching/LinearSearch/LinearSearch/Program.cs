using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288 };

            bool result = LinearSearchSuccess(testData, 8192);

            Console.WriteLine(result ? "Found it!" : "No Luck!");
            Console.ReadLine();
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
