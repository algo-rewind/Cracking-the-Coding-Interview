using System;

namespace Problems.Chapter_01
{
    public class Problem_09
    {
        public static bool StringRotation(string source, string candidate) => (candidate + candidate).Contains(source);
    }
}