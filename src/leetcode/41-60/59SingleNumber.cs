internal static partial class Problem
{
    public static int SingleNumber(int[] nums)
    {
        int accumulator = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            accumulator = nums[i] ^ accumulator;
        }

        return accumulator;
    }
}

/* XOR is a bitwise operator with useful properties: 
 - a ^ a = 0 (a number XORed with itself cancels out) 
 - a ^ 0 = a (XOR with zero returns the number itself) 
 - XOR is commutative and associative (order doesn’t matter) 

 This allows us to find the single number in an array where every other number appears twice. 
 As we XOR all elements, duplicates cancel out and only the unique number remains. 

 Binary example: 
   4 = 100 
   1 = 001 
   4 ^ 1 = 101 (which is 5 in decimal) 

 Binary to decimal conversion is based on powers of 2: 
   110 (binary) = 1×2² + 1×2¹ + 0×2⁰ = 4 + 2 + 0 = 6 

 Manual decimal-to-binary conversion: 
 Repeatedly divide the number by 2, and record the remainder at each step. 
 Stop when the quotient is 0, then read the remainders from bottom to top. 
 Example: converting 4 to binary 
 4 ÷ 2 = 2 → remainder 0 
 2 ÷ 2 = 1 → remainder 0 
 1 ÷ 2 = 0 → remainder 1 (stop) 
 Read bottom to top: 1 0 0 → binary = 100 

 In this solution, we use a single accumulator (initially 0) and XOR it with each number. 
 The result is the unique number, found in linear time and using constant extra space. */
