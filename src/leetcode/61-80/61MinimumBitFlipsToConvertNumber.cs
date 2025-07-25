using System.Numerics;

internal static partial class Problem
{
    public static int MinBitFlips(int start, int goal)
    {
        int xor = start ^ goal;
        int count = 0;

        while (xor != 0)
        {
            count += xor & 1; // Add 1 if the last bit is 1
            xor >>= 1;       // Shift right to check next bit (xor = xor >> 1;)
        }

        return count;

        /* (Alternatives: built -in bit count for .NET Core 3.0 +): return BitOperations.PopCount((uint)(start ^ goal)); 
           OR 
            string xor = Convert.ToString(start ^ goal,2);
            int count = 0;

            foreach (char c in xor)
            {
                if (c == '1') count++;
            }

            return count;
            bit less performant
         */

    }
}
