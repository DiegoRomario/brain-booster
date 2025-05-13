
using primeagen;

var lru = new LRU<string, int>(3);

lru.Update("foo", 69);
lru.Update("bar", 420);
lru.Update("baz", 1337);
lru.Update("ball", 69420);

Console.WriteLine(lru.Get("foo"));