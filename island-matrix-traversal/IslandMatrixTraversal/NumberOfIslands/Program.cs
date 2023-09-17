using NumberOfIslands;
// See https://aka.ms/new-console-template for more information

var matrixWithOneIsland = new int[][]
{
    new [] { 0, 1, 1, 1, 0 },
    new [] { 0, 0, 0, 1, 1 },
    new [] { 0, 1, 1, 1, 0 },
    new [] { 0, 1, 1, 0, 0 },
    new [] { 0, 0, 0, 0, 0 }
};

var matrixWithThreeIslands = new int[][]
{
    new[] { 1, 1, 1, 0, 0 },
    new[] { 0, 1, 0, 0, 1 },
    new[] { 0, 0, 1, 1, 0 },
    new[] { 0, 0, 1, 0, 0 },
    new[] { 0, 0, 1, 0, 0 }
};

var matrixWithOneIsland2 = new []
{
    new [] { 0, 1, 1, 1, 0 },
    new [] { 0, 0, 0, 1, 1 },
    new [] { 0, 1, 1, 1, 0 },
    new [] { 0, 1, 1, 0, 0 },
    new [] { 0, 0, 0, 0, 0 }
};

var matrixWithThreeIslands2 = new []
{
    new[] { 1, 1, 1, 0, 0 },
    new[] { 0, 1, 0, 0, 1 },
    new[] { 0, 0, 1, 1, 0 },
    new[] { 0, 0, 1, 0, 0 },
    new[] { 0, 0, 1, 0, 0 }
};

Console.WriteLine("===DFS===");
Console.WriteLine($"Expected: 1, Output: {NumberOfIslandsJaggedArray.CalculateTheIslandsCountDfs(matrixWithOneIsland)}");
Console.WriteLine($"Expected: 3, Output: {NumberOfIslandsJaggedArray.CalculateTheIslandsCountDfs(matrixWithThreeIslands)}");

Console.WriteLine("===BFS===");
Console.WriteLine($"Expected: 1, Output: {NumberOfIslandsJaggedArray.CalculateTheIslandsCountBfs(matrixWithOneIsland2)}");
Console.WriteLine($"Expected: 3, Output: {NumberOfIslandsJaggedArray.CalculateTheIslandsCountBfs(matrixWithThreeIslands2)}");
