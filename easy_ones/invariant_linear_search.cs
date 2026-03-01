/*from p. 25 (intro to algo) 

"Consider the searching problem:
  Input: A sequence of n numbers (a1, a2, ..., an) stored in array A[1..n] and a
    value x .
  Output: An index i such that x equals A[i] or the special value NIL if x does not
    appear in A.
[First, w]rite pseudocode for linear search, which scans through the array from begin-
ning to end, looking for x. Using a loop invariant, prove that your algorithm is
correct. Make sure that your loop invariant fulfills the three necessary properties."

Then I'll implement the linear search in C# and show how it works with an example.

three properties of loop invariant:
1. Initialization: The invariant is true prior to the first iteration of the loop.
2. Maintenance: If the invariant is true before an iteration of the loop, it remains true before the next iteration.
3. Termination: When the loop terminates, the invariant gives us a useful property that helps show that the algorithm is correct.

pseudocode for linear search:
let's say an array [5, 3, 2, 8, 1] and we want to find the index of the value 2.
LINEAR-SEARCH(A[n], x)
  for i = 1 to n
    if A[i] == x
      return i
  return NIL
*/

//implementation of linear search in C#
class LinearSearch
{
  public static int LinearSearchMethod(int[] arr, int x)
  {
    int n = arr.Length; 
    for (int i = 0; i < n; i++) //What must be true every time we start a new iteration at index i?
    {
      if (arr[i] == x) //invariant: At the start of iteration i, x does not appear in arr[0..i-1]
      {
        return i;
      }    
    }
        return -1; // NIL equivalent in C#
  }
  /*
  Why this works
Initialization (i = 0):
  Before the first iteration, arr[0..-1] is an empty set.
  It’s vacuously true that x is not there.
Maintenance:
  If arr[i] != x, we move to i+1.
  So now we know x is not in arr[0..i].
  The invariant still holds.
Termination:
  If the loop finishes (i = n), then we know:
  x is not in arr[0..n-1] → so returning -1 is correct.

If we return early, we found it at the smallest index where it occurs.
  */
}


//example of how to use the linear search method
class Program
{
  public static void Main(string[] args)
  {
    int[] an_array = { 5, 3, 2, 8, 1 }; // Initialize an array with unsorted elements
    int x = 2; // The value we want to find in the array
    int result = LinearSearch.LinearSearchMethod(an_array, x); // Call the linear search method
    Console.WriteLine("The index of " + x + " is: " + result); // Print the result
  }
}