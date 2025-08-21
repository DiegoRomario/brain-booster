internal static partial class Problem
{
    public static Node Flatten(Node head)
    {
        var stack = new Stack<Node>();
        var dummy = new Node
        {
            next = head
        };
        var curr = dummy;

        while (curr is not null)
        {
            if (curr.child is not null)
            {
                if (curr.next is not null) 
                    stack.Push(curr.next);
                
                curr.child.prev = curr;
                curr.next = curr.child;
                curr.child = null;
            }

            if (curr.next is null && stack.Count > 0)
            {
                var nextInStack = stack.Pop();
                nextInStack.prev = curr;
                curr.next = nextInStack;
            }

            curr = curr.next;
        }

        return dummy.next;
    }

    public static Node FlattenRecursively(Node head)
    {
        Node current = head;
        while (current != null)
        {
            if (current.child != null)
            {
                Node tempNext = current.next;
                Node newNext = FlattenRecursively(current.child);
                current.child = null;
                // Connect start
                current.next = newNext;
                newNext.prev = current;
                // Connect end
                current = newNext;
                while (current.next != null)
                    current = current.next;
                
                if (tempNext != null) 
                    tempNext.prev = current;

                current.next = tempNext;
            }
            current = current.next;
        }
        return head;
    }
}