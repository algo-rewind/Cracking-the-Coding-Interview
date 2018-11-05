using System;

namespace Utilities.Collections
{
    public class Stack<T>
    {
        private class StackNode
        {
            public T Data { get; set; }
            public StackNode Next { get; set; }
            public StackNode(T data) => Data = data;
            public override string ToString() => $"{Data}";
        }

        private StackNode Top { get; set; }
        public int Length { get; set; }

        public bool IsEmpty() => Length == 0;

        public void Push(T data)
		{
			var stacknode = new StackNode(data);
			stacknode.Next = Top;
			Top = stacknode;
			Length++;
		}

		public T Peek()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Cannot Peek() from an empty stack.");

			return Top.Data;
		}

		public T Pop()
		{
			if (IsEmpty())
				throw new InvalidOperationException("Cannot Pop() from an empty stack.");

			var data = Top.Data;
			Top = Top.Next;
			Length--;

			return data;
		}

    }
}