/**
 * 2.6: Palindrome
 * Implement a function to check if a linked list is a palindrome.
 */
import java.util.Stack;

public class Palindrome {
    public static void main(String[] args) {
        Node<String> header = new Node<>();
        header.add("A").add("A").add("B").add("B").add("A").add("A").add("C");
        System.out.println(isPallindrome(header));
    }

    private static boolean isPallindrome(Node<String> header) {
        int n = header.size();

        Node<String> pointer = header;
        Stack<String> stack = new Stack<>();

        for (int i = 0; i < n / 2; i++) {
            pointer = pointer.getLink();
            stack.push(pointer.getInfo());
        }
        if (n % 2 == 1) {
            pointer = pointer.getLink();
        }
        for (int i = 0; i < n / 2; i++) {
            pointer = pointer.getLink();

            String s1 = pointer.getInfo();
            String s2 = stack.pop();
            if (!s1.equals(s2))
                return false;
        }
        return true;
    }
}