using System.Runtime.CompilerServices;

namespace SinglyLinkedList
{
    public class Cell<T>
    {
        public T Value;
        public Cell<T> Next;

        public void AddAfter(Cell<T> cell)
        {
            cell.Next = this.Next;
            this.Next = cell;

        }
    }
}