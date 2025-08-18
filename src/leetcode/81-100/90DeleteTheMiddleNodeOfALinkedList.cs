internal static partial class Problem
{
    public static ListNode DeleteMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        if (head == null || head.next == null)
            return null;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = slow.next;

        return head;
    }

    public static ListNode DeleteMiddleWithOutPrev(ListNode head)
    {
        var slow = head;
        if (head == null || head.next == null) return null;

        ListNode fast = head.next.next;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return head;
    }
}
