using APIRateLimiter.FixedWindow;

// sliding window is 60 seconds
const int windowSizeInSeconds = 60;
// emulate 10 requests per second
const int maxApiCallsInWindowSize = 10;

// Memory Complexity: maxAPICallInWindowSize * DateTimeOffset size = 10 * (8B + 8B TimeSpan) = 160B
Queue<DateTimeOffset> fixedWindowApiLimiter = new();
Console.WriteLine("Press any key to simulate input. Press 'Esc' to exit.");

while (true)
{
    var key = Console.ReadKey(intercept: true).Key;
    if (key == ConsoleKey.Escape) break;

    SlidingWindowHandler.ProcessInputSlidingWindow(key, fixedWindowApiLimiter, windowSizeInSeconds, maxApiCallsInWindowSize);
}