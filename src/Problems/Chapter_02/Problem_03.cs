using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_03
    {
        public static void DeleteMiddleNode(LinkedListNode<int> node)
        {
            // NOTE: Deleting a node by directly accessing it screws up the length of the list.
            node.Data = node.Next.Data;
            node.Next = node.Next.Next;
        }
    }
}