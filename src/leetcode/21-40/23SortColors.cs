internal static partial class Problem
{
    public static void SortColors(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
    }

    public static void QuickSort(int[] nums, int lo, int hi)
    {
        if (lo >= hi) return;

        var pivotIndex = Partition(nums, lo, hi);
        QuickSort(nums, lo, pivotIndex - 1);
        QuickSort(nums, pivotIndex + 1, hi);
    }

    private static int Partition(int[] nums, int lo, int hi)
    {
        var pivot = nums[hi];
        var index = lo - 1;

        for (int curr = lo; curr < hi; curr++)
        {
            if (nums[curr] <= pivot)
            {
                index++;

                (nums[index], nums[curr]) = (nums[curr], nums[index]);
            }
        }

        index++;
        (nums[index], nums[hi]) = (nums[hi], nums[index]);

        return index;
    }
}
