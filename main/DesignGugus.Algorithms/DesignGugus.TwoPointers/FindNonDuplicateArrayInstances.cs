namespace DesignGugus.TwoPointers;

public static class FindNonDuplicateArrayInstances
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
        var leftIndex = 1;
        var nextNonDuplicate = 1;

        while (leftIndex < array.Length)
        {
            // Check if the current element is different from the previous non-duplicate element.
            if (array[nextNonDuplicate - 1] != array[leftIndex])
            {
                // If different, copy the current element to the nextNonDuplicate position and increment the index.
                array[nextNonDuplicate] = array[leftIndex];
                uniqueElementsSubArrayLength ++;
                nextNonDuplicate++;
            }
        
            leftIndex++;
        }

        // Return the length of the new array with duplicates removed.
        return uniqueElementsSubArrayLength;
    }
    
    // Given an UNSORTED array of numbers
    // and a target 'key'
    // remove all instances of 'key' in-place and return the new length of the array.
    // Space Complexity Requirements O(1);
    
    // Time Complexity O(n) with two pointers approach. 
    public static int GetNumberOfUniqueElementsUnsortedArray(this int[] unsortedArray)
    {
        throw new NotImplementedException();
    }
}