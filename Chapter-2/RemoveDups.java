/**
 * 2.1: Remove Dups
 * Write code to remove duplicates from an unsorted list. How would you solve
 * this problem if a temporary buffer is not allowed?
 */
import java.util.Hashtable;

public class RemoveDups {
    public static void main(String[] args) {
        Node<String> ulist = new Node<>();
        // list = REF -> A > B > C > D > A > B > E > F > B > D > G > E > NULL
        ulist.add("A").add("B").add("C").add("D").add("A").add("B")
             .add("E").add("F").add("B").add("D").add("G").add("E");

        clean(ulist);

        // list should be = REF -> A > B > C > D > E > F > G > NULL
        System.out.println(ulist);

        // corner cases

        // Zero elems
        ulist = new Node<String>();
        clean(ulist);
        System.out.println(ulist);

        // One elem
        ulist = new Node<String>();
        ulist.add("A");
        clean(ulist);
        System.out.println(ulist);

        // all same elems
        ulist = new Node<String>();
        ulist.add("A").add("A").add("A").add("A");
        clean(ulist);
        System.out.println(ulist);
    }

    private static void clean(Node<String> header) {
        Node<String> pointer = header;
        Hashtable<String, Boolean> ht = new Hashtable<>();
        
        while (pointer.hasNext()) {
            String info = pointer.getLink().getInfo();
            if (!ht.containsKey(info)) {
                ht.put(info, true);
                pointer = pointer.getLink();
            }
            else
                pointer.setLink(pointer.getLink().getLink());
        }
    }
}