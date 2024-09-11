namespace DesignGurus.CyclicSort;

public static class Ex_1_Cyclic_Sort_without_extra_space
{
    // Fisher-Yates shuffle algorithm
    public static void ShuffleAlgorithm(this int[] originalArray)
    {
        int n = originalArray.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Shared.Next(i + 1);
            (originalArray[i], originalArray[j]) = (originalArray[j], originalArray[i]);
        }
    }
    
    // Alg complexity is O(N)
    // Memory Complexity is O(1)
    public static void SortArray(this int[] originalArray)
    {
        int index = 0;
        while (index < originalArray.Length)
        {
            int correctVariableToBeRelocated = originalArray[index];
            if (correctVariableToBeRelocated == index + 1)
            {
                index++;
                continue;
            }
            
            int tempStorage = originalArray[correctVariableToBeRelocated - 1];
            originalArray[correctVariableToBeRelocated - 1] = correctVariableToBeRelocated;
            originalArray[index] = tempStorage;
        }
    }
}