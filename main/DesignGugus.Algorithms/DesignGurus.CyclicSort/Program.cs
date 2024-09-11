// See https://aka.ms/new-console-template for more information

using DesignGurus.CyclicSort;

var originalArray = new int[] { 1,2,3,4,5,6,7,8,9};
originalArray.ShuffleAlgorithm();
Console.WriteLine(string.Join(',', originalArray));
originalArray.SortArray();
Console.WriteLine(string.Join(',', originalArray));