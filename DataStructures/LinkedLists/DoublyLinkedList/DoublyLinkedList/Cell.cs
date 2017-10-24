namespace DoublyLinkedList
{
    public class Cell<T>
    {
        public T Value { get; set; }

        public Cell<T> Next { get; set; }
    
        public Cell<T> Previous { get; set; }
    }
}
