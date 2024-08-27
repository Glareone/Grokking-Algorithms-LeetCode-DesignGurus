using DesignGurus.FastSlowPointers.Common;

namespace DesignGurus.FastSlowPointers;

public static class FindTheStartNodeOfTheInnerCycle
{
    // == Main idea ==
    // is to make an additional round of pointers moving slowPointer back to the head when they met for the first time.
    // It's because of Math, they need 1 full round, and they will meet at the start of the full cycle.
    // d - the distance from the head to the start of the cycle.
    // x - The distance from the start to the point where slow and fast meet for the first time.
    // c - is the total length of the cycle
    // c - x - The remaining distance to complete the cycle from the meeting point back to the start of the cycle.
    public static LinkedListNode? FindTheStartNodeOfTheCycle(LinkedList linkedList)
    {
        if (linkedList.Length <= 1)
        {
            return linkedList.Head;
        }
        
        var slowPointer = linkedList.Head;
        var fastPointer = linkedList.Head;
        
        do
        {
            slowPointer = slowPointer.Next;
            fastPointer = fastPointer.Next.Next;
        } while (slowPointer != fastPointer);

        // When you reset one of the pointers to the head and start moving both pointers one step at a time,
        // the slow pointer will travel d steps to reach the start of the cycle.
        slowPointer = linkedList.Head;

        do
        {
            slowPointer = slowPointer.Next;
            fastPointer = fastPointer.Next.Next;
        } while (slowPointer != fastPointer);

        return fastPointer;
    }
}
