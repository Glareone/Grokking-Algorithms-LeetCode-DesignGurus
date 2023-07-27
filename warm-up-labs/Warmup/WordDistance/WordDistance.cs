namespace WordDistance;

internal static class WordDistance
{
    // Algorithm Complexity O(n2)
    // Space Complexity O(1)
    public static int FindShortestDistanceForWords(this string[] initialWordArray, string word1, string word2)
    {
        var minDistance = initialWordArray.Length - 1;

        int? FindDistanceToClosestOppositeWord(int leftIndex)
        {
            int? foundDistance = null;
            var lookingWord = initialWordArray[leftIndex] == word1 ? word2 : word1;
            
            for (var i = leftIndex + 1; i <= initialWordArray.Length - 1; i++)
            {
                if (initialWordArray[i] == lookingWord)
                {
                    foundDistance = i - leftIndex;
                    break;
                }
            }

            return foundDistance;
        }

        for (var i = 0; i < initialWordArray.Length - 1; i++)
        {
            if (initialWordArray[i] != word1 && initialWordArray[i] != word2)
            {
                continue;
            }
            
            var distance = FindDistanceToClosestOppositeWord(i);
            if (distance < minDistance)
            {
                minDistance = distance.Value;
            }
        }

        return minDistance;
    } 
    
    // Algorithm Complexity O(n)
    // Space Complexity O(1)
    public static int FindShortestWordDistance(this string[] initialWordArray, string word1, string word2)
    {
        int? word1Pointer = null;
        int? word2Pointer = null;
        var minDistance = initialWordArray.Length - 1;

        for (var i = 0; i <= initialWordArray.Length - 1; i++)
        {
            if (initialWordArray[i].Equals(word1))
            {
                word1Pointer = i;
            }
            else if(initialWordArray[i].Equals(word2))
            {
                word2Pointer = i;
            }

            if (word1Pointer.HasValue && word2Pointer.HasValue)
            {
                var distance = Math.Abs(word1Pointer.Value - word2Pointer.Value);
                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }
        }

        return minDistance;
    } 
}