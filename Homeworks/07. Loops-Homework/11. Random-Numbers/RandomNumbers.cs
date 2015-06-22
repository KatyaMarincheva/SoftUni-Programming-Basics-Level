// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
/* Examples:
 n 	    min 	max 	random numbers
 5 	    0 	    1 	1 0 0 1 1
10     10 	   15 	12 14 12 15 10 12 14 13 13 11

Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 */

using System;

class RandomNumbers
{
    static void Main()
    {
        // declarations
        int n, min, max;
        // input
        Console.Write("Please, enter a value for n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for min: ");
        min = int.Parse(Console.ReadLine());

        do // validating max input
        {
            Console.Write("Please, enter a value for max, so that (min != max): ");
            max = int.Parse(Console.ReadLine());
        } while (min == max);

        // logic
        Console.Write("\n{0} random numbers in the range {1}...{2}: ", n, min, max);

        Random rand = new Random(); // Random Class
        for (int i = 0; i < n; i++)
        {                       
            Console.Write("{0} ", rand.Next(min, max + 1)); //Random.Next() returns a non-negative random integer.
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

