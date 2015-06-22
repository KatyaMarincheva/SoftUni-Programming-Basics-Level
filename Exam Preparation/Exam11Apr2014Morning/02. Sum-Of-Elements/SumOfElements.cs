/* Problem 14.	**– Sum of Elements
This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
You are given n numbers. Find an element that is equal to the sum of all of the other elements.
Input
Input data should be read from the console.
•	At the only line in the input a sequence of integers stays (numbers separated one from another by a space).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console. At the only line of the output print the result.
•	Print "Yes, sum=…" if there is an element that is equal to the sum of all other elements, along with this sum.
•	Print "No, diff=…" if there is no element that is equal to the sum of all other elements. 
 * Print also the minimum possible difference between an element from the sequence and the sum of all other elements (always a positive number).
  */

using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        // input
        decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        // logic
        bool equal = false;
        decimal difference = decimal.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers.Sum() - numbers[i] == numbers[i])
            {
                Console.WriteLine("Yes, sum={0}", numbers[i]);
                return;
            }

            else
            {
                decimal diff = Math.Abs((numbers.Sum() - numbers[i] - numbers[i]));
                // if a next difference is smaller than the current one - it will replace it
                if (diff < difference)
                {
                    difference = diff;
                }
            }
        }

        // if no equal sum is found: print No, ....
        if (equal == false)
        {
            Console.WriteLine("No, diff={0}", difference);
        }
    }
}


