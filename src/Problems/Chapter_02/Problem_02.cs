using Utilities.Collections;
using System;

namespace Problems.Chapter_02
{
    public class Problem_02
    {
        public static int ReturnKthToLast(LinkedList<int> list, int k)
        {
            // Denotes the xth element of the linked list (list is 1-indexed).
            int x = list.Length - k + 1;

            using (var e = list.GetEnumerator())
            {
                do { e.MoveNext(); }
                while (--x > 0);
                return e.Current;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}