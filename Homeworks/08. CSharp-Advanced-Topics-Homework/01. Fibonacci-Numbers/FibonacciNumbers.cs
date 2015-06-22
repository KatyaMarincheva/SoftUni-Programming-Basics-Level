/* Problem 1.	Fibonacci Numbers
Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393
 */

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        //declarations
        double n;
        BigInteger fibN;
        double phi = (1 + Math.Sqrt(5)) / 2; // formula for phi (the golden ratio)

        //user input
        do // validates input for n
        {
            Console.Write("Please, enter an integer value for n: ");
        } while (!double.TryParse(Console.ReadLine(), out n) || n <= 0);


        //logic - calculates Fib(n)
            fibN = (BigInteger)Math.Round((Math.Pow(phi, n + 1) - Math.Pow((1 - phi), n + 1)) / Math.Sqrt(5));

        // print
        Console.WriteLine("\n{0, -6}{1, -26}", "n", "Fib(n)");
        Console.WriteLine("{0, -6}{1, -26}\n", n, fibN);
    }
}


