namespace DesignGugus.TwoPointers;

public static class Ex_5_TripletsSumCloseToTarget
{
    // Given an array of UNSORTED numbers, find all UNIQUE triplets in it that add up to zero.
    // Input: [-3, 0, 1, 2, -1, 1, -2]
    // Output: [[-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]]
    // Explanation: There are four unique triplets whose sum is equal to zero. smallest sum.'
    // 
    // Input: [-5, 2, -1, -2, 3]
    // Output: [[-5, 2, 3], [-2, -1, 3]]
    // Explanation: There are two unique triplets whose sum is equal to zero.
    public static int[] InvokeFindTripletWithSumCloseToTarget(List<int> array, int targetSum)
    {
        // Main Idea:
        // In order to manage unique triplets we need to sort our original array.
        // Then iterating over the array we get X and need to find 2 other Numbers Y and Z
        // where X = -(Y+Z)

        
        array.Sort();

        if (array.Count < 3)
        {
            return new [] {0, 0, 0};
        }
        
        int[] bestCombination = new [] { array[0], array[1], array[^1] };
        int bestSumCloseToTarget = array[0] + array[1] + array[^1];

        
        for (var leftPointer = 0; leftPointer < array.Count - 2; leftPointer++)
        {
            var midPointer = leftPointer + 1;
            var rightPointer = array.Count - 1;

            while (midPointer != rightPointer)
            {
                var foundSum = array[leftPointer] + array[midPointer] + array[rightPointer];
                if (Math.Abs(foundSum - targetSum) < Math.Abs(bestSumCloseToTarget - targetSum)
                    || (Math.Abs(foundSum - targetSum) == Math.Abs(bestSumCloseToTarget - targetSum) 
                        && foundSum < bestSumCloseToTarget))
                {
                    bestSumCloseToTarget =  array[leftPointer] + array[midPointer] + array[rightPointer];
                    bestCombination = new int[] { array[leftPointer], array[midPointer], array[rightPointer] };
                }

                if (foundSum < targetSum)
                {
                    midPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }
        }

        return bestCombination;
    }
}