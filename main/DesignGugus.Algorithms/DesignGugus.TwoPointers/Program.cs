using DesignGugus.TwoPointers;

var arrayForSumOfTwo = new int[] { 1, 2, 3, 4, 6 };

var (leftIndex, rightIndex) = arrayForSumOfTwo.GetElementIndexesWithSum(6);
Console.WriteLine($"[{leftIndex}, {rightIndex}]");

arrayForSumOfTwo = new int[] { 2, 5, 9, 11 };
var (leftIndex2, rightIndex2) = arrayForSumOfTwo.GetElementIndexesWithSum(11);
Console.WriteLine($"[{leftIndex2}, {rightIndex2}]");