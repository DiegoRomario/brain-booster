﻿internal static partial class Problem
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;  // Pointer for nums1 (excluding extra 0s)
        int j = n - 1;  // Pointer for nums2
        int k = m + n - 1;  // Pointer for the last position in nums1

        // Merge from the end to the beginning
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }

            k--;
        }

        // If there are remaining elements in nums2, copy them
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}