namespace APIRateLimiter.FixedWindow;

public static class SlidingWindowHandler
{
    public static void ProcessInputSlidingWindow(ConsoleKey key, Queue<DateTimeOffset> fixedWindowAPILimiter, int windowSizeInSeconds, int rateLimiterInWindowSize)
    {
        var timeNow = DateTimeOffset.Now;
    
        // remove timestamps which are out of the
        while (fixedWindowAPILimiter.Count > 0 &&
               (timeNow - fixedWindowAPILimiter.Peek()).TotalSeconds > windowSizeInSeconds)
        {
            fixedWindowAPILimiter.Dequeue();
        }

        if (fixedWindowAPILimiter.Count >= rateLimiterInWindowSize)
        {
            Console.WriteLine($"{key} Process cannot be handled, Throttling");
            return;
        }
        
        fixedWindowAPILimiter.Enqueue(timeNow);
        Console.WriteLine($"{key} was accepted and processed, Queue length: {fixedWindowAPILimiter.Count}");
    }
}