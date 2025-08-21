using System.Xml.Linq;
using static Problem;



Node node2 = new() { val = 2, next = null, child = null  };
Node node3 = new() { val = 3, child = null, next = null };
Node head = new() { val = 1, next = node2, child = node3 };
node2.prev = head;
node3.prev = head;

Problem.Flatten(head);
Console.ReadKey();