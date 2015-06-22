// Problem 6. Print Numbers - Write a program to print the numbers 1, 101 and 1001, each at a separate line.
/* I have discovered that 1, 101, and 1001 are binary numbers forming a number sequence, where the difference between any two terms equals 4
 * so I have decided to use a for loop. */

using System;

class PrintNumbers1
{
    static void Main()
    {
        Console.Title = "Print Numbers 1";

        for (int number = 1; number <= 9; number += 4)
        {
            // with the use of the PadLeft method, I want to emphasize that the printed numbers are, and should be read as bunary numbers
            string binary = (Convert.ToString(number, 2).PadLeft(5));
            Console.WriteLine(binary);
        }
        Console.ReadLine();
    }
}