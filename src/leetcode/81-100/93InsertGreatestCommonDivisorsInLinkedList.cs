internal static partial class Problem
{
    public static ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var current = head;

        while (current != null && current.next != null)
        {
            int gcdVal = GCD(current.val, current.next.val);

            // Insert new node with gcdVal between current and current.next
            var gcdNode = new ListNode(gcdVal, current.next);
            current.next = gcdNode;

            // Move to the node after the inserted one
            current = gcdNode.next;
        }

        return head;

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
