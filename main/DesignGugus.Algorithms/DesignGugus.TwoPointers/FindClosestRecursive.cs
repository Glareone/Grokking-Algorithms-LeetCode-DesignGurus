namespace DesignGugus.TwoPointers;

public static class FindClosestRecursive
{
    public static int DoFindClosestRecursive(int[] arr, int left, int right, int target)
    {
        // base case: when there is only one element in the array
        if (left == right)
        {
            return arr[left];
        }
 
        // calculate the middle index
        var mid = (left + right) / 2;
 
        // recursively search the left half of the array
        var leftClosest = DoFindClosestRecursive(arr, left, mid, target);
 
        // recursively search the right half of the array
        var rightClosest = DoFindClosestRecursive(arr, mid + 1, right, target);
 
        // compare the absolute differences of the closest elements in the 
        // left and right halves
        if (Math.Abs(leftClosest - target) <= Math.Abs(rightClosest - target))
        {
            return leftClosest;
        }
        else
        {
            return rightClosest;
        }
    }
}