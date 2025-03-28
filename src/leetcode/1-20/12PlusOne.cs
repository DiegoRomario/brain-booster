
internal static partial class Problem
{
    public static int[] PlusOne(int[] digits)
    {
        int lenght = digits.Length;

        for (int i = lenght - 1; i >= 0; i--)
        {
            // If the digit is less than 9, just increment it
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            // If the digit is 9, set it to 0 and carry 1
            digits[i] = 0;
        }

        // all digits were 9, so add a 1 at the beginning of a new array (all other positions starts with 0)
        int[] result = new int[lenght + 1];
        result[0] = 1;
        return result;
    }
}
