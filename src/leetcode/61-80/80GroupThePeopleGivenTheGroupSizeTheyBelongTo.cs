internal static partial class Problem
{
    public static IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var tempGroups = new Dictionary<int, List<int>>();
        var result = new List<IList<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            int size = groupSizes[i];
            if (!tempGroups.ContainsKey(size))
                tempGroups[size] = [];
            
            tempGroups[size].Add(i);

            if (tempGroups[size].Count == size)
            {
                result.Add([.. tempGroups[size]]); // result.Add(new List<int>(tempGroups[size])); is faster
                tempGroups[size].Clear();
            }
        }

        return result;
    }
}

/*
new List<int>(tempGroups[size]) vs [.. tempGroups[size]]

new List<int>(tempGroups[size]): This calls a constructor optimized to:
    Read Count once.
    Allocate an array of exactly the right size.
    Copy all elements in a single Array.Copy call (which uses fast memory copy instructions).


[.. tempGroups[size]]: The compiler expands it into code that:
    Creates a new list.
    Iterates through tempGroups[size] with an enumerator.
    Adds each element one-by-one using .Add().

 */