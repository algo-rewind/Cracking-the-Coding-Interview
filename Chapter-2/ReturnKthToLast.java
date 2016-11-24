/**
 * 2.2: Return Kth to Last
 * Implement an algorithm to find the kth to last element of a singly linked 
 * list.
 */

public class ReturnKthToLast {
    public static void main(String[] args) {
        Node<String> list = new Node<>();
        list.add("A").add("B").add("C").add("D").add("E").add("F").add("G");

        Node<String> temp;
        for (int i = 0; i < 7; i++) {
            temp = getKthToLast(list, i);

            // should print G, F, E, D, C, B, A
            System.out.println(temp.getInfo());
        }
    }

    private static Node<String> getKthToLast(Node<String> header, int k) {
        Node<String> pointer = header;
        int n = pointer.size();

        for (int i = 0; i < n - k; i++)
            pointer = pointer.getLink();
        return pointer;
    }
}