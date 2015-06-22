/* Problem 10.	Join Lists
Write a program that takes as input two lists of integers and joins them. 
 * The result should hold all numbers from the first list, and all numbers from the second list, 
 * without repeating numbers, and arranged in increasing order. 
 * The input and output lists are given as integers, separated by a space, each list at a separate line. 
Examples:
Input	            Output
20 40 10 10 30 80
25 20 40 30 10	    10 20 25 30 40 80
5 4 3 2 1
6 3 2	            1 2 3 4 5 6
1
1	                1
 */

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Please, enter first list of numbers in one line, separated by a space: ");
        List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine("Please, enter second list of numbers in one line, separated by a space: ");
        List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> result = list1.Union(list2).ToList();
        result.Sort();
        Console.WriteLine("\nOutput: ");
        Console.WriteLine("{0}\n", string.Join(" ", result));
    }
}

