//Problem 4. Multiplication Sign

/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
 a 	    b 	    c 	    result
 5 	    2 	    2 	    +
-2 	   -2 	    1 	    +
-2 	    4 	    3 	    -
 0 	   -2.5 	4 	    0
-1     -0.5    -5.1 	-
 */

using System;

class Program
{
    static void Main()
    {
        // declarations
        int signCounter = 0;

        // input
        Console.Write("\nPlease, enter a value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("\n{0, -8}{1, -8}{2, -8}{3, -8}", "a", "b", "c", "result");
        // logic
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("{0, -8}{1, -8}{2, -8}{3, -8}\n", a, b, c, "0");
        }

        else
        {
            if (a < 0)
            {
                signCounter++;
            }
            if (b < 0)
            {
                signCounter++;
            }
            if (c < 0)
            {
                signCounter++;
            }

            if (signCounter%2 == 0)
            {
                Console.WriteLine("{0, -8}{1, -8}{2, -8}{3, -8}\n", a, b, c, "+");
            }
            else
            {
                Console.WriteLine("{0, -8}{1, -8}{2, -8}{3, -8}\n", a, b, c, "-");
            }
        }
    }
}

