// Problem 13. Binary to Decimal Number

/*  Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.

Examples:
binary 	                        decimal
0 	                            0
11 	                            3
1010101010101011 	            43691
1110000110000101100101000000 	236476736
 */

using System;

class BinaryToDecimal
{
    static void Main()
    {
        // declarations
        long number = 0;
        long power = 1;

        // input
        Console.Write("Please enter a binary integer number: ");
        string num = Console.ReadLine();
        
        // retrieving the string array of digits
        for (int i = num.Length - 1; i >= 0 ; i--)
        {            
            int digit = num[i] - '0'; // converting string digits to int digits

            if (digit == 1) // 1 * i-th power of 2
            {
                number += digit * power;
            }

            power *= 2;
        }

        Console.WriteLine("\nThe string you entered is the binary representation of {0}\n", number);
    }
}

