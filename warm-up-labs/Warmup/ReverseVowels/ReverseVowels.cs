namespace ReverseVowels;

public static class ReverseVowels
{
    private static readonly HashSet<char> VowelsSet = new() { 'a', 'e', 'i', 'o', 'u' };

    
    /// In this case Complexity is still O(n),
    /// Memory allocation is O(n) because we need space for char array;
    public static string ReverseUsingArray(string inputString)
    {
        if (inputString.Length == 0)
        {
            return inputString;
        }
        
        var inputStringAsArray = inputString.ToCharArray();
        var leftPointer = 0;
        var rightPointer = inputStringAsArray.Length - 1;

        while (leftPointer < rightPointer)
        {
            // find next vowel at the left
            while(leftPointer < rightPointer)
            {
                if (VowelsSet.Contains(char.ToLower(inputStringAsArray[leftPointer])))
                {
                    break;
                }

                leftPointer++;
            }
            
            // find next vowel at the right
            while(rightPointer > leftPointer)
            {
                if (VowelsSet.Contains(char.ToLower(inputStringAsArray[rightPointer])))
                {
                    break;
                }

                rightPointer--;
            }
            
            // reverseFoundVowels
            (inputStringAsArray[leftPointer], inputStringAsArray[rightPointer]) = (inputStringAsArray[rightPointer], inputStringAsArray[leftPointer]);
            
            // move pointers to the next positions;
            leftPointer++;
            rightPointer--;
        }
        
        return new string(inputStringAsArray);
    }
    
    /// It's possible to not allocate extra space for char array. Instead string.Create method could be used.
    /// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/modify-string-contents#programmatically-build-up-string-content 
    /// In this case Complexity is still O(n), but memory allocation is 0(1);
    public static string ReverseUsingSpanAndStringCreate(string inputString)
    {
        throw new NotImplementedException("WIP");
    }
}