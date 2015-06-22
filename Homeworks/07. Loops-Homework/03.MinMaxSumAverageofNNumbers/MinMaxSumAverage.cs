// Problem 3. Min, Max, Sum and Average of N Numbers

/* Write a program that reads from the console a sequence of n integer numbers 
 * and returns the minimal, the maximal number, the sum and the average of all numbers 
 * (displayed with 2 digits after the decimal point).
   The input starts by the number n (alone in a line) 
 * followed by n lines, each holding an integer number.
   The output is like in the examples below.

 * Example 1:
input 	output
3       min = 1
2       max = 5
5       sum = 8
1 	    avg = 2.67

Example 2:
input 	output
 2      min = -1
-1      max = 4
 4 	    sum = 3
        avg = 1.50
 */

using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        // input
        Console.Write("Please, enter an integer number: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("\nPlease, enter a value for number {0}: ", i + 1);
            nums[i] = int.Parse(Console.ReadLine());
        }

        // calculations and output formting
        string sequence = String.Join(", ", nums);

        Console.WriteLine("\nNumbers: {0} \nMin = {1} \nMax = {2} \nSum: {3} \nAverage = {4:F2}", sequence, nums.
            Min(), nums.Max(), nums.Sum(), nums.Average());

        Console.WriteLine();
    }
}

