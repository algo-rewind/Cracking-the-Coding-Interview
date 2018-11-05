using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_04
    {
        public static void Partition(LinkedList<int> list, int partition)
        {
            var left = new LinkedList<int>();
            var right = new LinkedList<int>();

            foreach (int elem in list)
            {
                if (elem < partition)
                    left.Append(elem);
                else
                    right.Append(elem);
            }

            list.Clear();

            foreach (int elem in left)
                list.Append(elem);
            foreach (int elem in right)
                list.Append(elem);
        }
    }
}