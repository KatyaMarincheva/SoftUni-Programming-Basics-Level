//Problem 8. Numbers from 1 to n

/* Write a program that reads an integer number n 
 * from the console and prints all the numbers 
 * in the interval [1..n], each on a single line.

Note: You may need to use a for-loop.
*/
using System;

class NumbersFromOneToN
{
    static void Main()
    {
        string intro =
@"This program  reads an integer number n 
from the console and prints all the numbers 
in the interval [1..n], each on a single line.";
        Console.WriteLine(intro);

        string input;
        int n;

        do // validates input for n
        {
            Console.Write("\nPlease, enter a value for n: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out n));

        // prints sequence [1...n]
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0,4}", i);
        }

        // if n < 1, program flow skips the above for loop and enters this one
        for (int i = 1; i >= n; i--)
        {
            Console.Write("{0,4}", i);
        }
        Console.WriteLine();
    }
}

