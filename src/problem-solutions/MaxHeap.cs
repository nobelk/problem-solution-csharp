namespace DefaultNamespace;

public class MaxHeap
{
    public PriorityQueue<TreeNode, int> Queue { get; set; }
    
    public MaxHeap()
    {
        Queue = new PriorityQueue<TreeNode, int>(new MaxHeapComparer());
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