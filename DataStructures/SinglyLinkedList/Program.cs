using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    public class LinkedList<T>{
        public Cell<T> Top { get; set; }

        public void AddLeftCell(Cell<T> cell)
        {
            //Add to the right of top
        }

        public void AddRightCell(Cell<T> cell)
        {
            //Find Right Most Cell
        }

        private Cell<T> FindRightMostCell()
        {
            return new Cell<T>();
        }

        private Cell<T> FightLeftMostCell()
        {
            return new Cell<T>();
        }
    }
}
