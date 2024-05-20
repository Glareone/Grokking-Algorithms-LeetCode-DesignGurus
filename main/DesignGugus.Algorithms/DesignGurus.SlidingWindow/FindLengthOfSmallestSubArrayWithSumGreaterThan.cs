namespace DesignGurus.SlidingWindow;

public static class FindLengthOfSmallestSubArrayWithSumGreaterThanTarget
{
    public static int FindLengthOfSmallestSubArrayWithSumGreaterOrEqualThan(this int[] originalArray, int greaterOrEqualThan)
    {
        var windowSum = 0;
        var minimumSubArrayLength = 0;
        var subArrayLength = 0;
        var leftIndex = 0;
        
        // Alg Complexity O(N)
        for (var rightIndex = 0; rightIndex < originalArray.Length; rightIndex++)
        {
            windowSum += originalArray[rightIndex];
            subArrayLength++;

            if (windowSum >= greaterOrEqualThan)
            {
                // Alg Complexity O(N)
                while (windowSum > greaterOrEqualThan && leftIndex < rightIndex)
                {
                    windowSum -= originalArray[leftIndex];
                    subArrayLength--;
                    leftIndex++;
                }
                
                if (minimumSubArrayLength == 0 || subArrayLength < minimumSubArrayLength)
                {
                    minimumSubArrayLength = subArrayLength;
                }
            }
        }
        
        return minimumSubArrayLength;
    }
}