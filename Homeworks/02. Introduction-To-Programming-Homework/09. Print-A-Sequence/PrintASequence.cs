// Problem 9. Print a Sequence - Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
using System.Collections.Generic;

class PrintASequence
{
    static void Main()
    {
        Console.Title = "Print a Sequence";

        List<int> numbers = new List<int>(); // creates an empty list 

        for (int counter = 2; counter <= 11; counter++)
        {
            if (counter % 2 == 0)
            {
                numbers.Add(counter); // adds the positive numbers of the sequence to the list
            }
            else
            {
                numbers.Add(-counter); // adds the negative numbers of the sequence to the list
            }
        }
        /* the following line joins the for loop results into a string, so that the printing can start after the looping has completed -
         * printing while the computations are still in progress causes a considerable delay */
        string sequence = string.Join(", ", numbers.ToArray());
        Console.WriteLine(sequence);
        Console.ReadLine();
    }
}
