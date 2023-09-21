// Input: nums1 = [4,2,6], nums2 = [6,2,4,5,3,7]
// Output: [5,4,7]
// Explanation: The next greater number for 4 is 5, for 2 is 4, and for 6 is 7 in nums2.
var num1 = new[] { 4, 2, 6 };
var num2 = new[] { 6, 2, 4, 5, 3, 7 };

Console.WriteLine($"find next greater numbers for num1 array: {string.Join(',', NextGreaterElement.NextGreaterElementHelper.FindNextGreaterElementForArray(num1, num2))}");
Console.WriteLine($"Expected Array: [5, 4, 7]");


// Input: nums1 = [9,7,1], nums2 = [1,7,9,5,4,3]
// Output: [-1,9,7]
// Explanation: The next greater number for 9 does not exist, for 7 is 9, and for 1 is 7 in nums2v2.
var num1v2 = new[] { 9, 7, 1 };
var num2v2 = new[] { 1, 7, 9, 5, 4, 3 };

Console.WriteLine($"find next greater numbers for num1 array: [{string.Join(',', NextGreaterElement.NextGreaterElementHelper.FindNextGreaterElementForArray(num1v2, num2v2))}]");
Console.WriteLine($"Expected Array: [-1, 9, 7]");

// Input: nums1 = [5,12,3], nums2 = [12,3,5,4,10,15]
// Output: [10,15,5]
// Explanation: The next greater number for 5 is 10, for 12 is 15, and for 3 is 5 in nums2v3.
var num1v3 = new[] { 5, 12, 3 };
var num2v3 = new[] { 12, 3, 5, 4, 10, 15 };

Console.WriteLine($"find next greater numbers for num1 array: [{string.Join(',', NextGreaterElement.NextGreaterElementHelper.FindNextGreaterElementForArray(num1v3, num2v3))}]");
Console.WriteLine($"Expected Array: [10, 15, 5]");
