using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char, int> myDictionary = new Dictionary<char, int>();
        Console.Write("Enter your input: ");
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            if (myDictionary.ContainsKey(input[i]))
            {
                int retrievedValue = myDictionary[input[i]];
                myDictionary[input[i]] = retrievedValue + 1;
            }
            else
            {
                myDictionary.Add(input[i], 1);
            }
        }

        // Displaying the character frequencies
        foreach (var entry in myDictionary)
        {
            Console.WriteLine($"Character '{entry.Key}' appears {entry.Value} time(s) in the input.");
        }
    }
}
