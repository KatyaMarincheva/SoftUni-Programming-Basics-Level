/* Problem 6.	Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. 
 * You first should read an integer n and n strings (each at a separate line), 
 * then find and print the longest sequence of equal elements (first its length, then its elements). 
 * If multiple sequences have the same maximal length, print the leftmost of them.  */

using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main()
    {
        List<string> sequence = new List<string>();
        Console.Write("Please enter an int value for n: ");
        int n = int.Parse(Console.ReadLine());

        // filling the array of numbers
        Console.WriteLine("Please, enter {0} strings, each on a separate line:", n);
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        sequence = LongestSequence(array);
        Console.WriteLine("\nOutput\n{0}", sequence.Count);
        for (int k = 0; k < sequence.Count; k++)
        {
            Console.WriteLine(sequence[k]);
        }
    }

    private static List<string> LongestSequence(string[] array)
    {
        // declaring the number we are searching for, its temp and best counts
        List<string> longestSequence = new List<string>();
        string str = array[0];
        int count = 1;
        int bestCount = 1;

        // looping over the array and searching for equal values
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;

                // we stp searching when we find a count of equal values, exceeding all previous counts
                if (count > bestCount)
                {
                    bestCount = count;
                    // and our number is the array emement at current i-postion
                    str = array[i];
                }
            }

            // else, if the current count of equal values is not higher than the previously registered one - we restart the counting
            else
            {
                count = 1;
            }
        }

        for (int j = 0; j < bestCount; j++)
        {
            longestSequence.Add(str);
        }
        
        return longestSequence;
    }
}

