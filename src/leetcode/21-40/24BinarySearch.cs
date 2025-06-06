﻿internal static partial class Problem
{
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (nums[middle] > target) right = middle - 1;            
            else if (target > nums[middle]) left = middle + 1;            
            else return middle;
        }

        return -1;
    }
}
