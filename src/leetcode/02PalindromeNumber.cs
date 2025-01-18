namespace leetcode;

internal static partial class Problem
{
    public static bool IsPalindrome(int x)
    {
        // Negative numbers and numbers ending in 0 (except 0 itself) are not palindromes
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversedHalf = 0;

        // Reverse only half of the number
        while (x > reversedHalf)
        {
            reversedHalf = (reversedHalf * 10) + (x % 10);
            x /= 10;
        }

        // Compare the original half with the reversed half
        return x == reversedHalf || x == reversedHalf / 10;
    }
}

