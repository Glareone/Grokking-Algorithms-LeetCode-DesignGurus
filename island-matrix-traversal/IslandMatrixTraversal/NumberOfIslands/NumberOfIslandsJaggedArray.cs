namespace NumberOfIslands;

public class NumberOfIslandsJaggedArray
{
    // Time complexity: O(M*N) - we need to traverse the whole matrix
    // Space complexity: O(M*N) - we need to store our stack of function calls
    // algorithm which uses Depth First Search approach
    // disadvantage of this algorithm is that we must modify original matrix
    public static int CalculateTheIslandsCountDfs(int[][] originalMatrix)
    {
        var totalNumberOfIslands = 0;
        
        var columnsCount = originalMatrix.Length;

        for (var i = 0; i < columnsCount; i++)
        {
            var rowsCount = originalMatrix[i].Length;
            
            for (var j = 0; j < rowsCount; j++)
            {
                if (originalMatrix[i][j] == 1)
                {
                    totalNumberOfIslands++;
                    VisitAllCellsNearbyDfs(originalMatrix, i, j);
                }
            }
        }

        return totalNumberOfIslands;
    }

    // Time Complexity: O(M*N)
    // Space Complexity: O(min(M,N)) In the worst case, when the matrix is completely filled with land cells, the size of the queue can grow to minimum of M and N.
    // BFS Algorithm.
    // Instead of making recursion calls we add Queue and operate with it. 
    public static int CalculateTheIslandsCountBfs(int[][] originalMatrix)
    {
        var totalNumberOfIslands = 0;
        
        var columnsCount = originalMatrix.Length;

        for (var i = 0; i < columnsCount; i++)
        {
            var rowsCount = originalMatrix[i].Length;
            
            for (var j = 0; j < rowsCount; j++)
            {
                if (originalMatrix[i][j] == 1)
                {
                    totalNumberOfIslands++;
                    VisitAllCellsNearbyBfs(originalMatrix, i, j);
                }
            }
        }

        return totalNumberOfIslands;
    }

    private static void VisitAllCellsNearbyBfs(int[][] originalMatrix, int columnNumber, int rowNumber)
    {
        var queue = new Queue<(int columnNumber, int rowNumber)>();
        queue.Enqueue((columnNumber, rowNumber));

        while (queue.Count > 0)
        {
            var elementToCheck = queue.Dequeue();
            var col = elementToCheck.columnNumber;
            var row = elementToCheck.rowNumber;
            if (col < 0 || row < 0 || col >= originalMatrix.Length ||
                row >= originalMatrix[col].Length)
            {
                continue;
            }

            if (originalMatrix[col][row] == 0)
            {
                continue;
            }

            originalMatrix[col][row] = 0;
            
            queue.Enqueue((col - 1, row));
            queue.Enqueue((col + 1, row));
            queue.Enqueue((col, row - 1));
            queue.Enqueue((col, row + 1));
        }
    }

    private static void VisitAllCellsNearbyDfs(int[][] originalMatrix, int columnNumber, int rowNumber)
    {
        // return if algorithm points out of matrix
        if (columnNumber < 0 || rowNumber < 0 || columnNumber >= originalMatrix.Length ||
            rowNumber >= originalMatrix[columnNumber].Length)
        {
            return;
        }

        if (originalMatrix[columnNumber][rowNumber] == 0)
        {
            return;
        }

        // set the field to 0 marking it as visited
        originalMatrix[columnNumber][rowNumber] = 0;
        
        VisitAllCellsNearbyDfs(originalMatrix, columnNumber - 1, rowNumber);
        VisitAllCellsNearbyDfs(originalMatrix, columnNumber + 1, rowNumber);
        VisitAllCellsNearbyDfs(originalMatrix, columnNumber, rowNumber - 1);
        VisitAllCellsNearbyDfs(originalMatrix, columnNumber, rowNumber + 1);
    }
}