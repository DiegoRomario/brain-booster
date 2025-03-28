namespace leetcode;

internal static partial class Problem
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        /* Using temp ensures you maintain a fixed anchor (temp) that points to the head of the resulting list.
           While current is used to traverse and build the list, temp is your guaranteed way to retrieve the full list once processing is complete.
           Without the temp node, there's no consistent way to maintain the head reference if current keeps moving.
           That's why temp and current = temp are used together. */

        // Create a temp node to serve as the starting point of the merged list
        ListNode temp = new();
        ListNode current = temp;

        // Traverse both lists while both have nodes
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        // Append any remaining nodes from either list
        current.next = list1 ?? list2;

        // Return the merged list starting from the first real node (after temp)
        return temp.next;
    }


    public class ListNode(int val = 0, ListNode next = null)
    {
        public int val = val;
        public ListNode next = next;
    }
}