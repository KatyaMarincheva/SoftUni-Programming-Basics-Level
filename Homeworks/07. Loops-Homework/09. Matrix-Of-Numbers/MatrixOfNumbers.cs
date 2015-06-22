//Problem 9. Matrix of Numbers

/* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix like in the examples below. Use two nested loops.

Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        // input
        int n;
        do
        {
            Console.Write("\nPlease enter a positive integer number n (1 <= n <= 20): ");
            n = int.Parse(Console.ReadLine());
        } while (!(1 <= n && n <= 20));
        
        // logic
        for (int row = 0; row < n; row++) // rows
        {
            for (int column = 0; column < n; column++) // columns
            {
                Console.Write("{0, 3}", ((row +1 ) + column));

            }
            Console.WriteLine(); // go to next line after each row
        }
    }
}

