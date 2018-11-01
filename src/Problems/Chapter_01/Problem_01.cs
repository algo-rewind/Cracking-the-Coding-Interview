using System.Collections.Generic;

namespace Problems.Chapter_01
{
    public class Problem_01
    {
        public static bool IsUnique(string s)
        {
            var chars = new HashSet<char>();
            foreach (char ch in s)
                if(!chars.Add(ch))
                    return false;
            return true;
        }
    }
}
