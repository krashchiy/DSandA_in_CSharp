using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace SinglyLinkedList
{
    public class LinkedList<T>
    {
        public Cell<T> Top = new Cell<T>();

        public void Add(Cell<T> cell)
        {
            if (Top.Next != null)
            {
                Cell<T> nextCell = Top.Next;
                Top.Next = cell;
                cell.Next = nextCell;
            }
            else
            {
                Top.Next = cell;
                cell.Next = null;
            }

        }

        public void AddLeftCell(Cell<T> cell)
        {
            this.Add(cell);
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

        public int Count()
        {
            int myCount = 0;
            Cell<T> first = new Cell<T>();
            first.Next = Top.Next;
            while (first.Next != null)
            {
                myCount++;
                first = first.Next;

            }

            return myCount;
        }

        public List<T> GetAllValues()
        {
            List<T> Values = new List<T>();

            Cell<T> first = new Cell<T>();
            first.Next = Top.Next;
            first.Value = Top.Value;
            while (first.Next != null)
            {
                first = first.Next;
                Values.Add(first.Value);
            }

            return Values;
        }
    }
}
