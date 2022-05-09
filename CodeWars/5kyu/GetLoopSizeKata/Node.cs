namespace CodeWars._5kyu.GetLoopSizeKata;

public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}