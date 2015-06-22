/* Problem 9.	Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
 * The input and output lists are given as words, separated by a space, each list at a separate line. 
Examples:
Input	                                        Output
Peter Alex Maria Todor Steve Diana Steve
Todor Steve Nakov                               Peter Alex Maria Diana

Hristo Hristo Nakov Nakov Petya
Nakov Vanessa Maria	                            Hristo Hristo Petya
 */

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter first list of names: ");
        List<string> names1 = Console.ReadLine().Split(' ').ToList();
        Console.WriteLine("Please, enter second list of names: ");
        List<string> names2 = Console.ReadLine().Split(' ').ToList();

        // logic
        for (int i = 0; i < names2.Count; i++)
        {
            if (names1.Contains(names2[i]))
            {
                names1.RemoveAll(item => item == names2[i]);
            }
        } 

        // print
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", names1));
        Console.WriteLine();
    }
}

