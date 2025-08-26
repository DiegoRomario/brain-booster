internal static partial class Problem
{
    public class Node2
    {
        public int val;
        public IList<Node2> children;

        public Node2() { }

        public Node2(int _val)
        {
            val = _val;
        }

        public Node2(int _val, IList<Node2> _children)
        {
            val = _val;
            children = _children;
        }
    }
}