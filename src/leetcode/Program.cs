ListNode node4 = new ListNode(9);
ListNode node3 = new ListNode(1) { next = node4 };
ListNode node2 = new ListNode(5) { next = node3 };
ListNode head = new ListNode(4) { next = node2 };
Problem.DeleteNode(node2);
Console.ReadKey();