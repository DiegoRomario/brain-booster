namespace primeagen;
internal static partial class Problem
{
    public static void QuickSort(int[] arr)
    {
        Qs(arr, 0, arr.Length - 1);
    }

    // Recursive function that sorts the array between indices lo and hi
    private static void Qs(int[] arr, int lo, int hi)
    {
        // Base case: subarray with 0 or 1 element is already sorted
        if (lo >= hi) return;

        // Partition the array and get the final position of the pivot
        int pivotIdx = Partition(arr, lo, hi);

        // Recursively sort elements before and after the pivot
        Qs(arr, lo, pivotIdx - 1);   // left side
        Qs(arr, pivotIdx + 1, hi);   // right side
    }

    // Reorganizes the subarray so that all elements <= pivot are to its left,
    // and all elements > pivot are to its right
    private static int Partition(int[] arr, int lo, int hi)
    {
        int pivot = arr[hi];     // choose the last element as pivot
        int partitionIndex = lo - 1; // index for elements <= pivot

        for (int currentIndex = lo; currentIndex < hi; currentIndex++)
        {
            // If current element is <= pivot, move it to the left partition
            if (arr[currentIndex] <= pivot)
            {
                partitionIndex++;
                // Swap arr[currentIndex] with the element at partitionIndex
                (arr[partitionIndex], arr[currentIndex]) = (arr[currentIndex], arr[partitionIndex]);
            }
        }

        // Place the pivot just after the last element <= pivot
        partitionIndex++;
        (arr[partitionIndex], arr[hi]) = (arr[hi], arr[partitionIndex]);
        return partitionIndex; // Return the final position of the pivot
    }
}


