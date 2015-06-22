// Problem 17.* Calculate GCD

/*    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).

Examples:
a 	     b 	    GCD(a, b)
3 	     2 	    1
60 	    40 	   20
5 	   -15 	    5
*/

using System;

class CalculateGCD
{
    static void Main()
    {
        // input
        Console.Write("\nPlease enter the first number: ");
        int biggerNumber = int.Parse(Console.ReadLine());
        Console.Write("\nPlease enter the second number: ");
        int smallerNumber = int.Parse(Console.ReadLine());

        // we need to first determine which one of the numbers is the bigger one
        // and if the initially decalred bigger number is actually the smaller one -
        // we swap their values
        if (biggerNumber < smallerNumber)
        {
            biggerNumber = biggerNumber + smallerNumber;
            smallerNumber = biggerNumber - smallerNumber;
            biggerNumber = biggerNumber - smallerNumber;
        }

        // logic: The Euclidean algorithm is based on the principle that 
        // the greatest common divisor of two numbers does not change if the larger number
        // is replaced by its difference with the smaller number. 
        int divisor = (biggerNumber % smallerNumber);

        while (divisor != 0)
        {
            biggerNumber = smallerNumber;
            smallerNumber = divisor;
            divisor = biggerNumber % smallerNumber;
        }

        Console.WriteLine("\nGCD = {0}\n", smallerNumber);
    }
}

