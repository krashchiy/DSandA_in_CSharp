using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStrings = new List<string> {"APE", "APPLE", "A", "B", "C","apple", "ape", "F","E", "o","n","m","l","k","j","i","h","g","f","e","d","c","b","a","9","8","7","6","5","4","3","2","1" };
            

            List<string> StringsResult = BubbleSortStrings(myStrings);

            foreach (string character in StringsResult)
            {
                Console.Write(character + " ");
            }
        
            Console.ReadLine();


            List<int> myInts = new List<int> {16, 2, 128, 512, 1024, 256, 63, 32, 8, 4};

            List<int> IntsResult = BubbleSortInts(myInts);
            foreach (int number in IntsResult)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();

        }

        private static List<int> BubbleSortInts(List<int> myInts)
        {
            while (1==1)
            {
                bool Swapping = true;

                // Repeat forever:
                while (Swapping)
                {
                    bool swappedThisLoop = false;

                    // Scan through the list
                    for (int i = 0; i < myInts.Count - 1; i++)
                    {
                        // If two adjacent items are out of order, swap them
                        if (myInts[i] > myInts[i+1])
                        {
                            int temp = myInts[i];
                            myInts[i] = myInts[i+1];
                            myInts[i+1] = temp;
                            swappedThisLoop = true;
                        }
                    }

                    // If you finish the scan without a swap, you're done
                    Swapping = swappedThisLoop;
                }

                break;
            }

            return myInts;
        }
        private static List<string> BubbleSortStrings(List<string> myStrings)
        {
            while (1 == 1)
            {
                bool Swapping = true;

                // Repeat forever:
                while (Swapping)
                {
                    bool swappedThisLoop = false;

                    // Scan through the list
                    for (int i = 0; i < myStrings.Count - 1; i++)
                    {
                        // If two adjacent items are out of order, swap them
                        if (string.Compare(myStrings[i], myStrings[i + 1]) < 0)
                        {
                            string temp = myStrings[i];
                            myStrings[i] = myStrings[i + 1];
                            myStrings[i + 1] = temp;
                            swappedThisLoop = true;
                        }

                    }

                    // If you finish the scan without a swap, you're done
                    Swapping = swappedThisLoop;
                }

                break;
            }

            return myStrings;
        }
    }
}
