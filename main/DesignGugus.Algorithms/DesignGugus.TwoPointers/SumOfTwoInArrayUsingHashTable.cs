namespace DesignGugus.TwoPointers;

public static class SumOfTwoInArrayUsingHashTable
{
    // Index for Sum of two pointers, using HashMap (Dictionary for C#)
    // Time Complexity: O(n)
    // Memory Complexity: O(n)
    public static (int leftIndex, int rightIndex) GetElementIndexesUsingHashArray(this int[] array, int expectedSum)
    {
        if (array.Length < 1)
        {
            return (0, 0);
        }

        var pointerIndex = 0;
        
        Dictionary<int, int> indexValueCollection = new();

        while (pointerIndex != array.Length)
        {
            var expectedElement = expectedSum - array[pointerIndex];

            if (indexValueCollection.TryGetValue(expectedElement, out var foundIndex))
            {
                return (foundIndex, pointerIndex);
            }

            indexValueCollection.TryAdd(array[pointerIndex], pointerIndex);
            pointerIndex += 1;
        }

        return (0, 0);
    }
}