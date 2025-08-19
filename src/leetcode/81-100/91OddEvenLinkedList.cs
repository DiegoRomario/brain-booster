internal static partial class Problem
{
    public static ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var odd = head;
        var even = head.next;
        var even_h = even;

        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        odd.next = even_h;

        return head;
    }
}
