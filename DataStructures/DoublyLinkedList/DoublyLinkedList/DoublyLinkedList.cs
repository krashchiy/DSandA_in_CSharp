using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public Cell<T> First { get; set; }
        public Cell<T> Last { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {
            Count = 0;
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            Count = 0;
            Cell<T> last = null;

            foreach (var item in  collection)
            {
                if (First == null)
                {
                    this.First = new Cell<T>(item, this);
                    this.Last = First;
                }
                else
                {
                    var newCell = new Cell<T>(item, this);
                    last.Next = newCell;
                    newCell.Previous = last;
                    last = newCell;
                }
                Count++;
            }

            Last = last;

        }

        public Cell<T> AddFirst(T value)
        {
            var newCell = new Cell<T>(value);

            AddFirst(newCell);

            return newCell;
        }

        public void AddFirst(Cell<T> cell)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != null)
            {
                throw new InvalidOperationException("Node belongs to another list");
            }

            cell.List = this;
            cell.Previous = null;
            cell.Next = First;

            if (First != null)
            {
                First.Previous = cell;
            }

            First = cell;

            Count++;

            if (First.Next == null)
            {
                Last = First;
            }
        }

        public Cell<T> AddLast(T value)
        {
            if (Count == 0) return AddFirst(value);

            var newCell = new Cell<T>(value);

            AddLast(newCell);

            return newCell;
        }

        public void AddLast(Cell<T> cell)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != null)
            {
                throw new InvalidOperationException("This Cell belongs to another list");
            }

            if (Count != 0)
            {
                cell.List = this;
                cell.Next = null;
                cell.Previous = Last;
                Last.Next = cell;
                Last = cell;
                Count++;
            }
            else
            {
                AddFirst(cell);
            }
        }

        public Cell<T> AddBefore(Cell<T> cell, T value)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != this)
            {
                throw new InvalidOperationException("This cell doesn't belong to this list");
            }

            if (cell == First)
            {
                return AddFirst(value);
            }

            var newCell = new Cell<T>(value);

            AddBefore(cell, newCell);

            return newCell;
        }

        public void AddBefore(Cell<T> cell, Cell<T> newCell)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != this)
            {
                throw new InvalidOperationException("This cell doesn't belong to this list");
            }

            if (newCell == null)
            {
                throw new ArgumentNullException(nameof(newCell));
            }

            if (newCell.List != null)
            {
                throw new InvalidOperationException("The cell belongs to another list");
            }

            if (cell != First)
            {
                newCell.List = this;

                cell.Previous.Next = newCell;
                newCell.Previous = cell.Previous;

                newCell.Next = cell;
                cell.Previous = newCell;

                Count++;
            }
            else
            {
                AddFirst(newCell);
            }
        }

        public Cell<T> AddAfter(Cell<T> cell, T value)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != this)
            {
                throw new InvalidOperationException("node doesn't belong to this list");
            }

            if (cell == Last)
            {
                return AddLast(value);
            }

            var newCell = new Cell<T>(value);

            AddAfter(cell, newCell);

            return newCell;
        }
        public void AddAfter(Cell<T> cell, Cell<T> newCell)
        {
            if (cell == null)
            {
                throw new ArgumentNullException(nameof(cell));
            }

            if (cell.List != this)
            {
                throw new InvalidOperationException("node doesn't belong to this list");
            }

            if (newCell == null)
            {
                throw new ArgumentNullException(nameof(newCell));
            }

            if (newCell.List != null)
            {
                throw new InvalidOperationException("newNode belongs to another list");
            }

            if (cell == Last)
            {
                AddLast(newCell);
                return;
            }

            newCell.List = this;

            cell.Next.Previous = newCell;
            newCell.Next = cell.Next;

            newCell.Previous = cell;
            cell.Next = newCell;

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Cell<T> currentCell = this.First;
            while (currentCell != null)
            {
                yield return currentCell.Value;
                currentCell = currentCell.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
