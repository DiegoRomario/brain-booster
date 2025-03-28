namespace leetcode;

internal static partial class Problem
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int lastUniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[lastUniqueIndex])
            {
                lastUniqueIndex++; // Move to the next position for the unique element
                nums[lastUniqueIndex] = nums[i]; // Place the unique element
            }
        }

        return lastUniqueIndex + 1; // The count of unique elements
    }
}