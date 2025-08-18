ListNode node4 = new (9);
ListNode node3 = new (1) { next = node4 };
ListNode node2 = new (5) { next = node3 };
ListNode head = new (4) { next = node2 };
Problem.DeleteMiddle(head);
Console.ReadKey();