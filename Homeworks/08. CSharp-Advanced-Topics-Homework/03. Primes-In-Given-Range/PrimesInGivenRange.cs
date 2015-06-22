/* Problem 3.	Primes in Given Range
Write a method that calculates all prime numbers in given range and returns them as list of integers:
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
Write a method to print a list of integers. Write a program that enters two integer numbers 
 * (each at a separate line) and prints all primes in their range, separated by a comma.
Examples:
Start number
End number	Output
0
10	        2, 3, 5, 7
 * 
5
11	        5, 7, 11
 * 
100 
200	        101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199
250
950	        251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 
            379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 
            503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 
            643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 
            787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947
 * 
100
50	(empty list)
 */

using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.Write("Please, enter a value for range start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for range end: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("\n{0, -12}\n{1, -12}{2}", "Start number", "End number", "Output");
        List<int> range = FindPrimesInRange(start, end);
        Console.WriteLine("{0, -12}\n{1, -12}{2}", start, end, string.Join(" ", range));
    }

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        // declarations
        List<int> myRange = new List<int>();

        // we will use this bool array, to store the information about postions between 1 and 10 000 000 
        // at which the numbers are prime or not-prime
        bool[] bigArr = new bool[10000000];

        // we first set all positions in the bool array to true, all numbers will be considered prime unless proven otherwise
        for (int i = 2; i < bigArr.Length; i++)
        {
            bigArr[i] = true;
        }

        // this for loop supplies the base numbers for the calculation of the not-prime numbers
        for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
        {
            // we will do the below calculations only with values of i whose positions in the array are not yet marked as false
            // or in other words, those values of i are note yet marked as not-prime
            if (bigArr[i])
            {
                // and here the not prime numbers get calculated: j = i * i (the square of i is definitely not prime), 
                // and et each step j increases with one more i; example: j = 2 * 2; and increases with 2 at each step
                // so we get: 2 * 2 + 2 = 3 * 2; +2 = 4 * 2 and we calculate all multiples of i (2) within the given range
                for (int j = i * i; j < bigArr.Length; j = j + i)
                {
                    bigArr[j] = false; // for all multiples of i; we mark their positions in the bool array as false, they are not prime
                }
            }
        }

        // taking my range primes only
        for (int i = startNum; i <= endNum; i++)
        {
            if (bigArr[i])
            {
                myRange.Add(i);
            }
        }
        return myRange;
    }
}

