// Problem 9. Trapezoids

/* Write an expression that calculates trapezoid's area by given sides a and b and height h.

Examples:
a 	    b 	    h 	    area
5 	    7    	12 	    72
2 	    1 	    33 	    49.5
8.5 	4.3 	2.7 	17.28
100 	200 	300 	45000
0.222 	0.333 	0.555 	0.1540125  */

using System;

class Trapezoids
{
    static void Main()
    {
        string inputA;
        int a;

        string inputB;
        int b;

        string inputH;
        int h;

        string intro =
    @"This program calculates trapezoid's area
by given sides a and b and height h.";

        Console.WriteLine(intro);

        do  // validates input for a
        {
            Console.Write("\nPlease enter a value for a: ");
            inputA = Console.ReadLine();

        } while (!int.TryParse(inputA, out a));


        do  // validates input for b
        {
            Console.Write("\nPlease enter a value for b: ");
            inputB = Console.ReadLine();

        } while (!int.TryParse(inputB, out b));


        do  // validates input for h
        {
            Console.Write("\nPlease enter a value for h: ");
            inputH = Console.ReadLine();

        } while (!int.TryParse(inputH, out h));

        // calculates and prints trapezoid area
        Console.WriteLine("\na = {0}; b = {1}; h = {2}; area = {3}\n", a, b, h, ((a + b)/2)*h );
    }
}

