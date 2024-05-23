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
        var setOfCharacters = new HashSet<char>();
        
        // Alg Complexity O(N)
        for (var rightIndex = 0; rightIndex <= originalString.Length - 1; rightIndex++)
        {
            if (!setOfCharacters.Contains(originalString[leftIndex]) &&
                setOfCharacters.Count == selectedNumberOfUniqueCharacters)
            {
                var currentLength = rightIndex - leftIndex;
                if (currentLength > longestSubstringLength)
                {
                    longestSubstringLength = currentLength;
                    Console.WriteLine("current is: {0}", currentLength);
                    Console.WriteLine("leftIndex is: {0}", leftIndex);
                    Console.WriteLine("rightIndex is: {0}", rightIndex);
                    Console.WriteLine("Substring is: {0}", originalString.Substring(leftIndex, rightIndex));
                } 
            }
            
            setOfCharacters.Add(originalString[rightIndex]);

            // Alg Complexity O(N) - "aaaaaa" and 1
            while (setOfCharacters.Count > selectedNumberOfUniqueCharacters && leftIndex < rightIndex)
            {
                Console.WriteLine($"Removing: {originalString[leftIndex]}");
                setOfCharacters.Remove(originalString[leftIndex]);
                leftIndex++;
            }
        }
        
        return longestSubstringLength;
    }
}