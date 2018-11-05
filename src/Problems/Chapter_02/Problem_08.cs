using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_08
    {
        public static LinkedListNode<int> LoopDetection(LinkedList<int> list)
        {
            var hashset = new System.Collections.Generic.HashSet<LinkedListNode<int>>();
            var currentNode = list.Head;
            while (currentNode != null)
            {
                if (!hashset.Add(currentNode))
                    return currentNode;
            }
            
            // Returns null when it's not a circularly linked list.
            return null;
        }
    }
}