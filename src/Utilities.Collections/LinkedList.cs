using System.Collections;
using System.Collections.Generic;

namespace Utilities.Collections
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public int Length { get; set; }

        public LinkedList() {}

        public LinkedList(T[] arr)
        {
            foreach (T elem in arr)
            {
                this.Append(elem);
            }
        }

        private bool IsEmpty() => Length == 0;
        
        public void Append(T data)
        {
            var node = new LinkedListNode<T>(data);
            if (IsEmpty())
            {
                Head = node;
            }
            else
            {
                var currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = node;
            }
            Length++;
        }

        public void Append(LinkedListNode<T> node)
        {
            if (IsEmpty())
            {
                Head = node;
            }
            else
            {
                var currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = node;
            }
            Length++;
        }

        public void Prepend(T data)
        {
            var node = new LinkedListNode<T>(data);
            if (IsEmpty())
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Length++;
        }

        public void Prepend(LinkedListNode<T> node)
        {
            if (IsEmpty())
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Length++;
        }

        public bool Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Length--;
                return true;
            }
            else
            {
                var currentNode = Head;
                while (currentNode.Next != null)
                {
                    if (currentNode.Next.Data.Equals(data))
                    {
                        currentNode.Next = currentNode.Next.Next;
                        Length--;
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
            }

            return false;
        }

        public bool Contains(T data)
        {
            foreach (T elem in this)
                if (data.Equals(elem))
                    return true;
            return false;
        }

        public void Clear()
        {
            Head = null;
            Length = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode.Data;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}