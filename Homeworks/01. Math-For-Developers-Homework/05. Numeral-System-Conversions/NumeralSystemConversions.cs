// Problem 5.	Numeral System Conversions
// Convert 1234d to binary and hexadecimal numeral systems.
// Convert 1100101b to decimal and hexadecimal numeral systems.
// Convert ABChex to decimal and binary numeral systems.

using System;
using System.Collections.Generic;
using System.Linq;

class NumeralSystemConversions
{
    static void Main()
    {
    // 1. Convert 1234d to binary and hexadecimal numeral systems.
        Console.WriteLine("1. Convert 1234d to binary \nand hexadecimal numeral systems:\n");

            // to binary:
        Console.WriteLine("The binary representation of 1234 is \n{0}\n", Convert.ToString(1234, 2));

            // to hexadecimal:
        Console.WriteLine("The hexadecimal representation of 1234 is \n{0:X}\n", 1234);

    // 2. Convert 1100101b to decimal and hexadecimal numeral systems.
        Console.WriteLine("2. Convert 1100101b to decimal \nand hexadecimal numeral systems:\n");

        // to decimal:
        Console.WriteLine("The decimal representation of 1100101b is \n{0}\n", Convert.ToInt32("1100101", 2));

        // to hexadecimal:
        string hexNumber = Convert.ToInt32("1100101", 2).ToString("X");
        Console.WriteLine("The hexadecimal representation of 1100101b is \n{0:X}\n", hexNumber);

    // 3. Convert ABChex to decimal and binary numeral systems.
        Console.WriteLine("3. Convert ABChex to decimal \nand binary numeral systems:\n");

        // to decimal:
        Console.WriteLine("The decimal representation of ABChex is \n{0}\n", Convert.ToInt32("ABC", 16));

        // to binary:
        string binary = Convert.ToString(Convert.ToInt32("ABC", 16), 2);
        Console.WriteLine("The hexadecimal representation of ABChex is \n{0:X}\n", binary);
    }
}

