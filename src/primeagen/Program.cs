using primeagen;

// Example array to sort
int[] arr = { 4, 7, 3, 2, 1, 8, 6, 5 };

// Display the array before sorting
Console.WriteLine("Before QuickSort: " + string.Join(", ", arr));

// Call the QuickSort method
Problem.QuickSort(arr);

// Display the array after sorting
Console.WriteLine("After QuickSort: " + string.Join(", ", arr));