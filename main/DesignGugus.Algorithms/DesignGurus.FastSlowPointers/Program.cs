using DesignGurus.FastSlowPointers;
using DesignGurus.FastSlowPointers.Common;

var singleLinkedList = new SinglyLinkedList();
singleLinkedList.Init();
singleLinkedList.Traverse();
singleLinkedList.CheckForCycle();
singleLinkedList.AddCycleToLast();
singleLinkedList.CheckForCycle();

singleLinkedList = new SinglyLinkedList();
singleLinkedList.Init();
singleLinkedList.Traverse();
singleLinkedList.CheckForCycle();
singleLinkedList.AddCycleToHead();
singleLinkedList.CheckForCycle();

// Check For cycle Algorithm Complexity is O(N)
// Space Complexity O(1)
singleLinkedList = new SinglyLinkedList();
singleLinkedList.Init();
singleLinkedList.Traverse();
singleLinkedList.CheckForCycle();
singleLinkedList.AddCycleToRandomPlace();
singleLinkedList.CheckForCycle();

// Given the head of a Singly LinkedList, write a method to return the middle node of the LinkedList.
// 
// If the total number of nodes in the LinkedList is even, return the second middle node.
// Input: 1 -> 2 -> 3 -> 4 -> 5 -> null
// Output: 3
// Input: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
// Output: 4
// Input: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> null
// Output: 4
//
// Alg Complexity O(N)
// Space Complexity O(1)
singleLinkedList = new SinglyLinkedList();
singleLinkedList.Init(6);
singleLinkedList.Traverse();
Console.WriteLine($"the middle of the singlyLinkedList is {singleLinkedList.FindTheMiddleOfTheLinkedList().Value}");

Console.WriteLine($"==== Find the start node of the cycle ====");
// Given the head of a Singly LinkedList that contains a cycle.
// Write a function to find the starting node of the cycle.
// Init the linkedList and Internal Cycle;
// Input: 1 -> 2 -> 3 -> 4 -> 5 -> 2
//        or 1 -> 2 -> 3 -> 4 -> 5 -> 1
// Output: 2 or 1
var linkedList = new LinkedList().Init(Random.Shared.Next(6, 20)).InitInternalCycle();
var linkedListNode = linkedList.Head;
Console.WriteLine($"Length is {linkedList.Length}");
for (int i = 0; i < linkedList.Length; i++)
{
    Console.Write($"{linkedListNode.Value}{(linkedListNode.Next != null ? "->" : "")}");
    linkedListNode = linkedListNode.Next;
}

var startNodeOfTheInnerCycle = FindTheStartNodeOfTheInnerCycle.FindTheStartNodeOfTheCycle(linkedList);
Console.WriteLine($"the start node of the inner cycle is {startNodeOfTheInnerCycle.Value}");
Console.ReadKey();