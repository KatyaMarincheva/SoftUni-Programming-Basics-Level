// Problem 6. The Biggest of Five Numbers

/* Write a program that finds the biggest of five numbers by using only five if statements.

Examples:
 a 	    b 	    c 	    d 	    e 	    biggest
 5 	    2 	    2 	    4 	    1 	    5
-2 	  -22 	    1 	    0 	    0 	    1
-2  	4 	    3 	    2 	    0 	    4
 0 	   -2.5 	0 	    5 	    5 	    5
-3 	   -0.5    -1.1    -2 	 -0.1 	 -0.1
 */
using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        // intro
        string intro = "This program finds the biggest of five numbers.";
        Console.WriteLine(intro);

        // input
        Console.Write("\nPlease, enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for e: ");
        double e = double.Parse(Console.ReadLine());

        Console.WriteLine("\n{0, -8}{1, -8}{2, -8}{3, -8}{4, -8}{5, -8}", "a", "b", "c", "d", "e", "biggest");
        // logic
        double biggest = double.MinValue;
        
        if (a > biggest)
        {
            biggest = a;
        }
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }

        Console.WriteLine("{0, -8}{1, -8}{2, -8}{3, -8}{4, -8}{5, -8}\n", a, b, c, d, e, biggest);
    }
}

