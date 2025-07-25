using System.Security.Cryptography;

internal static partial class Problem
{
    public static int MinFlips(int a, int b, int c)
    {
        int flips = 0;

        /* Loop continues while there's at least one bit still set in a, b, or c.
           (a | b | c) != 0 means: stop only when all bits are zero.
           We're checking one bit at a time from the least significant bit (rightmost). */
        while ((a | b | c) != 0)
        {
            /* Get the least significant bit (LSB) of a, b, and c.
               This is done using bitwise AND with 1:
               - (x & 1) returns 1 if the last bit is 1, else returns 0. 
               - If a is even, the last bit is always 0, so a & 1 = 0.
                 If a is odd, the last bit is 1, so a & 1 = 1. */
            int aBit = a & 1;
            int bBit = b & 1;
            int cBit = c & 1;

            /* If c's bit is 0:
               - Both a and b must also have 0 in that bit.
               - So if ai or bi is 1, we need to flip it to 0.
               - Total flips added: ai + bi */
            if (cBit == 0)
                flips += aBit + bBit;
            else
            {
                /* If c's bit is 1:
                   - At least one of a or b must be 1 to satisfy (a | b) == 1.
                   - If both are 0, we must flip one of them to 1 → add 1 flip. */
                if (aBit == 0 && bBit == 0)
                    flips++;
            }

            /* Shift all three numbers to the right by 1 bit to process the next bit.
                This is equivalent to integer division by 2 (dropping the remainder).
                For example: a >>= 1 means a = a / 2 */
            a >>= 1;
            b >>= 1;
            c >>= 1;
        }

        return flips;

    }
}
