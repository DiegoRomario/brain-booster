internal static partial class Problem
{
    public static int FindTheWinner(int n, int k)
    {
        var q = new Queue<int>();

        // Fill the queue with players 1..n
        for (int i = 1; i <= n; i++)
        {
            q.Enqueue(i);
        }

        // Repeat until only one player remains
        while (q.Count > 1)
        {
            // Rotate k-1 people to the back of the queue
            for (int i = 1; i < k; i++)
            {
                q.Enqueue(q.Dequeue());
            }

            // Remove the k-th person
            q.Dequeue();
        }

        // Return the last remaining player
        return q.Dequeue();
    }

    public static int FindTheWinnerJosephusProblem(int n, int k) // https://en.wikipedia.org/wiki/Josephus_problem
    {
        var result = 0;
        for (var i = 2; i <= n; i++)
        {
            result = (result + k) % i;
        }

        return result + 1;
    }

}
