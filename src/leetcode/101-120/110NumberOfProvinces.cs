internal static partial class Problem
{
    public static int FindCircleNum(int[][] isConnected)
    {
        int len = isConnected.Length;
        int provinces = 0;
        bool[] visited = new bool[len];

        for (int i = 0; i < len; i++)
        {
            if (visited[i] == false)
            {
                provinces++;
                DFS(i);
            }
        }

        return provinces;

        void DFS(int i)
        {
            visited[i] = true;
            for (int j = 0; j < len; j++)
            {
                if (isConnected[i][j] == 1 && visited[j] == false)
                {
                    DFS(j);
                }
            }
        }
    }
}

