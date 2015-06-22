 // Problem 8. Prime Number Check

 /* Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive

Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false
  */

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        string intro = @"This program checks 
if a given positive integer number n (n <= 100) is prime.";
        Console.WriteLine(intro);

        string input;
        int num;

#region creates a comparison list of all not-prime numbers between 1 and 100

        List<int> notPrime = new List<int>();

        // sieve of Eratosthenes - excludes gradually all numbers which can be divided by 2, 3, 5, 7
        // you can confirm this with the y locals values in debug mode
        // I have chosen this loop solution, because the loop length can be easily ammended
        // to include any bigger range of numbers

        for (int x = 2; x < 100; x++)
        {
            for (int y = x * 2; y < 100; y = y + x)
            {

                if (!notPrime.Contains(y))
                {
                    notPrime.Add(y);
                }

            }

        }

#endregion
        
        do  // validates number input
        {
            Console.Write("\nPlease enter a number between 0 and 100: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num) || num < 0 || num > 100);

        // checks if the input number is in the created comparison list of not-prime numbers
        Console.WriteLine( (!notPrime.Contains(num))? "\nPrime\n" : "\nNot Prime\n" );
    }
}

