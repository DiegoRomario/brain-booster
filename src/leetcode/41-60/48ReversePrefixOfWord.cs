internal static partial class Problem
{
    public static string ReversePrefix(string word, char ch)
    {
        int right = word.IndexOf(ch);

        if (right == -1) return word;

        char[] source = word.ToCharArray();
        int left = 0;

        while (left < right)
        {
            (source[left], source[right]) = (source[right], source[left]);
            left++;
            right--;
        }

        return new string(source);
    }
}
