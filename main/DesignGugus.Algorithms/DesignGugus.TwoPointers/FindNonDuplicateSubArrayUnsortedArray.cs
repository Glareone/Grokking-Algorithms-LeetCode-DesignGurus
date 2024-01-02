namespace DesignGugus.TwoPointers;

public static class FindNonDuplicateSubArrayUnsortedArray
{
    // Given an UNSORTED array of numbers
    // and a target 'key'
    // remove all instances of 'key' in-place and return the new length of the array.
    // Space Complexity must be O(1);
    // Input: [3, 2, 3, 6, 3, 10, 9, 3], Key=3
    // Output: [2, 6, 10, 9]
    
    // Time Complexity O(n) with two pointers approach. 
    public static int GetNumberOfElementsNotEqualToKeyUnsortedArray(this int[] unsortedArray, int key)
    {
        var leftIndex = 0;
        var rightIndex = 0;
        var sumOfElementsExceptKey = 0;

        while (rightIndex < unsortedArray.Length)
        {
            // Check if the current element is not equal to 'key'
            if (unsortedArray[rightIndex] != key)
            {
                unsortedArray[leftIndex] = unsortedArray[rightIndex];
                leftIndex++;
                sumOfElementsExceptKey++;
            }

            rightIndex++;
        }

        return sumOfElementsExceptKey;
    }
}