/**
 * 1.2: Check Permutation
 * Given two strings, write a method to decide if one is a permutation of the
 * other.
 */

public class CheckPermutation {
    public static void main(String[] args) {
        System.out.println(arePermutations(args[0], args[1]));
    }

    private static boolean arePermutations(String s, String t) {
        if (s.length() != t.length())
            return false;

        boolean[] charSet = new boolean[95]; // all ASCII characters
        for (int i = 0; i < s.length(); i++)
            charSet[s.charAt(i) - ' '] = true;
        for (int i = 0; i < t.length(); i++)
            if (!charSet[t.charAt(i) - ' '])
                return false;
        return true;
    }
}
