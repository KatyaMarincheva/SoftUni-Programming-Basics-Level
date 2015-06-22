// Problem 5. Formatting Numbers

/*    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
      The program then prints them in 4 virtual columns on the console. 
        Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

Examples:
a 	    b 	        c 	    result
254 	11.6 	  0.5 	    FE  |0011111110| 11.60|0.500     |
499     -0.5559 	10000 	1F3 |0111110011| -0.56|10000.000 |
  0 	 3 	     -0.1234 	0   |0000000000| 3    |-0.123    |
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string intro = @"This program reads one type int, 
and two type float numbers from the console,
then prints them in 4 virtual columns.";
        Console.WriteLine(intro);

        string inputInt;
        int integer;

        do // validates input for int number
        {
        Console.Write("Please enter first number a: ");
        integer = int.Parse(Console.ReadLine());

        } while (!(0 <= integer && integer <= 500));

        string inputFloat;
        float floatNumber;

        List<float> floats = new List<float>();

        // limits the float entries to 2, and numbers the input entries
        for (int i = 1; i < 3; i++)
        {
            do // validate input for float
            {
                Console.Write("\nPlease, enter float number {0}: ", i);
                inputFloat = Console.ReadLine().Replace(",", "."); // replaces "," with "." in float inputs

            } while (!float.TryParse(inputFloat, out floatNumber));

            floats.Add(floatNumber); // adds the entered floats into the floats list
        }

        // preparing a table view output....
        string separator = new string('-', 45);
        Console.WriteLine("\n{0}", separator);
        Console.WriteLine("|   Hex    |  Binary  | Float 1  | Float 2  |");
        Console.WriteLine(separator);
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", integer, Convert.ToString(integer, 2).PadLeft(10, '0'), floats[0], floats[1]);
        Console.WriteLine("{0}\n", separator);
    }
}

