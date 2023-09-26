using DailyTemperatures;

var inputArray = new [] { 70, 73, 75, 71, 69, 72, 76, 73 };
Console.WriteLine($"days until it gets warmer for each day: {string.Join(',', DailyTemperaturesHelper.CalculateWarmerDays(inputArray))}");

inputArray = new [] { 73, 72, 71, 70 };
Console.WriteLine($"days until it gets warmer for each day: {string.Join(',', DailyTemperaturesHelper.CalculateWarmerDays(inputArray))}");

inputArray = new [] { 70, 71, 72, 73 };
Console.WriteLine($"days until it gets warmer for each day: {string.Join(',', DailyTemperaturesHelper.CalculateWarmerDays(inputArray))}");