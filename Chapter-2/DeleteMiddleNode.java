public class DeleteMiddleNode {
    public static void main(String[] args) {
        Node<String> list = new Node<String>();
        list.add("A").add("B").add("C").add("D").add("E");

        Node<String> node = list.get(2);
        delete(node);

        // should be REF -> A > B > D > E
        System.out.println(list);
    }

    private static void delete(Node<String> node) {
        Node<String> nextNode = node.getLink();
        node.setInfo(nextNode.getInfo());
        node.setLink(nextNode.getLink());
    }
}