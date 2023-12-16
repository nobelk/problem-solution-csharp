using System.Collections;

namespace DefaultNamespace;

public class MaxHeapComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x < y)
            return 1;
        else if (x > y)
            return -1;
        else
            return 0;
    }
}