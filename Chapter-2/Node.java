// Linked list for problems in Ch2
public class Node<T> {

    private Node<T> link;
    private T info;
    private static int size;

    public Node() {
        this.link = null;
        this.info = null;
    }

    public Node(T info) {
        this.link = null;
        this.info = info;
    }

    public T getInfo() {
        return this.info;
    }

    public void setInfo(T info) {
        this.info = info;
    }

    public Node<T> getLink() {
        return this.link;
    }

    public void setLink(Node<T> link) {
        this.link = link;
    }

    public int size() {
        return size;
    }

    public boolean hasNext() {
        return this.link != null;
    }

    // Appends a Node to end of linked list
    public Node<T> add(T info) {
        Node<T> pointer = this;
        while (pointer.hasNext())
            pointer = pointer.link;
        pointer.link = new Node<T>(info);
        size++;
        return pointer.link;
    }

    public String toString() {
        Node<T> pointer = this;
        String s = "";

        while (pointer.hasNext()) {
            pointer = pointer.link;
            s += pointer.info.toString() + " ";
        }
        return s;
    }
}