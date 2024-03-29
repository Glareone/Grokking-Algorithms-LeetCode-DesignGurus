﻿using DesignGugus.TwoPointers;

// ========== SUM OF TWO POINTERS ================
var arrayForSumOfTwo = new [] { 1, 2, 3, 4, 6 };

// Using pointers.
// Complexity: O(n).
// Memory: O(1);
var (leftIndex, rightIndex) = arrayForSumOfTwo.GetElementIndexesWithSum(6);
Console.WriteLine("========== SUM OF TWO POINTERS ================");
Console.WriteLine($"original array: {string.Join(',', arrayForSumOfTwo)}");
Console.WriteLine($"using two pointers: [{leftIndex}, {rightIndex}]");
// Using Dictionary
// Complexity: O(n);
// Memory: O(n);
var (leftIndexHash, rightIndexHash) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(6);
Console.WriteLine($"using hashmap/dictionary: [{leftIndexHash}, {rightIndexHash}]");
arrayForSumOfTwo = new [] { 2, 5, 9, 11 };
// Using pointers.
// Complexity: O(n).
// Memory: O(1);
var (leftIndex2, rightIndex2) = arrayForSumOfTwo.GetElementIndexesWithSum(11);
Console.WriteLine($"original array: {string.Join(',', arrayForSumOfTwo)}");
Console.WriteLine($"using two pointers: [{leftIndex2}, {rightIndex2}]");
// Using Dictionary
// Complexity: O(n);
// Memory: O(n);
var (leftIndexHash2, rightIndexHash2) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(11);
Console.WriteLine($"using hashmap/dictionary: [{leftIndexHash2}, {rightIndexHash2}]");
Console.WriteLine("=============================");

// ====== Find Non Duplicate Subarray Length in Sorted Array
// Space Complexity: O(1)
// Time complexity: O(n)
var arrayToFindNonDuplicateArrayLength = new [] { 2, 3, 3, 3, 6, 9, 9 };
Console.WriteLine("====== Find Non Duplicate Subarray Length in Sorted Array ========");
Console.WriteLine($"original array: {string.Join(',', arrayToFindNonDuplicateArrayLength)}");
Console.WriteLine($"length on unique elements is: {arrayToFindNonDuplicateArrayLength.GetLengthOfSubArrayWithUniqueElementsSortedArray()}");
Console.WriteLine($"array: {string.Join(',', arrayToFindNonDuplicateArrayLength)}");

arrayToFindNonDuplicateArrayLength = new[] { 2, 2, 2, 11 };
Console.WriteLine($"original array: {string.Join(',', arrayToFindNonDuplicateArrayLength)}");
Console.WriteLine($"length on unique elements is: {arrayToFindNonDuplicateArrayLength.GetLengthOfSubArrayWithUniqueElementsSortedArray()}");
Console.WriteLine($"array: {string.Join(',', arrayToFindNonDuplicateArrayLength)}");
Console.WriteLine("=============================");

// ====== Find Non Duplicate Subarray Length in Unsorted Array
// Space Complexity: O(1)
// Time Complexity: O(n)
var arrayGeAllElementsNotEqualToKeyUnsortedArray = new [] { 3, 2, 3, 6, 3, 10, 9, 3 };
var key = 3;
Console.WriteLine($"====== Find Non Duplicate Subarray Length in Unsorted Array =========");
Console.WriteLine($"original array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine($"length of sub array with elements not equal to key {key} is: {arrayGeAllElementsNotEqualToKeyUnsortedArray.GetNumberOfElementsNotEqualToKeyUnsortedArray(key)}");
Console.WriteLine($"array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
arrayGeAllElementsNotEqualToKeyUnsortedArray = new [] { 2, 11, 2, 2, 1 };
key = 2;
Console.WriteLine($"original array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine($"length of sub array with elements not equal to key: {key} : {arrayGeAllElementsNotEqualToKeyUnsortedArray.GetNumberOfElementsNotEqualToKeyUnsortedArray(key)}");
Console.WriteLine($"array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine("=============================");

// == Given a sorted array,
// Create a new array containing squares of all the numbers of the input array in the sorted order.
// Memory Complexity: O(n)
// Time Complexity: O(n)
var originalSortedArrayToSquare = new int[] { -2, -1, 0, 2, 3 };
var originalSortedArrayToSquare2 = new int[] { -3, -1, 1, 1, 2 };
Console.WriteLine($"== Given a sorted array, Create a new array containing squares of all the numbers of the input array in the sorted order =========");
Console.WriteLine($"original array: {string.Join(',', originalSortedArrayToSquare)}");
Console.WriteLine($"squared array: {string.Join(',', originalSortedArrayToSquare.GetSquaringSortedArray())}");
Console.WriteLine($"original array: {string.Join(',', originalSortedArrayToSquare2)}");
Console.WriteLine($"squared array: {string.Join(',', originalSortedArrayToSquare2.GetSquaringSortedArray())}");
Console.WriteLine("=============================");

// ===== Given a sorted array, find closest recursive =====
// Memory Complexity: O(1)
// Time Complexity: O(n)
var originalArrayToFindClosestRecursive = new int[] { 0, 1, 2, 4, 8, 10, 12, 15, 20 };
Console.WriteLine($"===== Given an array, find closest recursive =====");
Console.WriteLine($"original array {string.Join(',', originalArrayToFindClosestRecursive)}");
var closestTo = 5;
Console.WriteLine($"find closest to {closestTo}");
Console.WriteLine($"closest: {FindClosestRecursive.DoFindClosestRecursive(originalArrayToFindClosestRecursive, 0, originalArrayToFindClosestRecursive.Length - 1, closestTo)}");
closestTo = 30;
Console.WriteLine($"find closest to {closestTo}");
Console.WriteLine($"closest: {FindClosestRecursive.DoFindClosestRecursive(originalArrayToFindClosestRecursive, 0, originalArrayToFindClosestRecursive.Length - 1, closestTo)}");
Console.WriteLine("=============================");

// == (MEDIUM) === Given an array of unsorted numbers, find all unique triplets in it that add up to zero.
// Input: [-3, 0, 1, 2, -1, 1, -2]
// Output: [[-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]]
// Explanation: There are four unique triplets whose sum is equal to zero. smallest sum.'
// Pair with Target Sum. A couple of differences are that the input array is not sorted and instead of a pair we need to find triplets with a target sum of zero.
// 1) Sort the array
// 2) Iterate through it taking one number X at a time. then find two other digits X + Y + Z = 0. 
// 3) Skip duplicate numbers. Due to the fact we have sorted array all duplicate numbers will be close to each other.

// Time Complexity: O(NLogN + N^2) which is asymptotically equivalent to O(N^2).
// Space Complexity: O(N) - N variables introduced
var originalArrayToFindUniqueTriplets = new int[] { -3, 0, 1, 2, -1, 1, -2 };
var result = FindAllUniqueTripletsWithSum0.InvokeFindAllUniqueTripletsWithSum0(originalArrayToFindUniqueTriplets);
foreach(var triplet in result) { Console.WriteLine($"found triplet [{triplet[0]}, {triplet[1]}, {triplet[2]}]"); }

var originalArrayToFindUniqueTripletsWithDuplicates = new int[] { -3, 0, 1, 1, 0, 1, 2, -1, -1, 1, -2, 4, 5 };
result = FindAllUniqueTripletsWithSum0.InvokeFindAllUniqueTripletsWithSum0(originalArrayToFindUniqueTripletsWithDuplicates);
foreach(var triplet in result) { Console.WriteLine($"found triplet [{triplet[0]}, {triplet[1]}, {triplet[2]}]"); }
