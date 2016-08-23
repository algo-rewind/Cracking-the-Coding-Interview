/* 1.5: One Away
 * There are three types of edits that can be performed on strings: insert a
 * character, remove a character, or replace a character. Given two strings,
 * write a function to check if they are one edit (or zero edits) away.
 *
 * EXAMPLE
 * pale, ple    -> true
 * pales, pale  -> true
 * pale, bale   -> true
 * pale, bake   -> false
 */
import static java.lang.Math.*;

public class OneAway {
    public static void main(String[] args) {
        String s1 = args[0];
        String s2 = args[1];
        System.out.println(isOneOrLessAway(s1, s2));
    }

    private static boolean isOneOrLessAway(String s1, String s2) {
        // |s1 - s2 | >= 2
        if (abs(s1.length() - s2.length()) >= 2)
            return false;

        boolean[] charSet = populateCharSet(s1, s2);
        // |s1 - s2| = 1
        if (abs(s1.length() - s2.length()) == 1)
            return oneCharIsRemoved(charSet);
        // |s1 - s2| = 0
        return s1.equals(s2) ? true : oneCharIsReplaced(charSet);
    }

    private static boolean[] populateCharSet(String s1, String s2) {
        boolean[] charSet = new boolean[95];
        for (char ch : s1.toCharArray())
            charSet[ch - ' '] = !charSet[ch - ' '];
        for (char ch : s2.toCharArray())
            charSet[ch - ' '] = !charSet[ch - ' '];
        return charSet;
    }

    private static boolean oneCharIsReplaced(boolean[] charSet) {
        return sumOfTruths(charSet) == 2;
    }

    private static boolean oneCharIsRemoved(boolean[] charSet) {
        return sumOfTruths(charSet) == 1;
    }

    private static int sumOfTruths(boolean[] arr) {
        int count = 0;
        for (boolean b : arr)
            if (b)
                count++;
        return count;
    }
}
