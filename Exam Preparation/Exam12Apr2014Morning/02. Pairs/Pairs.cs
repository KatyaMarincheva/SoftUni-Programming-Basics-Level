/* Problem 14.	* – Pairs
You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, 
 * the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. 
 * Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.
Input
You are given at the console even number of integers, all in a single line, separated by a space.
Output
The output is single line, printed at the console.
•	In case all pairs have the same value, print "Yes, value=…" and the value.
•	Otherwise, print "No, maxdiff=…" and the maximal difference between two consecutive values, always a positive integer.
 * 
 * Examples
Input	        Output	
1 2 0 3 4 -1    Yes, value=3
1 2 2 2         No, maxdiff=1
 */

using System;
using System.Linq;

class Pairs
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxdiff = int.MinValue;
        bool equal = true;

        int sum = numbers.Take(2).Sum();

        for (int i = 2; i < numbers.Length; i += 2)
        {
            int tempsum = numbers.Skip(i).Take(2).Sum();
            if (tempsum != sum)
            {
                equal = false;
            }

            int tempdiff = Math.Abs(sum - tempsum);
            if (tempdiff > maxdiff)
            {
                maxdiff = tempdiff;
            }

            sum = tempsum;
        }

        if (equal == true)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }

    }
}

