namespace DesignGugus.TwoPointers;

public static class Ex_4_TripletsSumToZero
{
    
    // Time Complexity:
    public static List<List<int>> InvokeFindAllUniqueTripletsWithSum0(int[] originalArray)
    {
        Array.Sort(originalArray); // Complexity O(NLogN);
        
        List<List<int>> triplets = new();
        for (var i = 0; i < originalArray.Length; i++)
        {
            if (i > 0 && originalArray[i] == originalArray[i - 1])
            {
                // skip same element to avoid duplicate triplets
                continue;
            }

            var rootPointerValue = originalArray[i];

            var foundTriplets = SearchPair(originalArray, rootPointerValue, i + 1);
            triplets.AddRange(foundTriplets);
        }

        return triplets;
    }

    private static List<List<int>> SearchPair(int[] originalArray, int rootPointerValue, int leftPointer)
    {
        var rightPointer = originalArray.Length - 1;
        var foundTriplets = new List<List<int>>();
        
        while (leftPointer < rightPointer) // Complexity O(N)
        {
            int currentSum = originalArray[leftPointer] + originalArray[rightPointer];
            if(currentSum == -rootPointerValue)
            {
                // Sum found
                foundTriplets.Add(new List<int> { rootPointerValue, originalArray[leftPointer], originalArray[rightPointer] });
                
                // Move pointers
                leftPointer++;
                rightPointer--;
                
                // Avoid duplicates for LeftPointer if any
                // Complexity O(N)
                while (leftPointer < rightPointer && originalArray[leftPointer] == originalArray[leftPointer - 1])
                {
                    leftPointer++; // Skip found duplicate
                }
                
                // Avoid duplicates for LeftPointer if any
                // Complexity O(N)
                while (leftPointer < rightPointer && originalArray[rightPointer] == originalArray[rightPointer + 1])
                {
                    rightPointer--; // Skip found duplicate
                }
            }
            else if (currentSum < -rootPointerValue)
            {
                leftPointer++; // we need bigger LeftPointer
            }
            else
            {
                rightPointer--; // we need smaller RightPointer;
            }
        }

        return foundTriplets;
    }
}