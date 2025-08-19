ListNode node4 = new (4);
ListNode node3 = new (3) { next = node4 };
ListNode node2 = new (2) { next = node3 };
ListNode head = new (1) { next = node2 };
Problem.PairSum(head);
Console.ReadKey();