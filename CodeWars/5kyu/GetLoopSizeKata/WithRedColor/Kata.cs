namespace CodeWars._5kyu.GetLoopSizeKata;

public class Kata
{
    public static int GetLoopSize(LoopDetector.Node startNode)
    {
        var size = 0;
        var step = startNode;
        
        while (!step.IsRed)
        {
            step.IsRed = true;
            step = step.Next;
        }
        
        if (step.IsRed)
        {
            while (step.IsRed)
            {
                step.IsRed = false;
                step = step.Next;
                size++;
            }
        }
        
        return size;
    }
}