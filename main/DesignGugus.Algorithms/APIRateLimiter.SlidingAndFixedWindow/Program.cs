using APIRateLimiter.FixedWindow;

int windowSizeInSeconds = 60;
// emulate 10 requests per second
int maxAPICallsInWindowSize = 10;

Queue<DateTimeOffset> fixedWindowAPILimiter = new();
Console.WriteLine("Press any key to simulate input. Press 'Esc' to exit.");

while (true)
{
    var key = Console.ReadKey(intercept: true).Key;
    if (key == ConsoleKey.Escape) break;

    ProcessInputHandler.ProcessInputSlidingWindow(key, fixedWindowAPILimiter, windowSizeInSeconds, maxAPICallsInWindowSize);
}