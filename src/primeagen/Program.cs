using primeagen;

bool[] floors =
 [false, false, false, false, false, false, true, true, true, true];

int result = Problem.FindBreakingPoint(floors);
Console.WriteLine("Breaking floor: " + result); // Expected output: 6