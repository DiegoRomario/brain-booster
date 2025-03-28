namespace leetcode;

internal static partial class Problem
{
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int middleIndex = (left + right) / 2;
            int middleElement = nums[middleIndex];

            if (middleElement == target)
                return middleIndex;
            else if (target > middleElement)
                left = middleIndex + 1;
            else // target < middleElement
                right = middleIndex - 1;
        }

        return left;
    }
}
