internal static partial class Problem
{
    public class RecentCounter
    {
        private readonly Queue<int> q;

        public RecentCounter()
        {
            q = [];
        }

        public int Ping(int t)
        {
            q.Enqueue(t);
            while (q.Peek() < t - 3000)
            {
                q.Dequeue();
            }
            return q.Count;
        }
    }

    public class RecentCounterWithOutQueue
    {
        private List<int> _list;
        private int _count;
        private int _start;
        public RecentCounterWithOutQueue()
        {
            _list = [];
            _count = 0;
            _start = 0;
        }
        public int Ping(int t)
        {
            _list.Add(t);
            _count++;
            while (_list[_start] < t - 3000)
            {
                _start++;
                _count--;
            }
            return _count;
        }
    }

}
