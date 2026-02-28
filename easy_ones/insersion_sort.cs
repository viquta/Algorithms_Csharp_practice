/*

Claude: What is Insertion Sort?
Insertion Sort is a simple sorting algorithm 
that builds the final sorted array one item at a time.

The algorithm works by dividing the array into a sorted and an unsorted part.

Initially, the sorted part contains only the first element of the array,
and the unsorted part contains the rest of the elements.

pseudo code for insertion sort (see p. 19 in Thomas H et al)):
INSERTION-SORT(A, n)
  for i = 2 to n
    key = A[i]
    //Insert A[i] into the sorted sequence A[1..i-1]
    j = i - 1
    while j >0 and A[j] > key
      A[j + 1] = A[j]
      j = j - 1
    A[j + 1] = key

*/
//implementation of insertion sort in C# 
//author: Victor 
//co-author: Claude 
class InsertionSort
{
  //main method - entry point of the program 
    public static void Main(string[] args)
  {
    //here ill show the example of the insertion sort algorithm
    int[] arr = { 12, 11, 13, 5, 6 }; // Initialize an array with unsorted elements
    Console.WriteLine("Original array:"); // Print the original array
    PrintArray(arr); // Call the method to print the array  
    InsertionSort sorter = new InsertionSort(); // Create an instance of the InsertionSort class
    sorter.sort_decr(arr); // Call the sort method to sort the array in decreasing order
    Console.WriteLine("Sorted array:"); // Print the sorted array
    PrintArray(arr); // Call the method to print the sorted array

    InsertionSort sorter2 = new InsertionSort(); // Create another instance of the InsertionSort class
    sorter2.sort_incr(arr); // Call the sort method to sort the array in increasing order
    Console.WriteLine("Sorted array in increasing order:"); // Print the sorted array in increasing order
    PrintArray(arr); // Call the method to print the sorted array in increasing order
  }

  //method to perform insertion sort in decreasing order
  void sort_decr (int[] arr) 
  //why use void? --> because this method does not return any value, 
  // it modifies the input array in place.
  {
    int n = arr.Length; // Get the length of the array
    //loop through the array starting from the second element
    for (int i = 1; i < n; i++)
    {
      int key = arr[i]; // Store the current element as key
      int j = i - 1; // Initialize j to the index of the last sorted element
      //why j and i? --> i is the index of the current element being sorted, 
      // and j is used to traverse the sorted part of the array to find the correct position for the key.

      // Move elements of arr[0..i-1], that are less than key,
      // to one position ahead of their current position
      while (j >= 0 && arr[j] < key) //if j is >= than 0 and j < i
      {
        //this console.writeline is for debugging, you can put a breakpoint on it to see how the algorithm works step by step
        Console.WriteLine($"Comparing {arr[j]} and {key}"); // Print the comparison being made
        arr[j + 1] = arr[j]; // Shift the element at index j to the right (to index j + 1)
        j = j - 1; // Decrement j to check the next element in the sorted part of the array
      }
      arr[j + 1] = key; // Place the key in its correct position in the sorted part of the array
    }
  }

  static void PrintArray(int[] arr) // Method to print the elements of the array
{
    foreach (int val in arr)
    {
        Console.Write(val + " ");
    }
    Console.WriteLine();
}

/*
Exercise: Rewrite the INSERTION-SORT procedure to sort into monotonically increasing in-
stead of monotonically decreasing order.
*/
void sort_incr (int[] arr) //same as sort_decr but change the comparison operator in the while loop to > instead of <
  {
    int n = arr.Length; 
    for (int i = 1; i < n; i++)
    {
      int key = arr[i]; 
      int j = i - 1; 

      while (j >= 0 && arr[j] > key) // Change the comparison operator to > for increasing order
      {
        Console.WriteLine($"Comparing {arr[j]} and {key}"); 
        arr[j + 1] = arr[j]; 
        j = j - 1; 
      }
      arr[j + 1] = key;
    }
  }
}
