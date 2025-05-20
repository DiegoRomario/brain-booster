using static leetcode.Problem;

internal static partial class Problem
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr is not null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        
        return prev;
    }

    public static ListNode ReverseListRecursive(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        var newHead = ReverseListRecursive(head.next);

        head.next.next = head;
        head.next = null;

        return newHead;
    }
}