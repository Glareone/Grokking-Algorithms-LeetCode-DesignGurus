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