namespace leetcode;
internal static partial class Problem
{
    public static int RomanToInt(string s)
    {
        // Using a switch statement instead of a dictionary for performance.
        // The switch statement is faster here because there are only 7 possible Roman numeral characters.
        // Compilers optimize switch statements for small, fixed sets like this, avoiding the overhead of a dictionary lookup.
        // The dictionary approach is still valid but slightly slower in this case.
        /*
        var romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        */

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // If there is a next value and the current value is less than the next one, subtract it
            if (i < s.Length - 1 && RomanLetterValue(s[i]) < RomanLetterValue(s[i + 1]))
                total -= RomanLetterValue(s[i]);
            else
                total += RomanLetterValue(s[i]);
        }

        return total;

        static int RomanLetterValue(char letter) => letter switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0 // Invalid character handling (optional, as input is guaranteed valid)
        };
    }

}
