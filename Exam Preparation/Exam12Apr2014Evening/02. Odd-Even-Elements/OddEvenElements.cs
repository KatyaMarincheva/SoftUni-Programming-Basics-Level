/* Problem 21.	** – Odd / Even Elements
You are given N numbers. Calculate the sum, min and max of its odd elements and sum, min and max of its even elements. 
 * Consider that the first element is odd, the second is even, etc.
Input
The input data should be read from the console. It will consists of exactly one line.
•	At the first line N numbers will be given, separated one from another by a single space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
You have to print the output in a single line at the console in the following format:
•	OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…
Print the numbers in the output without any unneeded trailing zeroes (i.e. print 1.5 instead of 1.50; 1 instead of 1.00). 
 * In case the sum, the minimal or the maximal element cannot be calculated (due to missing data), print "No".
Constraints
•	All numbers in the input will be in the range [-1 000 000 … 1 000 000], with no more than 10 digits (total, before and after the decimal point). 
 * The decimal separator in the non-integer numbers will be '.' and the numbers will have up to 2 digits after the decimal separator.
•	The count N of the numbers in the input is in the range [0 … 1000].
•	All numbers in the output should be formatted without unneded trailing zeroes.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<decimal> nums = new List<decimal>();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        {
            nums = input.Split(' ').Select(decimal.Parse).ToList();
        }

        int length = nums.Count;
        List<decimal> odd = new List<decimal>();
        List<decimal> even = new List<decimal>();

        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 0)
            {
                odd.Add(nums[i]);
            }
            else
            {
                even.Add(nums[i]);
            }
        }

        if (length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", odd.Sum().ToString("G29"), odd.Min().ToString("G29"), odd.Max().ToString("G29"));
        }
        else if (length > 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                odd.Sum().ToString("G29"), odd.Min().ToString("G29"), odd.Max().ToString("G29"), even.Sum().ToString("G29"), even.Min().ToString("G29"), even.Max().ToString("G29"));
        }
    }
}

