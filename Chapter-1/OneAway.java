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
        // |s1 - s2| = 1
        if (abs(s1.length() - s2.length()) == 1)
            return oneCharIsRemoved(s1, s2);
        // |s1 - s2| = 0
        return s1.equals(s2) ? true : oneCharIsReplaced(s1, s2);
    }

    private static boolean oneCharIsReplaced(String s1, String s2) {
        boolean foundOneDifference = false;
        for (int i = 0; i < s1.length(); i++) {
            if (s1.charAt(i) != s2.charAt(i)) {
                if (foundOneDifference)
                    return false;
                foundOneDifference = true;
            }
        }
        return true;
    }

    private static boolean oneCharIsRemoved(String s1, String s2) {
        // a = shorterOf(s1, s2), b = longerOf(s1, s2)
        String a = s1.length() > s2.length() ? s2 : s1;
        String b = s1.length() > s2.length() ? s1 : s2;

        int i = 0, j = 0;
        boolean foundOneDifference = false;
        while (i < a.length() && j < b.length()) {
            if (a.charAt(i) != b.charAt(j)) {
                if (foundOneDifference)
                    return false;
                foundOneDifference = true;
                j++;
            } else {
                i++; j++;
            }
        }
        return true;
    }
}
