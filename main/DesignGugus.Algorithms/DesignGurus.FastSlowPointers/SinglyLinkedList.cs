namespace DesignGurus.FastSlowPointers.LinkedListCycle;

public class Node
{
    public int Value { get; init; }

    public Node? Next { get; set; }
}

public class SinglyLinkedList
{
    private Node? Head { get; set; }

    public void Init()
    {
        var random = new Random();
        Node? tempNode = null;

        for (var i = 0; i < random.Next(6, 20); i++)
        {
            Node newNode = new() { Value = random.Next(1, 99) };
            if (Head is null)
            {
                Head = newNode;
                tempNode = Head;
            }

            tempNode.Next = newNode;
            tempNode = newNode;
        }
    }
    
    public void Traverse()
    {
        var pointer = Head;
        var length = 0;
        while (pointer is not null)
        {
            Console.Write($"{pointer.Value}{(pointer.Next != null ? "->" : "")}");
            pointer = pointer.Next;
            length++;
        }
        Console.Write("\n");
        Console.WriteLine($"length of LinkedList is {length}");
    }

    public void AddCycleToHead()
    {
        var pointer = Head;

        while (pointer?.Next != null)
        {
            pointer = pointer.Next;
        }

        pointer.Next = Head;
    }
    
    public void AddCycleToLast()
    {
        if (Head is null)
        {
            
        }
        
        var pointer = Head;

        while (pointer.Next != null)
        {
            pointer = pointer.Next;
        }

        pointer.Next = pointer;
    }
    
    public void AddCycleToRandomPlace()
    {
        if (Head is null)
        {
            return;
        }
        
        var random = new Random();
        var randPoint = random.Next(1, 5);
        Console.WriteLine($"randomly selected position of cycle is {randPoint + 1}");

        Node pointerToRandomizedPlace = Head;
        for (int i = 0; i <= randPoint; i++)
        {
            pointerToRandomizedPlace = pointerToRandomizedPlace.Next!;
        }
        
        var pointer = Head;

        while (pointer?.Next is not null)
        {
            pointer = pointer.Next;
        }

        pointer.Next = pointerToRandomizedPlace;
    }

    // Algorithm Complexity O(n)
    // Space Complexity O(1)
    public void CheckForCycle()
    {
        var slowPointer = Head;
        var fastPointer = Head;

        while (slowPointer?.Next is not null || fastPointer?.Next is not null)
        {
            fastPointer = fastPointer?.Next?.Next;
            slowPointer = slowPointer?.Next;

            if (fastPointer == slowPointer)
            {
                Console.WriteLine($"Cycle Found! Element: {slowPointer?.Value} -> {slowPointer?.Next?.Value}");
                CalculateLengthOfCycle(slowPointer!);
                return;
            }
        }
        
        Console.WriteLine("Cycle haven't been found");
    }

    // Algorithm Complexity O(n)
    // Space Complexity O(1)
    private void CalculateLengthOfCycle(Node node)
    {
        var tempPointer = node;
        var length = 1;

        do
        {
            length++;
            tempPointer = tempPointer?.Next;
        } while (tempPointer != node);
        
        Console.WriteLine($"length of cycle is {length}");
    }
}