namespace DoublyLinkedList
{
    public class Cell<T>
    {
        public T Value { get; set; }
        public Cell<T> Next { get; set; }
        public Cell<T> Previous { get; set; }
        public DoublyLinkedList<T> List { get; set; }

        public Cell(T value)
        {
            this.Value = value;
        }
        public Cell(T value, DoublyLinkedList<T> list)
        {
            this.Value = value;
            this.List = list;
        }

        public void AddAfter(Cell<T> cell)
        {

            // Set the new cells values to ours
            cell.Next = this.Next;
            cell.Previous = this;
            cell.Next.Previous = cell;

            // Set our Next value to the new cell
            this.Next = cell;
                
        }

        public void AddBefore(Cell<T> cell)
        {
            //Set the new cells values to ours
            cell.Previous = this.Previous;
            cell.Next = this;
            cell.Previous.Next = cell;

            //Set our Previous value to the new cell
            this.Previous = cell;
        }

        public void Remove()
        {
            this.Next.Previous = this.Previous;
            this.Previous.Next = this.Next;
        }

    }
}