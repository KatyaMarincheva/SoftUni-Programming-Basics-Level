/* Problem 14.	Longest Word in a Text
Write a program to find the longest word in a text. 
Examples:
Input	                                                                            Output
Welcome to the Software University.	                                                University
The C# Basics course is awesome start in programming with C# and Visual Studio.	    programming
 */

using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        // Example 1:
        string text1 = @"Welcome to the Software University.";
        //Example 2:
        string text2 = @"The C# Basics course is awesome start 
in programming with C# and Visual Studio.";

        // printing
        Console.WriteLine("{0, -50}{1, -12}", "Input", "Output");
        Console.WriteLine("{0, -50}{1, -12}", text1, FindLongestWord(text1));
        Console.WriteLine();
        Console.WriteLine("{0, -50}{1, -12}", "Input", "Output");
        Console.WriteLine("{0, -90}{1, -12}", text2, FindLongestWord(text2));
        Console.WriteLine();
    }

    private static string FindLongestWord(string text1)
    {
        char[] delimiter = new char[] { '.', ' ' };
        string[] arr1 = text1.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray(); // string to array of words
        arr1 = arr1.OrderBy(aux => aux.Length).ToArray(); // sorting by length of words, shortest first
        return arr1[arr1.Length - 1]; // taking last word (the longest one)
    }
}

