/**
 * 1.3: URLify
 * Write a method to replace all spaces in a string with '%20'. You may assume
 * that the string has sufficient space at the end to hold the additional
 * characters, and that you are given the "true" length of the string.
 *
 * EXAMPLE
 * Input:   "Mr John Smith", 13
 * Output:  "Mr%20John%20Smith"
 */

public class URLify {
    public static void main(String[] args) {
        System.out.println(urlify(args[0]));
    }

    private static String urlify(String phrase) {
        StringBuilder s = new StringBuilder();
        for (int i = 0; i < phrase.length(); i++) {
            char ch = phrase.charAt(i);
            s.append(ch == ' ' ? "%20" : ch);
        }
        return s.toString();
    }
}
