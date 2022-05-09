namespace CodeWars._5kyu.GetLoopSizeKata.WithoutRedColor;

public class LoopDetector
{
    public class Node {
        public Node Next { get; set; }
    }
    
    public static Node CreateChain(int tailSize, int loopSize) {
        Node prevNode = new Node();
        Node start = prevNode;
        start.Next = start;
        if (loopSize == 1) {
            return start;
        }
        for (int i = 1; i <= tailSize; ++i) {
            prevNode.Next = new Node();
            prevNode = prevNode.Next;
        }
        Node endLoop = prevNode;
        for (int i = 1; i < loopSize; ++i) {
            prevNode.Next = new Node();
            prevNode = prevNode.Next;
        }
        prevNode.Next = endLoop;
        return start;
    }
}