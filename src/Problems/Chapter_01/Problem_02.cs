namespace Problems.Chapter_01
{
    public class Problem_02
    {
        public static bool CheckPermutation(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            
            int[] charOccurrence = new int[125];
            for (int i = 0; i < s.Length; i++)
            {
                charOccurrence[s[i]]++;
                charOccurrence[t[i]]--;
            }

            foreach (var count in charOccurrence)
                if (count != 0)
                    return false;
            return true;
        }
    }
}
