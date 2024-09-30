namespace DesignGurus.MergeIntervals;

public class MergeIntervals
{
    // Given a list of intervals, merge all the overlapping intervals to produce a list that has only mutually exclusive intervals.
    // Example 1:
    //
    // Intervals: [[1,4], [2,5], [7,9]]
    // Output: [[1,5], [7,9]]
    // Explanation: Since the first two intervals [1,4] and [2,5] overlap, we merged them into one [1,5].
    // Example 2:
    //
    // Intervals: [[6,7], [2,4], [5,9]]
    // Output: [[2,4], [5,9]]
    // Explanation: Since the intervals [6,7] and [5,9] overlap, we merged them into one [5,9].
    // Example 3:
    //
    // Intervals: [[1,4], [2,6], [3,5]]
    // Output: [[1,6]]
    // Explanation: Since all the given intervals overlap, we merged them into one.

    public class Interval(int start, int end)
    {
        public int Start { get; set; } = start;
        public int End { get; set; } = end;
    }
    
    public List<Interval> MergeIntervals(List<Interval> intervals) {
        // Sort them first to simplify finding overlaps. Alg Complexity: O(NLogN)
        // Merge them in single pass merge O(N)
        var mergedIntervals = new List<Interval>();
        // TODO: Write your code here 
        return mergedIntervals;
    }
}