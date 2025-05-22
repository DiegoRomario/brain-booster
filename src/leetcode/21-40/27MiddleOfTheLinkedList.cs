using static leetcode.Problem;

internal static partial class Problem
{
    public static ListNode MiddleNode(ListNode head)
    {
        var nodes = new ListNode[100];
        var index = 0;

        while (head != null)
        {
            nodes[index++] = head;
            head = head.next;
        }

        return nodes[index / 2];
    }
}
