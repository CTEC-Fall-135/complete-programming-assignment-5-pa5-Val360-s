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
        #region SimpleArray
        // create an array of int of size 5
        int[] array = new int[5];

        // use a for loop to initialize it to the numbers 11 - 15
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 11 + i;
        }

        // use a foreach loop to print out the values in the array
        Console.WriteLine("Printing int array:");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        #endregion

        #region List<T>
        // create a list of int
        List<int> list = new List<int>();

        // use a for loop to initialize the list to the numbers 21 - 25
        for (int i = 0; i < 5; i++)
        {
            list.Add(21 + i);
        }

        // use a foreach loop to print out the values in the list
        Console.WriteLine("\nPrinting int list:");
        foreach (int value in list)
        {
            Console.WriteLine(value);
        }

        // update the values in the list to 31 - 35 using a for loop
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = 31 + i;
        }

        // repeat the print using a for loop and indexing
        Console.WriteLine("\nPrinting updated list:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
    }
}