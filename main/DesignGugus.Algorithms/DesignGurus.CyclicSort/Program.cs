// See https://aka.ms/new-console-template for more information

using DesignGurus.CyclicSort;

// === Cycling Sort ===
// Alg complexity O(N) + O(n-1) which is equal to O(N)
var originalArray = new int[] { 1,2,3,4,5,6,7,8,9};
originalArray.ShuffleAlgorithm();
Console.WriteLine(string.Join(',', originalArray));
originalArray.SortArray();
Console.WriteLine(string.Join(',', originalArray));

// === Find missing number ===
// We are given an array containing n distinct numbers taken from the range 0 to n.
// Since the array has only n numbers out of the total n+1 numbers,
// find the missing number.
//
// Example 1:
// Input: [4, 0, 3, 1]
// Output: 2
//
// Example 2:
// Input: [8, 3, 5, 2, 4, 6, 0, 1]
// Output: 7
var givenArray = new int[] {4, 0, 3, 1};
Console.WriteLine($"given array to find missing number: {string.Join(',', givenArray)}");
var missingNumberFound = Ex_2_Find_missing_number.SortAndFindMissingNumber(givenArray);
Console.WriteLine(missingNumberFound == -1 ? "all numbers are in place" : missingNumberFound);