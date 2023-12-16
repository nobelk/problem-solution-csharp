namespace DefaultNamespace;

using System.Collections;

public class MinHeap
{
    public PriorityQueue<TreeNode, int> Queue { get; set; }
    
    public MinHeap()
    {
        Queue = new PriorityQueue<TreeNode, int>();
    }

    public void Add(TreeNode node)
    {
        Queue.Enqueue(node, node.Val);
    }

    public int Peek()
    {
        return Queue.Peek().Val;
    }

    public TreeNode GetMin()
    {
        return Queue.Dequeue();
    }
}