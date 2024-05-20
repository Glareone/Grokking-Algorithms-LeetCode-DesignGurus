namespace DesignGurus.SlidingWindow;

public class MaximumSumOfSubarray
{
    public static int FindMaximumSumOfSumArray(int[] initialArray, int subArrayLength)
    {
        if (initialArray.Length <= 1 || subArrayLength > initialArray.Length)
        {
            throw new ArgumentOutOfRangeException("selected sub array length is larger than the original array length");
        }

        var subArraySum = 0;
        // Alg Complexity O(N)
        for (var index = 0; index < subArrayLength; index++)
        {
            subArraySum += initialArray[index];
        }

        var maxSum = subArraySum;

        // Alg Complexity O(N)
        for (var index = 1; index <= initialArray.Length - subArrayLength; index++)
        {
            subArraySum -= initialArray[index - 1];
            subArraySum += initialArray[index + subArrayLength - 1];

            maxSum = Math.Max(maxSum, subArraySum);
        }

        return maxSum;
    }
}