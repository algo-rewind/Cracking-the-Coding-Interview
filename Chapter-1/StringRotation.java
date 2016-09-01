/**
 * 1.9: String Rotation
 * Assume you have a method isSubstring which checks if one word is a substring
 * of another. Given two strings, s1 and s2, write code to check if s2 is a
 * rotation of s1 using only one call to isSubstring (e.g. "waterbottle" is a
 * rotation of "erbottlewat").
 */

public class StringRotation {
    public static void main(String[] args) {
        // normal string
        String s1 = args[0];
        // rotated string
        String s2 = args[1];

        System.out.println(isRotation(s1, s2));
    }

    private static boolean isRotation(String s1, String s2) {
        if (s1.length() != s2.length())
            return false;
        String concatenated = s2 + s2;
        return concatenated.indexOf(s1) != -1;
    }
}
