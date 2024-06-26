namespace DesignGurus.DynamicProgramming;

public class MinimumCoins
{
    private Dictionary<int, int> numberOfCoinsForTargetSum = new();
    
    public static int? Min(int? a, int? b)
    {
        if (!a.HasValue) return b;
        if (!b.HasValue) return a;
        return Math.Min(a.Value, b.Value);
    }
    
    public int? FindMinimumCoinsNumberWithMemo(int targetSum, int[] availableCoins)
    {
        if (targetSum == 0) return 0;

        if (numberOfCoinsForTargetSum.TryGetValue(targetSum, out var numberOfCoins))
        {
            return numberOfCoins;
        }

        int? answer = null;

        foreach (var coin in availableCoins)
        {
            var subTotalSum = targetSum - coin;
            if (subTotalSum < 0) continue;

            var subResult = FindMinimumCoinsNumber(subTotalSum, availableCoins);
            
            // if sum total number of coins exist - we need to add 1 because
            // we found the coin, need to find others
            if (subResult.HasValue)
            {
                subResult += 1;
            }
            
            answer = Min(answer, subResult);

            if (answer.HasValue)
            {
                // coins for TargetSum found, memoize
                numberOfCoinsForTargetSum.TryAdd(targetSum, answer.Value);
            }
        }

        return answer;
    }

    public static int? FindMinimumCoinsNumber(int targetSum, int[] availableCoins)
    {
        if (targetSum == 0) return 0;

        int? answer = null;

        foreach (var coin in availableCoins)
        {
            var subTotalSum = targetSum - coin;
            if (subTotalSum < 0) continue;

            var subResult = FindMinimumCoinsNumber(subTotalSum, availableCoins);
            
            // if sum total number of coins exist - we need to add 1 because
            // we found the coin, need to find others
            if (subResult.HasValue)
            {
                subResult += 1;
            }
            
            answer = Min(answer, subResult);
        }

        return answer;
    }
}