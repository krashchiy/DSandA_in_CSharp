using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell<int> top = new Cell<int>();
            top.Value = 23;
            Cell<int> next = new Cell<int>();
            top.Next = next;
            next.Value = 33;

        }
    }
}
