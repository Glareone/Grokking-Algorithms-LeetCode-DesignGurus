namespace DesignGugus.TwoPointers;

public static class FindNonDuplicateArrayInstancesSortedArray
{
    // Given an array of SORTED numbers
    // move all non-duplicate number instances at the beginning of the array in-place.
    // The relative order of the elements should be kept the same and you should not
    // use any extra space so that the solution has constant space complexity i.e
    // Space Complexity: O(1)
    // Move all the unique number instances at the beginning of the array and after moving return the length of the subarray that has no duplicate in it.

    // Time Complexity O(n)
    // Space Complexity O(1)
    public static int GetLengthOfSubArrayWithUniqueElementsSortedArray(this int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        var uniqueElementsSubArrayLength = 1;
        var rightIndex = 1;
        var nextNonDuplicate = 1;

        while (rightIndex < array.Length)
        {
            // Check if the current element is different from the previous non-duplicate element.
            if (array[nextNonDuplicate - 1] != array[rightIndex])
            {
                // If different, copy the current element to the nextNonDuplicate position and increment the index.
                array[nextNonDuplicate] = array[rightIndex];
                
                uniqueElementsSubArrayLength ++;
                nextNonDuplicate++;
            }
        
            rightIndex++;
        }

        // Return the length of the new array with duplicates removed.
        return uniqueElementsSubArrayLength;
    }
}