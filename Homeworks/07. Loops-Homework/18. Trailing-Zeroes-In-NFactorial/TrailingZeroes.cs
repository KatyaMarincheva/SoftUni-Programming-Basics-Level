// Problem 18.* Trailing Zeroes in N!

/*  Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.

Examples:
n 	    trailing zeroes of n! 	explaination
10 	    2 	                    3628800
20 	    4 	                    2432902008176640000
100000 	24999 	                think why
 */

using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int zeros = 0;
        int denominator = 1;

        // A trailing zero is always produced by prime factors 2 and 5. 
        // If we can count the number of 5s, our task is done. 
        // Trailing 0s in n! = floor(n/5) + floor(n/25) + floor(n/125)....
        while (number / denominator >= 1)
        {
            denominator *= 5;
            zeros += number / denominator;           
        }
        Console.WriteLine("\nNumber of zeros in {0}! ----> {1}\n", number, zeros);
    }
}

