// Fibonacci Naive
// Alg Complexity O(2^n)
using DesignGurus.DynamicProgramming;
Console.WriteLine($"Fibonacci number, naive: {new FibonacciNumbers().GetNinFibonacciNaive(7)}");

// Fibonacci Naive with Memoization
// Alg Complexity O(N)
Console.WriteLine($"Fibonacci number, naive with memoization: {new FibonacciNumbers(25).GetNinFibonacciNaiveWithMemo(25)}");

// Fibonacci Bottom Up approach
// Alg Complexity O(N)
Console.WriteLine($"Fibonacci, bottom-up approach, result: {new FibonacciNumbers(50).GetNinFibonacciBottomUpApproach(25)}");

// Find Minimum number of coins
// Alg Complexity O(N^2) because of recursion
// Mem Complexity O(1)
Console.WriteLine($"minimum number of coins needed to get the targetSum is {MinimumCoins.FindMinimumCoinsNumber(13, new []{ 1,4,5 })}");

// Find minimum number of coins with memo
// Alg Complexity O(N^2) still because of recursion
// Memory Complexity O(N^2)
Console.WriteLine($"minimum number of coins needed to get the targetSum is {new MinimumCoins().FindMinimumCoinsNumberWithMemo(13, new []{ 1,4,5 })}");