/* Problem 8.	* Longest Non-Decreasing Subsequence
Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. 
 * In other words, you should remove a minimal number of numbers from the starting sequence, 
 * so that the resulting sequence is non-decreasing. 
 * In case of several longest non-decreasing sequences, 
 * print the leftmost of them. The input and output should consist of a single line, 
 * holding integer numbers separated by a space. Examples:
Input	                                Output
1	                                    1
7 3 5 8 -1 6 7	                        3 5 6 7
1 1 1 2 2 2	                            1 1 1
1 1 1 3 3 3 2 2 2 2	                    2 2 2 2
11 12 13 3 14 4 15 5 6 7 8 7 16 9 8	    3 4 5 6 7 8 9
 * 
 * N.B. Please see this about examples interpretations:
 * 
https://softuni.bg/Forum/1526/Homework-CSharp-Basics-Advanced-Topics-mistakes
 */

using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSequence
{
    // declarations
    static int[] arr;
    static int[] maxSubset = new int[1];

    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        List<int> subset = new List<int>(); // in this list we will be storing the current sequence
        MakeSubset(0, subset);

        // printing
        Console.WriteLine("Longest increasing sequence is:");
        for (int i = 0; i < maxSubset.Length; i++)
        {
            Console.Write("{0,3}", maxSubset[i]);
        }
        Console.WriteLine();
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Count > 1 && subset[subset.Count - 2] > subset[subset.Count - 1]) // if newly inserted elemet <= last element
            return; // sequence is broken, exit
        if (subset.Count >= maxSubset.Length)
        {
            maxSubset = new int[subset.Count]; // save new longest subset
            subset.CopyTo(maxSubset);

        }
        for (int i = index; i < arr.Length; i++) // try with next item
        {
            subset.Add(arr[i]); // add new item in subset

            // Console.WriteLine(string.Join(" ", subset)); // uncomment this line if you want to see what subsets are creared
            MakeSubset(i + 1, subset);
            subset.RemoveAt(subset.Count - 1); // remove last item

        }
    }
}

