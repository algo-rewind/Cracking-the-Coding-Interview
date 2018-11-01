namespace Problems.Chapter_01
{
    public class Problem_05
    {
        public static bool OneAway(string s, string t) => LevenshteinDistance(s, s.Length, t, t.Length) == 1;

        public static int LevenshteinDistance(string s, int len_s, string t, int len_t)
        {
            if (len_s == 0) return len_t;
            if (len_t == 0) return len_s;

            int cost = s[len_s - 1] != t[len_t - 1] ? 1 : 0;

            return Minimum(
                LevenshteinDistance(s, len_s - 1, t, len_t    ) + 1,
                LevenshteinDistance(s, len_s    , t, len_t - 1) + 1,
                LevenshteinDistance(s, len_s - 1, t, len_t - 1) + cost
            );
        }

        public static int Minimum(params int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
    }
}