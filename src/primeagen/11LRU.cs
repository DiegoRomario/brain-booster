namespace primeagen
{
    public class Node<T>
    {
        public required T Value { get; set; }
        public Node<T>? Prev { get; set; }
        public Node<T>? Next { get; set; }
    }

    public class LRU<K, V>(int capacity) where K : notnull
    {
        private int _length;
        private Node<V>? _head;
        private Node<V>? _tail;
        private readonly Dictionary<K, Node<V>> _lookup = [];
        private readonly Dictionary<Node<V>, K> _reverseLookup = [];

        public void Update(K key, V value)
        {
            if (!_lookup.TryGetValue(key, out var node))
            {
                node = new Node<V> { Value = value };
                _length++;
                Prepend(node);
                TrimCache();

                _lookup[key] = node;
                _reverseLookup[node] = key;
            }
            else
            {
                Detach(node);
                Prepend(node);
                _reverseLookup.Remove(node);
                node.Value = value;
            }
        }

        public V? Get(K key)
        {
            if (!_lookup.TryGetValue(key, out var node))
                return default;

            Detach(node);
            Prepend(node);
            return node.Value;
        }

        private void Detach(Node<V> node)
        {
            if (node.Prev is not null)
                node.Prev.Next = node.Next;

            if (node.Next is not null)
                node.Next.Prev = node.Prev;

            if (_length == 1)
                (_head, _tail) = (null, null);

            if (_head == node)
                _head = node.Next;

            if (_tail == node)
                _tail = node.Prev;

            node.Next = node.Prev = null;
        }

        private void Prepend(Node<V> node)
        {
            if (_head is null)
            {
                _head = _tail = node;
                return;
            }

            node.Next = _head;
            _head.Prev = node;
            _head = node;
        }

        private void TrimCache()
        {
            if (_length <= capacity)
                return;

            var tail = _tail!;
            Detach(tail);

            var key = _reverseLookup[tail];
            _lookup.Remove(key);
            _reverseLookup.Remove(tail);
            _length--;
        }
    }
}
