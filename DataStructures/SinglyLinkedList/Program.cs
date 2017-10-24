using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        
            LinkedList<string> myList = new LinkedList<string>();
            Cell<string> myCell = new Cell<string>(){ Value = "Food"};
            myList.Add(myCell);
            Cell<string> myNextCell = new Cell<string>() { Value = "Love" };
            myList.Add(myNextCell);
            Cell<string> myLastCell = new Cell<string>() { Value = "Don't" };
            myList.Add(myLastCell);
            Cell<string> firstCell = new Cell<string>() {Value = "I"};
            myList.AddLeftCell(firstCell);
            Cell<string> finalCell = new Cell<string>() {Value = "Sike"};
            myList.AddRightCell(finalCell);

            myList.DeleteCell(myLastCell);
            myList.DeleteCell(finalCell);
            Cell<string> randomCell = new Cell<string>(){Value = "Always"};
            myList.AddAfter(firstCell, randomCell);

            Console.WriteLine("There are " + myList.Count().ToString() +" items in the LinkedList!");
            Console.ReadLine();

            List<string> results = myList.GetAllValues();
            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }

            Console.ReadLine();
        }
    }
}
