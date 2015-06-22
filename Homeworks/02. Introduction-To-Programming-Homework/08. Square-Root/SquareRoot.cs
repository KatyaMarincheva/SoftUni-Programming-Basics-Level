// Problem 8. Square Root - Create a console application that calculates and prints the square root of the number 12345.
// Find in Internet “how to calculate square root in C#”.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Title = "Square Root";

        double squareRoot = Math.Sqrt(12345);
        Console.WriteLine("The square root of 12345 is: {0}", squareRoot);

        // the number formating {0:0.00} is a way of rounding the result
        Console.WriteLine("And here rounded, \nto 2 digits after the decimal point: {0:0.00}", squareRoot);

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}