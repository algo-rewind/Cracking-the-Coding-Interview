using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_06
    {
        public static bool Palindrome(LinkedList<int> list)
        {
            var stack = new Stack<int>();

            using (var e = list.GetEnumerator())
            {
                for (int i = 0; i < list.Length / 2; i++)
                {
                    e.MoveNext();
                    stack.Push(e.Current);
                }
                if (list.Length % 2 != 0)
                    e.MoveNext();
                for (int i = 0; i < list.Length / 2; i++)
                {
                    e.MoveNext();
                    if (!stack.Pop().Equals(e.Current))
                        return false;
                }
            }
            return true;
        }
    }
}