namespace DefaultNamespace;

using System.Collections;
using System.Collections.Generic;

public class LevelOrderTraversal
{
    public static List<List<int>> traverse(TreeNode root)
    {
        List<List<int>> result = new List<List<int>>();

        if (root == null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            List<int> currLevel = new List<int>();

            for (int i = 0; i < levelCount; i++)
            {
                TreeNode currNode = queue.Dequeue();
                currLevel.Add(currNode.Val);
                if (currNode.Left != null)
                {
                    queue.Enqueue(currNode.Left);
                }
                if (currNode.Right != null)
                {
                    queue.Enqueue(currNode.Right);
                }
            }
            result.Add(currLevel);
        }

        return result;
    }
}