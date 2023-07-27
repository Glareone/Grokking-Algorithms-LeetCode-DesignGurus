namespace WordDistance;

internal static class WordDistance
{
    public static int FindShortestDistanceForWords(this string[] initialWordArray, string word1, string word2)
    {
        var minDistance = initialWordArray.Length - 1;

        int? FindClosestOppositeWord(int leftIndex)
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
            
            var distance = FindClosestOppositeWord(i);
            if (distance < minDistance)
            {
                minDistance = distance.Value;
            }
        }

        return minDistance;
    } 
}