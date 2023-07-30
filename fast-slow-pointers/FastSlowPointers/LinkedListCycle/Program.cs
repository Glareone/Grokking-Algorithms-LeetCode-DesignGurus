using LinkedListCycle;

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