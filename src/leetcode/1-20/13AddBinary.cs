internal static partial class Problem
{
    public static string AddBinary(string a, string b)
    {
        int carry = 0;
        int lenA = a.Length - 1;
        int lenB = b.Length - 1;

        string result = string.Empty;

        while (carry > 0 || lenA >= 0 || lenB >= 0)
        {
            int bitA = (lenA >= 0) ? a[lenA] - '0' : 0;
            int bitB = (lenB >= 0) ? b[lenB] - '0' : 0;

            int sum = bitA + bitB + carry;

            int insert = sum % 2; // sum == 0 || sum == 2 then insert 0 / sum == 1 || sum == 3 then insert 1;
            result = insert + result;

            carry = sum / 2; // sum >= 2 ? 1 : 0; 

            lenA--;
            lenB--;
        }

        return result;
    }
}
