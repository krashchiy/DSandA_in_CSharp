using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aaron's List
            LinkedList<string> myList = new LinkedList<string>();
            Cell<string> myCell = new Cell<string>() { Value = "Food" };
            myList.Add(myCell);
            Cell<string> myNextCell = new Cell<string>() { Value = "Love" };
            myList.Add(myNextCell);
            Cell<string> myLastCell = new Cell<string>() { Value = "Don't" };
            myList.Add(myLastCell);
            Cell<string> firstCell = new Cell<string>() { Value = "I" };
            myList.AddLeftCell(firstCell);
            Cell<string> finalCell = new Cell<string>() { Value = "Sike" };
            myList.AddRightCell(finalCell);

            myList.DeleteCell(myLastCell);
            myList.DeleteCell(finalCell);
            Cell<string> randomCell = new Cell<string>() { Value = "Always" };
            myList.AddAfter(firstCell, randomCell);

            Console.WriteLine("There are " + myList.Count().ToString() + " items in the LinkedList!");
            Console.ReadLine();

            List<string> results = myList.GetAllValues();
            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }

            //Igor's list
            AltLinkedList<string> myList2 = new AltLinkedList<string>();
            Nody<string> myCell2 = new Nody<string>() { Val = "Food" };
            myList2.Attach(myCell2);
            Nody<string> myNextCell2 = new Nody<string>() { Val = "Love" };
            myList2.Attach(myNextCell2);
            Nody<string> myLastCell2 = new Nody<string>() { Val = "Don't" };
            myList2.Attach(myLastCell2);
            Nody<string> firstCell2 = new Nody<string>() { Val = "I" };
            myList2.Attach(firstCell2);
            Nody<string> finalCell2 = new Nody<string>() { Val = "Sike" };
            myList2.AttachFirst(finalCell2);

            myList2.Delete(myLastCell2);
            myList2.Delete(finalCell2);
            Nody<string> randomCell2 = new Nody<string>() { Val = "Always" };
            myList2.AttachAfter(firstCell2, randomCell2);

            Console.WriteLine("There are " + myList2.Records.ToString() + " items in the LinkedList!");
            Console.ReadLine();

            //Results will be in reverse order so use Stack
            Stack<string> results = myList2.GetValues();
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
