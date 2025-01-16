namespace leetcode;
internal static partial class Problem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> visitedNumbers = [];

        for (int index = 0; index < nums.Length; index++)
        {
            var x = target - nums[index];

            if (visitedNumbers.TryGetValue(x, out int value)) return [index, value];

            visitedNumbers[nums[index]] = index;
        }

        return [];
    }
}
