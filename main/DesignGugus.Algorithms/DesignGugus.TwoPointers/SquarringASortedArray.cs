namespace DesignGugus.TwoPointers;

public static class SquaringSortedArray
{
    // Given a sorted array,
    // Create a new array containing squares of all the numbers of the input array in the sorted order.
    // Memory Complexity: O(n)
    // Time Complexity: O(n)
    public static int[] GetSquaringSortedArray(this int[] array)
    {
        var insertIndex = array.Length - 1;
        var outputArray = new int[array.Length];
        var leftIndex = 0;
        var rightIndex = array.Length - 1;
        
        while (leftIndex <= rightIndex)
        {
            var leftSquare = array[leftIndex] * array[leftIndex];
            var rightSquare = array[rightIndex] * array[rightIndex];

            if (leftSquare > rightSquare)
            {
                outputArray[insertIndex] = leftSquare;
                leftIndex++;
            }
            else
            {
                outputArray[insertIndex] = rightSquare;
                rightIndex--;
            }

            insertIndex--;
        }

        return outputArray;
    }
}