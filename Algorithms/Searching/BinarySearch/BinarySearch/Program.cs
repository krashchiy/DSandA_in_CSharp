using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288 };

            bool result = BinarySearchSuccess(testData, 131072);

            Console.WriteLine(result ? "Found it!" : "No Luck!");
            Console.ReadLine();
        }

        private static bool BinarySearchSuccess(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min < max)
            {
                int mid = (min + max) / 2;

                if (target == array[mid])
                {
                    return true;
                }
               
                if (target < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
               
            }

            return false;
        }
    }
}
