/* 1.4: Palindrome Permutation
 * Given a string, write a function to check if it is a permutation of a
 * palindrome. A palindrome is a word or phrase that is the same forwards and
 * backwards. A permutation is a rearrangement of letters. The palindrome does
 * not need to be limited to just dictionary words.
 *
 * EXAMPLE
 * Input:   Tact Coa
 * Output:  True (permutations: "taco cat", "atco cta", etc.)
 */

public class PalindromePermutation {
    public static void main(String[] args) {
        String cleanedString = removeSpacesAndCapitals(args[0]);
        System.out.println(isPallindromePermutation(cleanedString));
    }

    private static boolean isPallindromePermutation(String phrase) {
        boolean[] parityBitArray = new boolean[94]; // number of valid ASCII characters
        for (int i = 0; i < phrase.length(); i++) {
            int charIndex = phrase.charAt(i) - '!';
            parityBitArray[charIndex] = !parityBitArray[charIndex];
        }

        int parityCount = parityCounter(parityBitArray);
        if (phrase.length() % 2 == 0)
            return parityCount == 0;
        return parityCount == 1;
    }

    private static String removeSpacesAndCapitals(String phrase) {
        return phrase.replace(" ", "").toLowerCase();
    }

    private static int parityCounter(boolean[] parityBitArray) {
        int count = 0;
        for (int i = 0; i < parityBitArray.length; i++)
            if (parityBitArray[i])
                count++;
        return count;
    }
}
