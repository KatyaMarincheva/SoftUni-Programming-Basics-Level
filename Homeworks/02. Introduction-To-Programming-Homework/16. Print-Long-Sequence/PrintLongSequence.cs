/*Problem 16.* Print Long Sequence
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).
*/
using System;
using System.Collections.Generic;

class PrintLongSequence
{
    static void Main()
    {
        Console.Title = "Print Long Sequence";

        List<int> numbers = new List<int>(); // creates an empty list 

        for (int i = 2; i <= 1000; i += 2)
        {
            numbers.Add(i);
            numbers.Add(~i); //NOT i = -i-1
        }

        /* the following line joins the for loop results into a string, so that the printing can start after the looping has completed -
         * printing while the computations are still in progress causes a considerable delay */
        string sequence = string.Join(", ", numbers);
        Console.WriteLine(sequence);
        Console.ReadLine();
    }
}
