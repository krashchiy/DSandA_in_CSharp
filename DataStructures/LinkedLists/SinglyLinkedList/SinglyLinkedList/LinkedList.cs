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
            if (Top.Next == null)
            {
                Top.Next = cell;
            }
            else
            {
                Cell<T> first = new Cell<T>();
                first.Next = Top.Next;
                first.Value = Top.Value;
                while (first.Next != null)
                {
                    first = first.Next;
                }

                first.Next = cell;
            }
        }

        public void AddAfter(Cell<T> target, Cell<T> cellToAdd)
        {
            cellToAdd.Next = target.Next;
            target.Next = cellToAdd;
        }

        public void DeleteCell(Cell<T> target)
        {
            Cell<T> targetsParent = FindTargetsParent(target);

            if (targetsParent.Next.Next != null)
            {
                targetsParent.Next = targetsParent.Next.Next;
            }
            else
            {
                targetsParent.Next = null;
            }
            
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

        private Cell<T> FindTargetsParent(Cell<T> target)
        {
            Cell<T> possibleParent = Top.Next;
            while (possibleParent.Next != null)
            {
                if (possibleParent.Next == target)
                {
                    return possibleParent;
                }
              
                possibleParent = possibleParent.Next.Next;
                
            }
           
            return new Cell<T>();
        }
    }
}
