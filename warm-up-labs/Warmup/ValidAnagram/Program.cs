using ValidAnagram;

var word1 = "listen";
var word2 = "silent";
Console.WriteLine($"word1: {word1}, word2: {word2}");
Console.WriteLine($"is valid anagram: {word1.isValidAnagramToWord(word2)}");

word1 = "li2st1en ";
word2 = "s8il en99t";
Console.WriteLine($"word1: {word1}, word2: {word2}");
Console.WriteLine($"is valid anagram: {word1.isValidAnagramToWord(word2)}");

word1 = "rat";
word2 = "car";
Console.WriteLine($"word1: {word1}, word2: {word2}");
Console.WriteLine($"is valid anagram: {word1.isValidAnagramToWord(word2)}");

word1 = "hello";
word2 = "ohel1o";
Console.WriteLine($"word1: {word1}, word2: {word2}");
Console.WriteLine($"is valid anagram: {word1.isValidAnagramToWord(word2)}");
    