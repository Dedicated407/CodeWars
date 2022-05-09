namespace CodeWars._5kyu.GetLoopSizeKata;

public class LoopDetector
{
    public class Node
    {
        public Node Next { get; set; }
        public bool IsRed { get; set; } = false;
    }

    public static Node CreateChain(int tailSize, int loopSize)
    {
        var startNode = new Node();
        var nextNode = new Node();
        startNode.Next = nextNode;
        startNode.IsRed = true;

        int count = 1;
        bool flag = true;

        while (flag)
        {
            var node = new Node();
            nextNode.Next = node;
            nextNode.IsRed = true;
            nextNode = node;
            count++;
            
            if (count == tailSize)
            {
                flag = false;
            }
        }

        var testNode = nextNode;
        
        for (int i = 0; i < loopSize - 1; i++)
        {
            var node = new Node();
            nextNode.Next = node;
            nextNode.IsRed = false;
            nextNode = node;
        }

        nextNode.Next = testNode;
        nextNode.IsRed = false;
        
        return testNode;
    }
}