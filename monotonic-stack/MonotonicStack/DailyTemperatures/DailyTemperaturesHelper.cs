namespace DailyTemperatures;

public static class DailyTemperaturesHelper
{
    public static int[] CalculateWarmerDays(int[] initialArray)
    {
        var stack = new Stack<int>();
        var outputArray = new int[initialArray.Length];
        
        for (var arrayIndex = 0; arrayIndex < initialArray.Length; arrayIndex++)
        {
            if (stack.Count == 0)
            {
                stack.Push(arrayIndex);
                continue;
            }
            
            while(stack.Count > 0)
            {
                if (initialArray[stack.Peek()] < initialArray[arrayIndex])
                {
                        var savedIndex = stack.Pop();
                        outputArray[savedIndex] = arrayIndex - savedIndex;
                        continue;
                }

                break;
            }
            
            stack.Push(arrayIndex);
        }

        return outputArray;
    }
}