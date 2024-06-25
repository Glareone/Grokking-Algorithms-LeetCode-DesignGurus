namespace DesignGurus.DynamicProgramming;

public class FibonacciNumbers
{
    private readonly int[] _memorizedNumbers;

    public FibonacciNumbers()
    {
    }
    
    public FibonacciNumbers(int fibonacciNumberPosition)
    {
        _memorizedNumbers = new int[fibonacciNumberPosition + 1];
    }
    
    // Algorithm Complexity O(2^n)
    public int GetNinFibonacciNaive(int requiredPositionNumber)
    {
        if (requiredPositionNumber <= 2) return 1;

        var result = GetNinFibonacciNaive(requiredPositionNumber - 1) +
                     GetNinFibonacciNaive(requiredPositionNumber - 2);

        return result;
    }
    
    // Alg Complexity O(n)
    public int GetNinFibonacciNaiveWithMemo(int requiredPositionNumber)
    {
        if (requiredPositionNumber <= 2) return 1;

        if (_memorizedNumbers[requiredPositionNumber] is not 0)
            return _memorizedNumbers[requiredPositionNumber];
        
        var result = GetNinFibonacciNaive(requiredPositionNumber - 1) +
                     GetNinFibonacciNaive(requiredPositionNumber - 2);

        _memorizedNumbers[requiredPositionNumber] = result;
        return result;
    }

    public int GetNinFibonacciBottomUpApproach(int requiredPositionNumber)
    {
        for (var i = 1; i <= requiredPositionNumber; i++)
        {
            var result = 1;

            if (i <= 2)
            {
                result = 1;
            }
            else
            {
                result = _memorizedNumbers[i - 1] + _memorizedNumbers[i - 2];
            }
            
            _memorizedNumbers[i] = result;
        }

        return _memorizedNumbers[requiredPositionNumber];
    }
}