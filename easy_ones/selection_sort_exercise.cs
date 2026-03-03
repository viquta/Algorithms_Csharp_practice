/*
p. 33 (Thomas et al)

2.2-2
Consider sorting n numbers stored in array A[1.. n] by first finding the smallest
element of A[1.. n] and exchanging it with the element in A[1]. Then find the
smallest element of A[2.. n], and exchange it with A[2]. Then find the smallest
element of A[3.. n], and exchange it with A[2]. 

Continue in this manner for the first n - 1 elements of A. 

Write pseudocode [and then in C#] for this algorithm, which is known as selection sort. What loop 
invariant does this algorithm maintain? Why does it need to run for only the first
n - 1 elements, rather than for all n elements? 

Give the worst-case running time of selection sort in Theta-notation. Is the best-case 
running time any better?
*/

/*
my pseudocode:
selection_sort(A)
  for i = 1 ..A.length - 1
    min_index = i
    for j = i + 1 .. A.length
      if A[j] < A[min_index]
        min_index = j
    swap A[i] and A[min_index]

loop invariant: at the start of each iteration of the outer loop, the subarray A[1.. i - 1] consists of the elements originally in A[1.. i - 1], but in sorted order.
*/

using System;
class SelectionSort
{
  public static void selection_sort(int[] arr)
  {
    for (int i = 0; i < arr.Length - 1; i++)
    {
      int min_index = i;
      //debug: show the current state of the array and the current index i
      //Console.WriteLine("Current array: " + string.Join(", ", arr) + " | Current index i: " + i);
      for (int j = i + 1; j < arr.Length; j++)
      {
        if (arr[j] < arr[min_index])
        {
          min_index = j;
        }
      }
      //swap arr[i] and arr[min_index]
      int temp = arr[i];
      arr[i] = arr[min_index];
      arr[min_index] = temp;
    }
  }
}
class Program
{
  public static void Main(string[] args)
  {
    int[] an_array = { 5, 3, 2, 8, 1, 4, 7, 6, 9, 11, 10, 12, 18, 77, 176, 19, 23, 45, 67, 89, 34, 56, 78, 90, 21, 43, 65, 87, 32, 54, 76, 98}; // Initialize an array with unsorted elements
    SelectionSort.selection_sort(an_array); // Call the selection sort method
    Console.WriteLine("Sorted array: " + string.Join(", ", an_array)); // Print the sorted array
  }
}