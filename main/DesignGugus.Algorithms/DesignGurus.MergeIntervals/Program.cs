using DesignGurus.MergeIntervals;

// Intervals: [[1,4], [2,5], [7,9]]
// Output: [[1,5], [7,9]]
var initialIntervals = new List<MergeIntervalsClass.Interval>()
{ new(1, 4), new(2, 5), new(7, 9) };

// Intervals: [[6,7], [2,4], [5,9]]
// Output: [[2,4], [5,9]]
var initialIntervals2 = new List<MergeIntervalsClass.Interval>()
    { new(6, 7), new(2, 4), new(5, 9) };

// Intervals: [[1,4], [2,6], [3,5]]
// Output: [[1,6]]
var initialIntervals3 = new List<MergeIntervalsClass.Interval>()
    { new(1, 4), new(2, 6), new(3, 5) };

var mergedIntervals = MergeIntervalsClass.MergeIntervals(initialIntervals);
var mergedIntervals2 = MergeIntervalsClass.MergeIntervals(initialIntervals2);
var mergedIntervals3 = MergeIntervalsClass.MergeIntervals(initialIntervals3);
Console.Write("[");
foreach (var interval in mergedIntervals)
{
    Console.Write($"[{interval.Start},{interval.End}]");
}
Console.WriteLine("]");
Console.Write("[");
foreach (var interval in mergedIntervals2)
{
    Console.Write($"[{interval.Start},{interval.End}]");
}
Console.WriteLine("]");
foreach (var interval in mergedIntervals3)
{
    Console.Write($"[{interval.Start},{interval.End}]");
}
Console.WriteLine("]");
