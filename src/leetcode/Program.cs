var cache = new LRUCache(2);

cache.Put(2, 1);
cache.Put(2, 2);
Console.WriteLine("Get(2): " + cache.Get(2)); // 2

cache.Put(1, 1);
cache.Put(4, 1);

Console.WriteLine("Get(2): " + cache.Get(2)); // -1 (evicted)