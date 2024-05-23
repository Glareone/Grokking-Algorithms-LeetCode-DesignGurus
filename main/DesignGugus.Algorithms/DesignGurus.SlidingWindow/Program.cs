// Given an array of positive numbers and a positive number 'k,'
// find the maximum sum of any contiguous subarray of size 'k'.
// Alg Complexity O(N)
// Memory O(1)
using DesignGurus.SlidingWindow;

Console.WriteLine("========= Maximum Sum of SubArray ========");
var array = new int[] { 2, 1, 5, 1, 3, 2 };
var result = MaximumSumOfSubarray.FindMaximumSumOfSumArray(array, 3);
Console.WriteLine("maxSum is {0}, expected 9", result);

array = new int[] { 2, 3, 4, 1, 5 };
result = MaximumSumOfSubarray.FindMaximumSumOfSumArray(array, 2);
Console.WriteLine("maxSum is {0}, expected 7", result);

// Given an array of positive integers and a number ‘S,’
// Find the length of the smallest contiguous subarray whose sum is greater than or equal to 'S'.
// Return 0 if no such subarray exists.
// Alg complexity of the algorithm will be O(N+N) , which is asymptotically equivalent to O(N).
// Memory O(1)
Console.WriteLine("==== Smallest subarray whose sum is greater than {selected number} =====");
var originalArray = new int[] { 2, 1, 5, 2, 3, 2 };
var lengthOfSmallestSubArray = originalArray.FindLengthOfSmallestSubArrayWithSumGreaterOrEqualThan(7);
Console.WriteLine("sub array length is {0}, expected 2 for target 7", lengthOfSmallestSubArray);

originalArray = new int[] { 2, 1, 5, 2, 8 };
lengthOfSmallestSubArray = originalArray.FindLengthOfSmallestSubArrayWithSumGreaterOrEqualThan(7);
Console.WriteLine("sub array length is {0}, expected 1 for target 7", lengthOfSmallestSubArray);

originalArray = new int[] { 3, 4, 1, 1, 6 };
lengthOfSmallestSubArray = originalArray.FindLengthOfSmallestSubArrayWithSumGreaterOrEqualThan(8);
Console.WriteLine("sub array length is {0}, expected 3 for target 8", lengthOfSmallestSubArray);

// Given a string, find the length of the longest substring in it with no more than K distinct characters.
// Input: String="araaci", K=2  
// Output: 4  
// Explanation: The longest substring with no more than '2' distinct characters is "araa".
// Input: String="araaci", K=1  
// Output: 2  
// Explanation: The longest substring with no more than '1' distinct characters is "aa".
Console.WriteLine("========= Longest SubString with {K} number of unique characters =========");
var foundMaxLengthOfSubstringWithUniqueChars = LongestSubstringWithNumberOfUniqueCharacters.FindSubstringWithUniqueCharacterOf("araaci", 2);
Console.WriteLine($"Final substring length is {foundMaxLengthOfSubstringWithUniqueChars}, correct is 4 for 2 unique characters");
foundMaxLengthOfSubstringWithUniqueChars = LongestSubstringWithNumberOfUniqueCharacters.FindSubstringWithUniqueCharacterOf("araaci", 1);
Console.WriteLine($"Final substring length is {foundMaxLengthOfSubstringWithUniqueChars}, correct is 2 for 1 unique characters");

