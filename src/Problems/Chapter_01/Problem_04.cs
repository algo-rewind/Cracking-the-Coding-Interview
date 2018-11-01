namespace Problems.Chapter_01
{
    public class Problem_04
    {
        public static bool PalindromePermutation(string s)
        {            
            var charOccurrence = new int[125];
            foreach (char ch in s)
                charOccurrence[ch] = charOccurrence[ch] == 0 ?
                    // A zero-count occurrence means we've encountered this character in 0 or more pairs so far.
                    charOccurrence[ch] + 1 :
                    
                    // A non-zero-count occurrence means we've encountered an odd number of this character so far.
                    charOccurrence[ch] - 1;

            // A sufficient condition to be a palindrome permutation is the following:
            // charOccurrence[i] == 0 for i in (0..n) || (charOccurrence[i] == 0 for i in (0..n) except i = j && charOccurrence[j] == 1)
            bool encounteredSingleton = false;
            foreach (int count in charOccurrence)
            {
                if (count == 0)
                    continue;
                if (count > 1)
                    return false;
                if (count == 1 && encounteredSingleton)
                    return false;
                encounteredSingleton = true;
            }
            return true;
        }
    }
}