internal static partial class Problem
{
    public static void SortColorsBubbleSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                }
            }
        }
    }
}
