// Given an array of integers nums, return the number of good pairs.
//
//     A pair (i, j) is called good if nums[i] == nums[j] and i < j.

// Algorithm Complexity : 0(n)
// Space Complexity O(1)
int[] array = new[] { 1, 2, 3, 1, 1, 3 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsNaive(array)}");


array = new[] { 1, 1, 1, 1 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsNaive(array)}");

array = new[] { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsNaive(array)}");

// Updated version. We dont use second iteration to count the number of good pairs, so this algorithm having save Alg Complexity should work faster
// Space Complexity O(1)
array = new[] { 1, 2, 3, 1, 1, 3 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"Optimized Alg. number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsOptimized(array)}");


array = new[] { 1, 1, 1, 1 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"Optimized Alg. number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsOptimized(array)}");

array = new[] { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(string.Join(',', array));
Console.WriteLine($"Optimized Alg. number of pairs: {NumberOfGoodPairs.NumberOfGoodPairs.CountTheNumberOfGoodPairsOptimized(array)}");
