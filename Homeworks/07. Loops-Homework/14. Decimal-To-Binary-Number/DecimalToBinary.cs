// Problem 14. Decimal to Binary Number

/*  Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	binary
0 	        0
3 	        11
43691 	    1010101010101011
236476736 	1110000110000101100101000000
 */

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        // declarations
        List<byte> digits = new List<byte>();
        byte digit;

        // input
        Console.Write("Please enter an integer number: ");
        long num = long.Parse(Console.ReadLine());

        // logic:
        // if the entered decimal value is 0 - we print 0
        if (num == 0)
        {
            Console.WriteLine("The binary representation of the number you entered is: {0}\n", num.ToString());
        }

        else 
        {
            // for values > 0:  num % 2 = digit => num/2 and again num % 2 = next digit .... while num > 0
            while (num > 0)
            {
                digit = (byte)(num % 2);
                digits.Add(digit);
                num /= 2;
            }

            // we get the digits in reversed order in the digits list, so we apply the List.Reverse() method
            digits.Reverse();
            string binary = string.Join("", digits.ToArray());

            Console.WriteLine("The binary representation of the number you entered is: {0}\n", binary);
        }
    }
}

