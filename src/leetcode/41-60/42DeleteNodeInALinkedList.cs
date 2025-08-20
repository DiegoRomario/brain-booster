internal static partial class Problem
{
    public static void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;       
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
    public ListNode(int x, ListNode next) { val = x; this.next = next; }
}



