using System.Diagnostics;

namespace BiggestIsland;

public static class BiggestIslandInMultiDimentionalArray
{

    // Algorithm Complexity O(M*N)
    // Space Complexity O(M*N) because of max elements we could put into our stack
    public static int FindBiggestIslandSizeInMultiDimentionalArrayDfs(int[,] originalMatrix)
    {
        var biggestIsland = 0;
        
        for (var i = 0; i < originalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < originalMatrix.GetLength(1); j++)
            {
                if (originalMatrix[i, j] == 1)
                {
                    var islandSize = GetIslandSizeDfs(originalMatrix, i, j);
                    if (islandSize > biggestIsland)
                    {
                        biggestIsland = islandSize;
                    }
                }
            }
        }

        return biggestIsland;
    }

    private static int GetIslandSizeDfs(int[,] originalMatrix, int columnIndex, int rowIndex)
    {
        if (columnIndex < 0 || rowIndex < 0 || columnIndex >= originalMatrix.GetLength(0) ||
            rowIndex >= originalMatrix.GetLength(1))
        {
            return 0;
        }

        if (originalMatrix[columnIndex, rowIndex] == 0)
        {
            return 0;
        }

        originalMatrix[columnIndex, rowIndex] = 0;
        var islandSize = 1;

        islandSize += GetIslandSizeDfs(originalMatrix, columnIndex - 1, rowIndex);
        islandSize += GetIslandSizeDfs(originalMatrix, columnIndex + 1, rowIndex);
        islandSize += GetIslandSizeDfs(originalMatrix, columnIndex, rowIndex -1);
        islandSize += GetIslandSizeDfs(originalMatrix, columnIndex, rowIndex + 1);

        return islandSize;
    }

    public static int FindBiggestIslandSizeInMultiDimentionalArrayBfs(int[,] originalMatrix)
    {
        var biggestIsland = 0;

        for (var i = 0; i < originalMatrix.GetLength(0); i++)
        {
            for (var j = 0; j < originalMatrix.GetLength(1); j++)
            {
                if (originalMatrix[i, j] == 1)
                {
                    var islandSize = GetIslandSizeBfs(originalMatrix, i, j);
                    if (islandSize > biggestIsland)
                    {
                        biggestIsland = islandSize;
                    }
                }
            }
        }

        return biggestIsland;
    }

    // Algorithm Complexity O(M*N)
    // Space Complexity: O(min(M,N)) In the worst case, when the matrix is completely filled with land cells, the size of the queue can grow to minimum of M and N.
    private static int GetIslandSizeBfs(int[,] originalMatrix, int columnIndex, int rowIndex)
    {
            var islandSize = 0;
            var queue = new Queue<(int columnIndex, int rowIndex)>();
            queue.Enqueue((columnIndex, rowIndex));

            while (queue.Count > 0)
            {
                var (cIndex, rIndex) = queue.Dequeue();
                if (cIndex >= originalMatrix.GetLength(0) || rIndex >= originalMatrix.GetLength(1) || cIndex < 0 || rIndex < 0)
                {
                    continue;
                }

                if (originalMatrix[cIndex, rIndex] == 1)
                {
                    islandSize++;
                    originalMatrix[cIndex, rIndex] = 0;
                    queue.Enqueue((cIndex - 1, rIndex));
                    queue.Enqueue((cIndex + 1, rIndex));
                    queue.Enqueue((cIndex, rIndex - 1));
                    queue.Enqueue((cIndex, rIndex + 1));
                }
            }
            return islandSize;
    }
}