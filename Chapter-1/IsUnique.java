/**
 * 1.1: Is Unique
 * Implement an algorithm to determine if a string has all unique characters.
 * What if you cannot use additional data structures?
 */

public class IsUnique {
    public static void main(String[] args) {
        // with an additional data structure
        System.out.println(isUnique(args[0]));

        // without an additional data structure
        System.out.println(isUnique(args[0].toCharArray()));
    }

    private static boolean isUnique(String phrase) {
        boolean[] charSet = new boolean[95]; // all ASCII characters
        for (int i = 0; i < phrase.length(); i++) {
            if (charSet[phrase.charAt(i) - ' '])
                return false;
            charSet[phrase.charAt(i) - ' '] = true;
        }
        return true;
    }

    private static boolean isUnique(char[] phrase) {
        java.util.Arrays.sort(phrase);
        for (int i = 0; i < phrase.length - 1; i++)
            if (phrase[i] == phrase[i + 1])
                return false;
        return true;
    }
}
