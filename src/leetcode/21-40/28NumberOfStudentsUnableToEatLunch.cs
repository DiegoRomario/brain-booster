internal static partial class Problem
{
    public static int CountStudents(int[] students, int[] sandwiches)
    {
        int[] count = new int[2];

        // Count how many students want each type of sandwich
        foreach (int student in students) count[student]++;        

        // Go through the sandwich stack
        foreach (int sandwich in sandwiches)
        {
            if (count[sandwich] == 0) break; // No students want this type of sandwich

            count[sandwich]--;
        }

        // Remaining students who couldn't eat
        return count[0] + count[1];
    }
}

