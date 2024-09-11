namespace DesignGurus.CyclicSort;

public static class Ex_2_Find_missing_number
{
    // numbers are from 0 to n, therefore algorithm was slightly changed since ex_1
    // to use proper indices
    // Alg Complexity O(N) + O(N) which is O(2N) -> O(N)
    // Space complexity
    public static int SortAndFindMissingNumber(int[] originalArray)
    {
        var index = 0;
        while (index < originalArray.Length)
        {
            var variableToBeRelocated = originalArray[index];

            // we ignore situations when we stumble upon value which is out of array length
            // 4,0,3,1 - in this example 4, we cant place it anywhere, so ignore
            if (variableToBeRelocated == index || variableToBeRelocated > originalArray.Length - 1)
            {
                index++;
                continue;
            }

            int tempStorage = originalArray[variableToBeRelocated];
            originalArray[variableToBeRelocated] = variableToBeRelocated;
            originalArray[index] = tempStorage;
        }

        // it's not possible to find proper variable in one iteration
        // first we need to sort, then to find the number not equal to its position index
        // and return index. Index - is the value we are looking for
        for (index = 0; index < originalArray.Length - 1; index++)
        {
            if (originalArray[index] != index)
            {
                return index;
            }
        }

        return -1;
    }
}