# Grokking-Algorithms-LeetCode-DesignGurus
Exercises from different education platforms

## Theoretical part

<details>
<summary>Two pointers</summary>

 ![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/085a5b4e-29b9-406e-a25c-b76fe25661af)
</details>

<details>
<summary>Matrix Traversal. 2D array and Grid. Problem statement is about "Depth First Search" (DFS) and "Breadth First Search" (BFS)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/543404eb-0f83-420f-9a02-73b29dcb7f15)

Example:  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/6c4727a7-7ee9-4356-83ca-f12f2b9e6c22)  

Solution:  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/182f531d-696c-426f-bb95-cb48128541da)  
</details>

<details>
<summary>Fast & Slow Pointers. Hare & Tortoise algorithm</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/80dd75ba-065c-43bb-8897-ddcf6374c674)  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/c6815cfa-bbed-4fa4-910c-06f13f0d0c4b)  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/e17d38c3-eacc-41ee-981b-5a7aebf039d3)  

PseudoCode:  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/34e948a5-20c9-4597-ae78-77f816928386)
</details>

<details>
<summary>Breadth-First Search Algorithm. Complexity: O(Vertex+Edges).</summary>

**In General:**  
This algorithm is widely used in graphs. It may answer on the following questions:  
1. Is there a way from A to B?  
2. What the shortest way from A to B?

**In practice:**  
1. It could be useful to make a search among your friends by criteria.
2. It also could be useful for grammar during writing: find the closest word you wanted to write: ALGORIPM -> ALGORITM.  

**P.S.**  
If you want to find the closest contact in graph by criteria ("who may sell your mangos") - you also need to use **QUEUE** and **HashSet\List**  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/0877df84-722b-41b3-8375-12d602dfc427)

</details>

<details>
<summary>Monotonic Stack. Scenarios. Key Advantages & Disadvantages</summary>

<img width="829" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/d4a2d754-b2fd-4507-a4a0-0f8e9a8a7e46">
<img width="838" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/113d1210-34dd-418d-b711-d7b1053f4cad">
<img width="831" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/ab921e68-7f75-49eb-b868-10fdb2d23420">
<img width="818" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/2fdc62aa-d136-444a-a052-579f1119aaf1">
<img width="830" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/75628ad9-a3cc-441f-a78b-8725aab9b3b7">

### Advantages & Disadvantages
<img width="960" alt="image" src="https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/5a17f535-84f1-46af-9be4-5c559d49a2f5">

</details>

## Practice. Warmup
<details>
<summary>Dublicates in Array. Solutions: Two Pointers, HashSet, Sorting (easy)</summary>
  
Solved here: https://dotnetfiddle.net/nYtY6c

#### Brute Force: Two pointers
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/36d19e0a-41c3-428f-93c1-0b2f61a0eb6c)  
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/44add527-59e4-4ddf-8bb8-c9dbe463edaa)  


#### Using HashSet
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/2da0c979-932c-473a-b9a2-3ba73d688b1c)

#### Sorting
![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/69ced3b4-6778-4b3c-9cc0-89a594a2538e)

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/e6484eb6-00c4-4c50-8444-faa051396d17)
</details>

<details>
<summary>Pangram (easy)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/3eae3692-28ed-4606-a7c9-560b364c591d)  
Solved with Dictionary here: https://dotnetfiddle.net/uS1jWC
</details>

<details>
<summary>Reverse Vovels (easy)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/c4323a97-84aa-41cb-a215-5df3f198e123)  
[Solved here using char[] and string.Create](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/warm-up-labs/Warmup/ReverseVowels/ReverseVowels.cs)  
</details>

<details>
<summary>Valdiate Palindrome (easy)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/48bf7f0c-c807-4b58-aa2a-91d343c9c175)  
[Solved here using char[] and without allocating extra space](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/warm-up-labs/Warmup/ValidPalindrome/PalindromeValidation.cs)    \
</details>

<details>
<summary>Valdiate Anagram (easy). Algorithm Complexity O(n), Space Complexity O(1)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/72897af6-c9be-4bb3-9608-a35b39774414)   
[Solved using Dict here](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/warm-up-labs/Warmup/ValidAnagram/AnagramValidation.cs) 
</details>

<details>
<summary>(Two pointers) Shortest Distance Between Words (easy). Algorithm Complexity Naive O(n2), Improved O(n), Space Complexity in both cases O(1)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/28758626-0154-4b21-aced-c5f97f7a75e1)  
Solved here:[WordDistance](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/warm-up-labs/Warmup/WordDistance/WordDistance.cs)  
</details>

<details>
<summary>(Dictionary) Number of Good Pairs (easy). Algorithm Complexity Naive O(n), Improved O(n), Space Complexity in both cases O(1)</summary>

![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/f8c4a8c6-0949-4979-945c-f724dbe94241)   
Solved here:[Number of good pairs](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/warm-up-labs/Warmup/NumberOfGoodPairs/NumberOfGoodPairs.cs)  
</details>

## Two Pointers
<details>
<summary>(SingleLinkedList) Hare-Tortoise Algorithm. Single LinkedList, find if it has cycle, find the length of the cycle. Algorithm Complexity O(n), Space Complexity O(1)</summary>

 ![image](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/assets/4239376/52a2f675-1e9b-4051-806d-d6f1998bb9b2)    
 Solved here: [Hare Tortoise Algorithm](https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/fast-slow-pointers/FastSlowPointers/LinkedListCycle/SinglyLinkedList.cs)  
</details>

## Matrix Traversal
<details>
<summary>Matrix Traversal. Count of Islands. BFS - DFS. Algorithm Complexity O(M*N), Space Complexity O(min(M,N)) or O(M*N)</summary>

 https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/main/island-matrix-traversal/IslandMatrixTraversal/NumberOfIslands/Program.cs
</details>

<details>
<summary>Matrix Traversal. Biggest Island. BFS & DFS</summary>

https://github.com/Glareone/Grokking-Algorithms-LeetCode-DesignGurus/blob/traversal-matrix-islands/island-matrix-traversal/IslandMatrixTraversal/BiggestIsland/BiggestIslands.cs
</details>
