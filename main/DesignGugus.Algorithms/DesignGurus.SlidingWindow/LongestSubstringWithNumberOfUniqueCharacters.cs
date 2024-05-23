namespace DesignGurus.SlidingWindow;

public class LongestSubstringWithNumberOfUniqueCharacters
{
    public static int FindSubstringWithUniqueCharacterOf(string originalString, int selectedNumberOfUniqueCharacters)
    {
        if (selectedNumberOfUniqueCharacters > originalString.Length)
        {
            return -1;
        }

        var leftIndex = 0;
        var longestSubstringLength = 0;
        var setOfCharactersWithNumberOfOccurence = new Dictionary<char, int>();
        
        // Alg Complexity O(N)
        for (var rightIndex = 0; rightIndex <= originalString.Length - 1; rightIndex++)
        {
            var rightIndexCharacter = originalString[rightIndex];
            setOfCharactersWithNumberOfOccurence[rightIndexCharacter] = setOfCharactersWithNumberOfOccurence.GetValueOrDefault(rightIndexCharacter, 0) + 1;

            // Alg Complexity O(N)
            // while the number of unique characters is larger than target number
            while (setOfCharactersWithNumberOfOccurence.Count > selectedNumberOfUniqueCharacters && leftIndex < rightIndex)
            {
                var leftIndexCharacter = originalString[leftIndex];
                //Console.WriteLine($"Decreasing the number of inserts for: {leftIndexCharacter}");
                setOfCharactersWithNumberOfOccurence[leftIndexCharacter] -= 1;

                if (setOfCharactersWithNumberOfOccurence[leftIndexCharacter] == 0)
                {
                    //Console.WriteLine($"{leftIndexCharacter} is removed from Dictionary");
                    setOfCharactersWithNumberOfOccurence.Remove(leftIndexCharacter);
                }
                
                leftIndex++;
            }
            
            // nevertheless while happened or not we need to calculate the current length and compare with max
            longestSubstringLength = Math.Max(longestSubstringLength, rightIndex - leftIndex + 1);
        }
        
        return longestSubstringLength;
    }
}