internal static partial class Problem
{
    public static string ReverseOnlyLetters(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1) return s;

        char[] word = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (char.IsLetter(word[left]))
            {
                left++;
            }
            else if (char.IsLetter(word[right]))
            {
                right--;
            }
            else
            {
                (word[right], word[left]) = (word[left], word[right]);
            }
        }

        var response = word.ToString();
        return response;
    }
}
