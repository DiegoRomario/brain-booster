using primeagen;

MinHeap minHeap = new();

Console.WriteLine("Inserting values: 5, 3, 8, 1, 2");
minHeap.Insert(5);
minHeap.Insert(3);
minHeap.Insert(8);
minHeap.Insert(1);
minHeap.Insert(2);

Console.WriteLine($"Heap Length: {minHeap.Length}");

Console.WriteLine("Deleting elements (should come out in ascending order):");

while (minHeap.Length > 0)
{
    int minValue = minHeap.Delete();
    Console.WriteLine(minValue);
}

Console.WriteLine("Heap is empty now.");

Console.WriteLine(new string('_', 40));
Console.WriteLine();

MaxHeap maxHeap = new();

Console.WriteLine("Inserting values: 5, 3, 8, 1, 2");
maxHeap.Insert(5);
maxHeap.Insert(3);
maxHeap.Insert(8);
maxHeap.Insert(1);
maxHeap.Insert(2);

Console.WriteLine($"Heap Length: {maxHeap.Length}");

Console.WriteLine("Deleting elements (should come out in descending order):");
while (maxHeap.Length > 0)
{
    int maxValue = maxHeap.Delete();
    Console.WriteLine(maxValue);
}

Console.WriteLine("Heap is empty now.");