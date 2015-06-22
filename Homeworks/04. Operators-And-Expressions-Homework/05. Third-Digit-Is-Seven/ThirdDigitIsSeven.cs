// Problem 5. Third Digit is 7?

/* Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * 
 * Examples:
 *       n 	Third digit 7?
 *       5 	false
 *     701 	true
 *    9703 	true
 *     877 	false
 *  777877 	false
 * 9999799 	true  
 */

using System;
using System.Collections.Generic;

class ThirdDigitSeven
{
/* To extract the value of a digit, GetDigt method does the following:
 * 1. divides the number by Nth power of 10, where N = (position of digit - 1)
 * (please note that ( not only as per this homework instruction), the digit positions increase from left to right
 * so the last digit is at position 1....... (I hate termonology mess... ) )
 * 2. applies the modulus operator %:     (number / (int)Math.Pow(10, digit - 1)) % 10
 * and the remainder of this divition is the digit value
 * for the last (at position 1) digit of 701, for instance, this calculation will be 
 * 701 / (int)Math.Pow(10, 1 - 1)) % 10, or (701/1) (zeroth power of 10 = 1) --> 701%10 = 1, 
 * and 1 is indeed the value of the digit at position 1
 */
    static int GetDigit(int number, int digit)
    {
        return (number / (int)Math.Pow(10, digit - 1)) % 10;
    }

    static void Main()

    {
        string intro = @"This program checks 
for given integer if its third digit
from right-to-left is 7.";
        Console.WriteLine(intro);

        string input;
        int num;

        do  // validates number input
        {
            Console.Write("\nPlease enter a type int number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        // applies the GetDigit method on digit at position 3 of number num, prints the result
        Console.WriteLine("\nNumber {0}:  Third digit is 7?     {1}\n", num.ToString().PadLeft(12), GetDigit(num, 3) == 7 ? true : false);
    }
}


