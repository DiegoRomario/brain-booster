

using leetcode;
using static leetcode.Problem;

var item1 = new ListNode(10);
var item2 = new ListNode(5, item1);
var item3 = new ListNode(1, item2);

var item4 = new ListNode(7);
var item5 = new ListNode(5, item4);
var item6 = new ListNode(3, item5);

var result = Problem.MergeTwoLists(item3, item6);

while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
