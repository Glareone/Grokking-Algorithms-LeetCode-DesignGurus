namespace DesignGugus.TwoPointers;

public static class SumOfTwoInArray
{
    // SUM OF TWO POINTERS
    // Complexity: O(n).
    // Memory: O(1);
    public static (int leftIndex, int rightIndex) GetElementIndexesWithSum(this int[] arrayElements, int expectedSum)
    {
        if (arrayElements.Length <= 1)
        {
            return (0, 0);
        }
        
        var leftPosition = 0;
        var rightPosition = arrayElements.Length - 1;

        while (arrayElements[leftPosition] + arrayElements[rightPosition] != expectedSum && leftPosition != rightPosition)
        {
            if (arrayElements[leftPosition] + arrayElements[rightPosition] < expectedSum)
            {
                leftPosition += 1;
                continue;
            }

            rightPosition -= 1;
        }

        return (leftPosition, rightPosition);
    }
}