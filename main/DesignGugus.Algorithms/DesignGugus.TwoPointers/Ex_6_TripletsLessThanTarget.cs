namespace DesignGugus.TwoPointers;

// Given an array arr of unsorted numbers and a target sum,
// count all triplets in it such that arr[i] + arr[j] + arr[k] < target where i, j, and k
// are three different indices. Write a function to return the count of such triplets.
//
// Input: [-1, 0, 2, 3], target=3 
// Output: 2
// Explanation: Two triplets whose sum is less than the target: [-1, 0, 3], [-1, 0, 2]
//
// Input: [-1, 4, 2, 1, 3], target=5 
// Output: 4
// Explanation: There are four triplets whose sum is less than the target: 
// [-1, 1, 4], [-1, 1, 3], [-1, 1, 2], [-1, 2, 3]

public static class Ex_6_TripletsLessThanTarget
{
    public static IEnumerable<List<int>> GetAllTripletsLessThanTarget(int[] originalUnsortedArray, int targetValue)
    {
        // Space Complexity O(N)
        var sortedArray = new int[originalUnsortedArray.Length];
        Array.Copy(originalUnsortedArray, sortedArray, originalUnsortedArray.Length);
        // Alg Complexity O(NLogN)
        Array.Sort(sortedArray);

        var allFoundTriplets = new List<List<int>>();
        
        // Alg Complexity O(N)
        for (var leftIndex = 0; leftIndex < sortedArray.Length - 2; leftIndex++)
        {
            // skip the following situation
            // [ -1, > -1, 2, 3, 5]
            if (leftIndex > 0 && sortedArray[leftIndex] == sortedArray[leftIndex - 1])
            {
                continue;
            }

            // > - left index
            // < - right index
            // | - middle index
            // [ > -1, | 0, 2, 3, 4 <]
            // Alg Complexity O(N)
            for (var rightIndex = sortedArray.Length - 1; rightIndex > leftIndex + 1; rightIndex--)
            {
                var middleIndex = leftIndex + 1;
                
                if ((rightIndex < sortedArray.Length - 1 
                        && sortedArray[rightIndex] == sortedArray[rightIndex + 1]))
                {
                    continue;
                }

                // Alg Complexity O(N)
                while (sortedArray[leftIndex] + sortedArray[middleIndex] + sortedArray[rightIndex] < targetValue
                       && middleIndex < rightIndex)
                {
                    // skip all middleIndexValues equal to leftIndexValue or rightIndexValue
                    if (sortedArray[middleIndex] == sortedArray[rightIndex]
                        || sortedArray[middleIndex] == sortedArray[leftIndex])
                    {
                        middleIndex++;
                        continue;
                    }
                    
                    var foundTriplet = new List<int>
                        { sortedArray[leftIndex], sortedArray[middleIndex], sortedArray[rightIndex] };
                        
                    allFoundTriplets.Add(foundTriplet);
                    
                    middleIndex++;
                }
            }
        }

        return allFoundTriplets;
    }
}