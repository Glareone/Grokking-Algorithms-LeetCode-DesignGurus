namespace NextGreaterElement;

public static class NextGreaterElementHelper
{
    // Algorithm Complexity: O(n) where n - elements in permutation array
    // Space Complexity: O(n+m) - we need to push max N elements to Stack, N to Dictionary and M to output array
    // Space Complexity could be O(n) if we are going to modify originalArray instead of creating a new one for output
    public static int[] FindNextGreaterElementForArray(int[] originalArray, int[] permutationArray)
    {
        var stack = new Stack<int>();
        var numPairsWithGreaterNumber = new Dictionary<int, int>();

        for (var i = 0; i < permutationArray.Length; i++)
        {
            while (stack.Count != 0 && stack.Peek() < permutationArray[i])
            {
                // if there is a value which is smaller than permutationArray[i]
                // it means we found a pair of value and next Greater Element we were looking for each number
                numPairsWithGreaterNumber.Add(stack.Pop(), permutationArray[i]);
            }
            
            stack.Push(permutationArray[i]);
        }

        // add result array to return the answer back without mutating any of original arrays
        var resultArray = new int[originalArray.Length];
        
        // return the next value if it's presented in Dictionary, otherwise -1
        for (var i = 0; i < originalArray.Length; i++)
        {
            var isExist = numPairsWithGreaterNumber.TryGetValue(originalArray[i], out var value);
            resultArray[i] = isExist ? value : -1;
        }

        return resultArray;
    }
}