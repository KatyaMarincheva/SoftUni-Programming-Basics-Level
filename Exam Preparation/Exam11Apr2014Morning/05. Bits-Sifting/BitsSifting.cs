/* Problem 21.	** – Bit Sifting
This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
In this problem we'll be sifting bits through sieves (sift = пресявам, sieve = сито).
You will be given an integer, representing the bits to sieve, and several more numbers, representing the sieves the bits will fall through. 
 * Your task is to follow the bits as they fall down, and determine what comes out of the other end.
Example
For this example, imagine we are working with 8-bit integers (the actual problem uses 64-bit ones). 
 * Let the initial bits be given as 165 (10100101 in binary), and the sieves be 138 (10001010), 84 (01010100) and 154 (10011010). 
 * The 1 bits from the initial number fall through the 0 bits of the sieves and stop if they reach a 1 bit; if they make it to the end, 
 * they become a part of the final number.
In this case, the final number is 33 (00100001), which has two 1 bits in its binary form – the answer is 2.	
10100101
↓ ↓  ↓ ↓
10001010
  ↓  ↓ ↓
01010100
  ↓    ↓
10011010
  ↓    ↓
00100001
Input
The input data should be read from the console.
•	On the first line of input, you will read an integer representing the bits to sieve.
•	On the second line of input, you will read an integer N representing the number of sieves.
•	On the next N lines of input, you will read N integers representing the sieves.
The input data will always be valid and in the format described. There is no need to check it.
Output
The output must be printed on the console.
On the single line of the output you must print the count of "1" bits in the final result.
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

class BitsSifting
{
    static void Main()
    {
        // input;
        ulong number = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        ulong sieve;
        ulong mask;
        for (int i = 0; i < n; i++)
        {
            sieve = ulong.Parse(Console.ReadLine());
            mask = number & sieve;
            number ^= mask;
        }

        int counter = 0;

        // first "1"-bits counting algorithm
        for (int i = 0; i < 64; i++)
        {
            if (1 == (number & 1))
            {
                counter++;
            }
            number = number >> 1;
        }

        // second "1"-bits counting algorithm 
        //- comment the upper one and uncomment this one if you want to try it
        //for (int i = 0; i < 64; i++)
        //{
        //    mask = (ulong)1 << i;
        //    ulong result = number & mask;
        //    if (result == mask)
        //    {
        //        counter++;
        //    }
        //}

        // all "1"-bits counting algorithms are string-based
        // for them to work we need a binary string representation of our number
        //ulong remainder;
        //string binary = string.Empty;
        //while (number > 0)
        //{
        //    remainder = number % 2;
        //    number /= 2;
        //    binary = remainder.ToString() + binary;
        //}

        // third "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //for (int i = 0; i < binary.Length; i++)
        //{
        //    if (binary[i] == '1')
        //    {
        //        counter++;
        //    }
        //}

        // forth "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //counter = binary.Count(x => x == '1');

        // fifth "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //counter = binary.Where(x => x == '1').Count();

        // sixth "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //counter = binary.Split('1').Length - 1;

        // seventh "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //counter = binary.Length - (binary.Replace("1", "").Length);

        // eighth "1"-bits counting algorithm
        //- comment the upper one and uncomment this one if you want to try it
        //string pattern = "1";
        //counter = Regex.Matches(binary, pattern).Count;

        Console.WriteLine(counter);
    }
}


