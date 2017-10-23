using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>() {105, 21, 13, 41, 15, 61, 17, 81, 19, 101, 99, 112, 1};

            List<int> result = BubbleSort(myInts);

            foreach (int number in result)
            {
                Console.WriteLine(number.ToString());
            }
        
            Console.ReadLine();

        }

        private static List<int> BubbleSort(List<int> myInts)
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
    }
}
