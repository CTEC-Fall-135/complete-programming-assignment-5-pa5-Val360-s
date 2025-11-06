/* 
Author: Valentina Bocharnikova
Date: 10/31/2025
Assignment: Assignment 5
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // create a string array having the first 5-10 words of your favorite nursery rhyme
        string[] rhymeWords = { "Po", "polyam", "po", "polyam", "siniy", "tractor", "edet", "k", "nam" };

        // use the string array as the argument to a constructor creating a linked list.
        LinkedList<string> rhymeList = new LinkedList<string>(rhymeWords);

        // print the rhyme on a single line use the enumerator.
        Console.WriteLine("Print the list:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // create a node variable and walk the list to print out the values
        Console.WriteLine("\nPrint the list by walking it:");
        LinkedListNode<string> currentNode = rhymeList.First;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();

        // remove a word from the middle of the list
        // print the list on a single line to demonstrate this
        LinkedListNode<string> nodeToRemove = rhymeList.Find("tractor");
        if (nodeToRemove != null)
        {
            rhymeList.Remove(nodeToRemove);
        }

        Console.WriteLine("\nPrinting the uodated list:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // add the word back in and print the list again to demonstrate
        LinkedListNode<string> nodeBefore = rhymeList.Find("siniy");
        if (nodeBefore != null)
        {
            rhymeList.AddAfter(nodeBefore, "tractor");
        }

        Console.WriteLine("\nPrinting the uodated list:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}