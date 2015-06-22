// Problem 1. Exchange If Greater

/* Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

Examples:
a 	    b 	    result
5 	    2 	    2 5
3 	    4 	    3 4
5.5 	4.5 	4.5 5.5
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // input
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("\nEnter a vallue for b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("\n{0, -10}{1, -10}{2, -10}", "a", "b", "result");
        Console.Write("{0, -10}{1, -10}", a, b);
        // condition
        if (a > b)
        {
            // exchanging values
            a = a + b;
            b = a - b;
            a = a - b;
        }

        // printing the result
        Console.Write("{0, -5}{1, -5}\n\n", a, b);
    }
}

