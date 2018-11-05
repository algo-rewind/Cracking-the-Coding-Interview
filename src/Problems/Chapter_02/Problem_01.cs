using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_01
    {
        public static void RemoveDups(LinkedList<int> list)
        {
            var setList = new LinkedList<int>();
            foreach (int elem in list)
                if (!setList.Contains(elem))
                    setList.Append(elem);
            
            list.Clear();

            foreach (int elem in setList)
                list.Append(elem);
        }
    }
}