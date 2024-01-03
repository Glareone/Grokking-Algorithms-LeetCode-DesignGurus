using DesignGugus.TwoPointers;

// ========== SUM OF TWO POINTERS
var arrayForSumOfTwo = new [] { 1, 2, 3, 4, 6 };

// Using pointers.
// Complexity: O(n).
// Memory: O(1);
var (leftIndex, rightIndex) = arrayForSumOfTwo.GetElementIndexesWithSum(6);
// Using Dictionary
// Complexity: O(n);
// Memory: O(n);
var (leftIndexHash, rightIndexHash) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(6);
Console.WriteLine("=============================");
Console.WriteLine($"[{leftIndex}, {rightIndex}]");
Console.WriteLine($"[{leftIndexHash}, {rightIndexHash}]");
Console.WriteLine("=============================");

arrayForSumOfTwo = new [] { 2, 5, 9, 11 };
// Using pointers.
// Complexity: O(n).
// Memory: O(1);
var (leftIndex2, rightIndex2) = arrayForSumOfTwo.GetElementIndexesWithSum(11);
// Using Dictionary
// Complexity: O(n);
// Memory: O(n);
var (leftIndexHash2, rightIndexHash2) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(11);
Console.WriteLine($"[{leftIndex2}, {rightIndex2}]");
Console.WriteLine($"[{leftIndexHash2}, {rightIndexHash2}]");
Console.WriteLine("=============================");

// ====== Find Non Duplicate Subarray Length in Sorted Array
// Space Complexity: O(1)
// Time complexity: O(n)
var arrayToFindNonDuplicateArrayLength = new [] { 2, 3, 3, 3, 6, 9, 9 };
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
Console.WriteLine($"original array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine($"length of sub array with elements not equal to key {key} is: {arrayGeAllElementsNotEqualToKeyUnsortedArray.GetNumberOfElementsNotEqualToKeyUnsortedArray(key)}");
Console.WriteLine($"array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
arrayGeAllElementsNotEqualToKeyUnsortedArray = new [] { 2, 11, 2, 2, 1 };
key = 2;
Console.WriteLine($"original array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine($"length of sub array with elements not equal to key: {key} : {arrayGeAllElementsNotEqualToKeyUnsortedArray.GetNumberOfElementsNotEqualToKeyUnsortedArray(key)}");
Console.WriteLine($"array: {string.Join(',', arrayGeAllElementsNotEqualToKeyUnsortedArray)}");
Console.WriteLine("=============================");

var originalSortedArrayToSquare = new int[] { -2, -1, 0, 2, 3 };
var originalSortedArrayToSquare2 = new int[] { -3, -1, 1, 1, 2 };
Console.WriteLine($"original array: {string.Join(',', originalSortedArrayToSquare)}");
Console.WriteLine($"squared array: {string.Join(',', originalSortedArrayToSquare.GetSquaringSortedArray())}");
Console.WriteLine($"original array: {string.Join(',', originalSortedArrayToSquare2)}");
Console.WriteLine($"squared array: {string.Join(',', originalSortedArrayToSquare2.GetSquaringSortedArray())}");
Console.WriteLine("=============================");

