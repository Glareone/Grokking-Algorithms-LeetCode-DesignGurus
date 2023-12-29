namespace DesignGurus.IslandMatrixTraversal;

public class BiggestIslandRun
{
    public static void Run()
    {
        var originalMatrix = new [,]
        {
            {1,0,0,0,0},
            {1,1,0,1,0},
            {1,0,1,1,1},
            {0,0,1,0,0},
            {0,1,0,0,0}
        };

        var originalMatrix2 = new [,]
        {
            {1,0,0,0,0},
            {1,1,0,1,0},
            {1,0,1,1,1},
            {0,0,1,0,0},
            {0,1,0,0,0}
        };

        Console.WriteLine($"biggest Island using BFS: {BiggestIsland.BiggestIslandInMultiDimentionalArray.FindBiggestIslandSizeInMultiDimentionalArrayBfs(originalMatrix)}");
        Console.WriteLine($"biggest Island using DFS: {BiggestIsland.BiggestIslandInMultiDimentionalArray.FindBiggestIslandSizeInMultiDimentionalArrayDfs(originalMatrix2)}");
    }
}