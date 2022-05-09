namespace CodeWars._5kyu.GetLoopSizeKata.WithoutRedColor;

public class Kata
{
    public static int GetLoopSize(LoopDetector.Node startNode)
    {
        LoopDetector.Node slowStep = startNode, fastStep = startNode;

        do
        {
            slowStep = slowStep.Next;
            fastStep = fastStep.Next.Next;
        } while (slowStep != fastStep);

        var head = fastStep;
        var tail = head.Next;
        var size = 1;
        
        while (head != tail)
        {
            tail = tail.Next;
            size++;
        }
        
        return size;
    }
}