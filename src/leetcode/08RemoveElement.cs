namespace leetcode;

internal static partial class Problem
{
    public static int RemoveElement(int[] nums, int val)
    {
        int validElements = 0; // Pointer for the position of the next valid element

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[validElements] = nums[i]; // Move valid element to the current position of validElements
                validElements++; // Increment the count of valid elements
            }
        }

        return validElements;
    }
}