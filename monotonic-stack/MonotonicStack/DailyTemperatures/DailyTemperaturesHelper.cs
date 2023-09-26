namespace DailyTemperatures;

public static class DailyTemperaturesHelper
{
    public static int[] CalculateWarmerDays(int[] initialArray)
    {
        var stack = new Stack<int>();
        var outputArray = new int[initialArray.Length];
        
        for (var index = 0; index < initialArray.Length; index++)
        {
            if (!stack.TryPeek(out var stackElement))
            {
                stack.Push(initialArray[index]);
                continue;
            }

            if (stack.TryPeek(out stackElement))
            {
                if (stackElement >= initialArray[index])
                {
                    stack.Push(initialArray[index]);
                    continue;
                }

                var daysUntilItGetsWarmer = 0;
                while(stack.Count > 0)
                {
                    var stackEl = stack.Peek();
                    if (stackEl < initialArray[index])
                    {
                        stack.Pop();
                        daysUntilItGetsWarmer++;
                        outputArray[index - daysUntilItGetsWarmer] = daysUntilItGetsWarmer;
                        continue;
                    }

                    break;
                }
                stack.Push(initialArray[index]);
            }
        }

        return outputArray;
    }
}