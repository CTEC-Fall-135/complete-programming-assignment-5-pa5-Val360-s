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
        #region Stack
        // declare and initialize a stack with the numbers 1 - 5 using initialization syntax
        Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

        // write a foreach loop to print out the numbers (members) in the stack
        Console.WriteLine("Printing the stack:");
        foreach (int number in stack)
        {
            Console.WriteLine(number);
        }

        // print a peek at the top member in the stack
        Console.WriteLine($"\nTop of Stack: {stack.Peek()}");

        // write a loop that pops the elements off of the stack and prints each
        Console.WriteLine("\nPrinting the stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        #endregion

        #region Queue
        // declare a queue
        Queue<int> queue = new Queue<int>();

        // initialize the queue with the numbers 1-5 using a for loop
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i);
        }

        // write a foreach loop to print out the numbers (members) in the stack
        Console.WriteLine("\nQueue members:");
        foreach (int number in queue)
        {
            Console.WriteLine(number);
        }

        // print a peek at the top member in the stack
        Console.WriteLine($"\nTop of Queue: {queue.Peek()}");

        // write a loop that dequeues the elements from the stack and prints each
        Console.WriteLine("\nDequeue and print values:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        #endregion
    }
}