//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

/* Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
   Use only one loop. Print the result with 5 digits after the decimal point.

Examples:
n 	 x 	    S
3 	 2 	    2.75000
4 	 3 	    2.07407
5 	-4 	    0.75781
 */

using System;

class FactorialSum
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a value for the int n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("\nPlease, enter a value for the int x: ");
        int x = int.Parse(Console.ReadLine());

        // declarations
        decimal factorialN = 1;
        decimal NPowerOfX = 1;
        decimal sum = 1;

        // logic - with each step we increase n!, x^n and the sum                
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            NPowerOfX *= x;
            sum += factorialN / NPowerOfX;
        }

        // print
        Console.WriteLine("\nSum = {0:F5}\n", sum);        
    }
}

