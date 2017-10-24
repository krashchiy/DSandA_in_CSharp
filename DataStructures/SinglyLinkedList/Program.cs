using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        
            LinkedList<int> myList = new LinkedList<int>();
            Cell<int> myCell = new Cell<int>(){ Value = 18};
            myList.Add(myCell);
            Cell<int> myNextCell = new Cell<int>() { Value = 24 };
            myList.Add(myNextCell);
            Cell<int> myLastCell = new Cell<int>() { Value = 32 };
            myList.Add(myLastCell);
            Cell<int> firstCell = new Cell<int>() {Value = 26};
            myList.AddLeftCell(firstCell);

            Console.WriteLine("There are " + myList.Count().ToString() +" items in the LinkedList!");
            Console.ReadLine();

            List<int> results = myList.GetAllValues();
            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }

            Console.ReadLine();
        }
    }
}
