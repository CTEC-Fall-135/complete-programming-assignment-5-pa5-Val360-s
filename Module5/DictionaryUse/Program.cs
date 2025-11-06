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
        // Use initialization syntax to create a dictionary
        // with three entries: (1, "one"), (2, "two"), and (3, "three"
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        // use the Add method to add (99, "ninety-nine")
        dictionary.Add(99, "ninety-nine");

        // demonstrate use of the enumerator to print out both the key and value of each entry in the dictionary.
        Console.WriteLine("Printing the dictionary using KeyValuePair:");
        foreach (KeyValuePair<int, string> entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // print out each key and value in the dictionary using var
        Console.WriteLine("\nPrinting the dictionary using implicit type:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // reassign the value of 99 to "99" using indexing notation
        dictionary[99] = "99";

        // print the value of key 99 using indexing notation
        Console.WriteLine($"\nPrinting value of 99: {dictionary[99]}");

        // remove the 2 item.
        dictionary.Remove(2);

        // print the updated dictionary
        Console.WriteLine("\nPrinting the updated dictionary:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}