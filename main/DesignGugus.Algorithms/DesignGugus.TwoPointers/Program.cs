using DesignGugus.TwoPointers;

// ========== SUM OF TWO POINTERS
// Complexity: O(n).
// Memory: O(1);
var arrayForSumOfTwo = new [] { 1, 2, 3, 4, 6 };

var (leftIndex, rightIndex) = arrayForSumOfTwo.GetElementIndexesWithSum(6);
var (leftIndexHash, rightIndexHash) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(6);
Console.WriteLine("=============================");
Console.WriteLine($"[{leftIndex}, {rightIndex}]");
Console.WriteLine($"[{leftIndexHash}, {rightIndexHash}]");
Console.WriteLine("=============================");

// Complexity: O(n);
// Memory: O(n);
arrayForSumOfTwo = new [] { 2, 5, 9, 11 };
var (leftIndex2, rightIndex2) = arrayForSumOfTwo.GetElementIndexesWithSum(11);
var (leftIndexHash2, rightIndexHash2) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(11);


Console.WriteLine($"[{leftIndex2}, {rightIndex2}]");
Console.WriteLine($"[{leftIndexHash2}, {rightIndexHash2}]");
Console.WriteLine("=============================");

// ====== Find Non Duplicate Subarray Length in Sorted Array
var arrayToFindNonDuplicateArrayLength = new [] { 2, 3, 3, 3, 6, 9, 9 };
Console.WriteLine($"length on unique elements is: {arrayToFindNonDuplicateArrayLength.GetLengthOfSubArrayWithUniqueElementsSortedArray()}");
Console.WriteLine($"array: {string.Join(',', arrayToFindNonDuplicateArrayLength)}");
Console.WriteLine("=============================");

// ====== Find Non Duplicate Subarray Length in Unsorted Array