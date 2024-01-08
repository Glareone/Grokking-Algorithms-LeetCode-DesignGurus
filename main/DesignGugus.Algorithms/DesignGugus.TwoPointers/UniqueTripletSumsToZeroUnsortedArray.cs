namespace DesignGugus.TwoPointers;

public static class UniqueTripletSumsToZeroUnsortedArray
{
    // Given an array of UNSORTED numbers, find all UNIQUE triplets in it that add up to zero.
    // Input: [-3, 0, 1, 2, -1, 1, -2]
    // Output: [[-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]]
    // Explanation: There are four unique triplets whose sum is equal to zero. smallest sum.'
    // 
    // Input: [-5, 2, -1, -2, 3]
    // Output: [[-5, 2, 3], [-2, -1, 3]]
    // Explanation: There are two unique triplets whose sum is equal to zero.
    public static List<int[]> FindAllUniqueTripletsInUnsortedArray(this List<int> unsortedArray)
    {
        // Main Idea:
        // In order to manage unique triplets we need to sort our original array.
        // Then iterating over the array we get X and need to find 2 other Numbers Y and Z
        // where X = -(Y+Z)

        var X = -(5-1);
        
        unsortedArray.Sort();

        throw new NotImplementedException("not yet finished");
    }
}