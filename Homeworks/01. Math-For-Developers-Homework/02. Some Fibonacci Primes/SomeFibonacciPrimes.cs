// Problem 2.	Some Fibonacci Primes
// Check if the 24th, 101st and 251st prime numbers are part of the base Fibonacci number set. What is their position?

// The program below first calculates the first 20 members of the Fibonacci sequence,
// after that compares the 3 prime numbers from Problem 1 (89, 547, 1597) with the Fibonacci sequence and prints the results

using System;
using System.Collections.Generic;
using System.Linq;

class SomeFibonacciPrimes
{
    static void Main()
    {
    //declarations

        // this array will be storing the first 20 numbers of the Fibonacci sequence
        double[] fibonacciNums = new double[20];
        // formula for phi (the golden ratio)
        double phi = (1 + Math.Sqrt(5)) / 2; 

        // this array stores the 24th, 101st, and 251st prime numbers calcullated in Problem 1
        int[] primes = new int[] { 89, 547, 1597};

    //logic 
        // the code below calculates the first 20 numbers of the Fibonacci sequence
        // using the golden ratio formula Xn = Math.Round((Math.Pow(phi, n) - Math.Pow((1 - phi), n)) / Math.Sqrt(5));
        // http://www.mathsisfun.com/numbers/fibonacci-sequence.html
        // and stores them into the nums array
        for (int i = 0; i < 20; i++)
        {
            fibonacciNums[i] = Math.Round((Math.Pow(phi, i) - Math.Pow((1 - phi), i)) / Math.Sqrt(5));
        }
           
    // printing

        // comparing the fibonacciNums and primes arrays, and printing the result:
        for (int i = 0; i < primes.Length; i++)
		{
            Console.Write("The prime number {0} ", primes[i]);
            if (fibonacciNums.Contains(primes[i]))
	        {
                Console.Write("\nis also a member of the Fibonacci sequence, \nat position {0}.\n\n", Array.IndexOf(fibonacciNums, primes[i]));
	        }
            else
            {
                Console.Write("\nis not a member of the Fibnacci sequence.\n\n");
            }
		}        
    }
}

