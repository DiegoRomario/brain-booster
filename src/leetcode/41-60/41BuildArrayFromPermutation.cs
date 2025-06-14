internal static partial class Problem
{
    public static int[] BuildArray(int[] nums)
    {
        var res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            num = nums[num];            
            res[i] = num; 
        }

        return res;
    }
}



