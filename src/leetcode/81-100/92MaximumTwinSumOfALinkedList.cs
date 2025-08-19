internal static partial class Problem
{
    public static int PairSum(ListNode head)
    {
        // 1. Find the middle
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Reverse second half (starting from slow, which is the middle point)
        ListNode prev = null, curr = slow;
        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        // 3. Compare from both ends
        int answer = 0;
        ListNode left = head, right = prev;
        while (right != null)
        {
            answer = Math.Max(answer, left.val + right.val);
            left = left.next;
            right = right.next;
        }

        return answer;
    }

    public static int PairSumFaster (ListNode head)
    {
        // Reverse first half while finding the midpoint
        ListNode prev = null;
        ListNode curr = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;

            // Reverse step
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        // prev = head of reversed first half
        // curr = head of second half
        int answer = 0;
        while (curr != null)
        {
            answer = Math.Max(answer, curr.val + prev.val);
            curr = curr.next;
            prev = prev.next;
        }

        return answer;
    }
}
