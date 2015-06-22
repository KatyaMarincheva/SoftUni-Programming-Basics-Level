//  Problem 1. Odd or Even Integers

/* Write an expression that checks if given integer is odd or even.

Examples:
 n 	Odd?
 3 	true
 2 	false
-2 	false
-1 	true
 0 	false */

using System;

class OddOrEvenNumbers
{
    static void Main()
    {
        string input;
        int num;

        string intro = @"This program checks 
checks if given integer is odd.";
        Console.WriteLine(intro);

        do  // validates number input
        {
            Console.Write("\nPlease enter a type int number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        // checks if the input number odd or even, and prints the check result
        Console.WriteLine("Number is Odd?\n{0}\t{1}",num, (num%2 != 0));
    }
}


