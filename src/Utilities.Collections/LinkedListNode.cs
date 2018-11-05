namespace Utilities.Collections
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode(T data) => Data = data;
        public override string ToString() => $"{Data}";
    }
}
