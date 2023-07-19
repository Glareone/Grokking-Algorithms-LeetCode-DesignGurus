
Console.WriteLine("======================= Validate Using Char Array: O(n) & O(n) ==========================");

var inputString = "A man, a plan, a canal, Panama!";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateUsingCharArray(inputString)}");

inputString = "Was it a car or a cat I saw?";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateUsingCharArray(inputString)}");

inputString = "random string which is obviously not a palindrome";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateUsingCharArray(inputString)}");

inputString = string.Empty;
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateUsingCharArray(inputString)}");

Console.WriteLine("======================= Validate Ignoring all non-char symbols: O(n) & O(1) ==========================");

inputString = "A man, a plan, a canal, Panama!";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateIgnoringNonCharSymbols(inputString)}");

inputString = "Was it a car or a cat I saw?";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateIgnoringNonCharSymbols(inputString)}");

inputString = "random string which is obviously not a palindrome";
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateIgnoringNonCharSymbols(inputString)}");

inputString = string.Empty;
Console.WriteLine($"input string: {inputString}");
Console.WriteLine($"method ValidateUsingCharArray. is valid palindrome? answer: {ValidPalindrome.PalindromeValidation.ValidateIgnoringNonCharSymbols(inputString)}");


Console.ReadKey();