// Problem 15. Hexadecimal to Decimal Number

/* Using loops write a program that converts a hexadecimal integer number to its decimal form.
   The input is entered as string. The output should be a variable of type long.
   Do not use the built-in .NET functionality.

Examples:
hexadecimal 	decimal
FE 	254
1AE3 	6883
4ED528CBB4 	338583669684
 */

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        // declarations
        long number = 0;
        long power = 1;

        // input
        Console.Write("Please enter a hexadecimal integer number: ");
        string hex = Console.ReadLine();

        // retrieving the string array of symbols
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int symbol;

            // converting string symbols to long values
            switch (hex[i])
            {
                case 'A': symbol = 10;
                    break;
                case 'B': symbol = 11;
                    break;
                case 'C': symbol = 12;
                    break;
                case 'D': symbol = 13;
                    break;
                case 'E': symbol = 14;
                    break;
                case 'F': symbol = 15;
                    break;
                default: symbol = hex[i] - '0';
                    break;
            }

        // digit * i-th power of 16
            number += symbol * power;
            power *= 16;
        }

        Console.WriteLine("\nThe string you entered is the binary representation of {0}\n", number);
    }
}

