/* Problem 2 – Biggest Triple
We are given n numbers, e.g. {3, 7, 2, 8, 1, 4, 6, 9}. We split them into triples: sequences of 3 consecutive numbers 
 * (except the last sequence that could have 1 or 2 numbers). In our example, the numbers are split into these triples: 
 * the first three numbers {3, 7, 2}; the second three numbers {8, 1, 4}; the last two numbers {6, 9}. 
 * Write a program that enters n numbers and finds the triple with biggest sum of numbers. In our example this is the last triple: {6, 9}. 
 * In case there are several triples with the same biggest sum, print the leftmost of them.
Input
The input data should be read from the console. The input data consists of exactly one line holding the input numbers, 
 * separated one from another by a space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
You have to print at the console the leftmost biggest triple as sequence of up to 3 numbers, separated by a space.
Constraints
•	The input numbers will be integers in range [-1000 … 1000]. 
•	The number of the input numbers n will be between 1 and 1000.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        // read, split and parse input line, store in a list of unrestricted count
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // declaring variables
        int maxSum = Int32.MinValue;
        int sum = 0;

        List<int> temp = new List<int>();
        List<int> final = new List<int>();

        for (int i = 0; i < numbers.Length; i += 3)
        {
            temp = numbers.Skip(i).Take(3).ToList();
            sum = temp.Sum();

            if (sum > maxSum)
            {
                maxSum = sum;
                final = temp;
            }
        }

        // printing the result
        Console.WriteLine(string.Join(" ", final));
    }
}


