int[] nums = [9, 4, 9, 8, 4];
int[] nums2 = [4, 9, 5];

var result = Problem.Intersect(nums, nums2);

foreach (int number in result)
{
    Console.WriteLine(number);
}