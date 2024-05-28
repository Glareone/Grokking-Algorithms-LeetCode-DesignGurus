namespace DesignGurus.FastSlowPointers;

public static class MiddleOfTheLinkedList
{
    // Given the head of a Singly LinkedList, write a method to return the middle node of the LinkedList.
    // 
    // If the total number of nodes in the LinkedList is even, return the second middle node.
    // Input: 1 -> 2 -> 3 -> 4 -> 5 -> null
    // Output: 3
    // Input: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
    // Output: 4
    // Input: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> null
    // Output: 4
    public static LinkedListNode FindTheMiddleOfTheLinkedList(this SinglyLinkedList originalSinglyLinkedList)
    {
        if (originalSinglyLinkedList.Head == null)
        {
            return new LinkedListNode();
        }
        
        LinkedListNode slowPointer = originalSinglyLinkedList.Head;
        LinkedListNode? fastPointer = originalSinglyLinkedList.Head;

        while (fastPointer?.Next != null)
        {
            fastPointer = fastPointer.Next?.Next;
            slowPointer = slowPointer!.Next!;
        }

        return slowPointer;
    }
}