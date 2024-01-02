using DesignGugus.TwoPointers;

// SUM OF TWO POINTERS
// Complexity: O(n).
// Memory: O(1);
var arrayForSumOfTwo = new [] { 1, 2, 3, 4, 6 };

var (leftIndex, rightIndex) = arrayForSumOfTwo.GetElementIndexesWithSum(6);
var (leftIndexHash, rightIndexhash) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(6);
Console.WriteLine("=============================");
Console.WriteLine($"[{leftIndex}, {rightIndex}]");
Console.WriteLine($"[{leftIndexHash}, {rightIndexhash}]");
Console.WriteLine("=============================");

arrayForSumOfTwo = new [] { 2, 5, 9, 11 };
var (leftIndex2, rightIndex2) = arrayForSumOfTwo.GetElementIndexesWithSum(11);
var (leftIndexHash2, rightIndexhash2) = arrayForSumOfTwo.GetElementIndexesUsingHashArray(11);

Console.WriteLine("=============================");
Console.WriteLine($"[{leftIndex2}, {rightIndex2}]");
Console.WriteLine($"[{leftIndexHash2}, {rightIndexhash2}]");
Console.WriteLine("=============================");