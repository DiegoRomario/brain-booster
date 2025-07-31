internal static partial class Problem
{
    public static int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int left = 1;
        int right = position[position.Length - 1] - position[0];
        int answer = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (CanPlaceBalls(position,m, mid))
            {
                answer = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;

        static bool CanPlaceBalls(int[] position, int m, int mid)
        {
            int count = 1;
            int lastPos = position[0];

            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] - lastPos >= mid)
                {
                    count++;
                    lastPos = position[i];
                }

                if (count == m)
                    return true;
           }

           return false;
        }
    }

}
