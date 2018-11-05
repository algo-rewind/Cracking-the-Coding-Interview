using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_07
    {
        public static bool Intersection(LinkedList<int> listA, LinkedList<int> listB)
        {
            var hashset = new System.Collections.Generic.HashSet<LinkedListNode<int>>();
            
            var currentNode = listA.Head;
            while (currentNode != null)
            {
                hashset.Add(currentNode);
                currentNode = currentNode.Next;
            }

            currentNode = listB.Head;
            while (currentNode != null)
            {
                if (hashset.Contains(currentNode))
                    return true;
                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}