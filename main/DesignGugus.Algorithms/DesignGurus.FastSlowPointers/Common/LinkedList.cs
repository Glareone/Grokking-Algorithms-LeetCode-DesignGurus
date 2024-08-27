namespace DesignGurus.FastSlowPointers.Common;

public class LinkedList
{
    public LinkedListNode? Head { get; private set; }
    public int Length;

    public LinkedList Init(int selectedLength = 6)
    {
        LinkedListNode? previouslyCreatedNode = null;
        Length = selectedLength;

        for (var i = 0; i < selectedLength; i++)
        {
            LinkedListNode newNode = new() { Value = Random.Shared.Next(1, 99) };
            if (Head == null)
            {
                Head = newNode;
                previouslyCreatedNode = newNode;
            }
            else
            {
                if (previouslyCreatedNode != null)
                {
                    previouslyCreatedNode.Next = newNode;
                }
                previouslyCreatedNode = newNode;
            }
        }

        return this;
    }

    public LinkedList InitInternalCycle()
    {
        if (Head is { Next: null })
        {
            return this;
        }
        
        var cycleStartNodePositionSelectedIndex = Random.Shared.Next(0, Length - 1);
        var currentPosition = 0;
        LinkedListNode currentNode = Head;
        
        while (currentPosition != cycleStartNodePositionSelectedIndex)
        {
            currentNode = currentNode.Next;
            currentPosition++;
        }

        LinkedListNode cycleStart = currentNode;

        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }

        currentNode.Next = cycleStart;

        return this;
    }
}