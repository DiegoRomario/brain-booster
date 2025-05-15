internal static partial class Problem
{
    public static void MoveZeroes(int[] nums) {

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length -i; j++)
            {
                if (nums[j] == 0) (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);                
            }
        }
    }

    public static void MoveZeroesImproved(int[] nums) {
        int position = 0;

        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];

            if (curr != 0) {
                nums[i] = 0;
                nums[position] = curr;
                position++;
            }
        }
    }
}
