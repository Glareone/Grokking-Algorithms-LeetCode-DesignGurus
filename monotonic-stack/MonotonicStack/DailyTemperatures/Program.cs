using DailyTemperatures;

var inputArray = new [] { 70, 73, 75, 71, 69, 72, 76, 73 };
Console.WriteLine($"days until it gets warmer for each day: {DailyTemperaturesHelper.CalculateWarmerDays(inputArray)}");