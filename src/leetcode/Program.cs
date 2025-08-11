var counter = new Problem.RecentCounter();
Console.WriteLine(counter.Ping(1));
Console.WriteLine(counter.Ping(100));
Console.WriteLine(counter.Ping(3001));
Console.WriteLine(counter.Ping(3002));
Console.ReadKey();