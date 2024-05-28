using DesignGurus.FastSlowPointers;

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