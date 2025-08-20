ListNode node4 = new (4, null);
ListNode node3 = new (3, node4);
ListNode node2 = new (2, node3);
ListNode head = new (1, node2);
Problem.InsertGreatestCommonDivisors(head);
Console.ReadKey();