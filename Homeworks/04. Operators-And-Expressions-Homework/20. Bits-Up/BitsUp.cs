/* Problem 20.	** – Bits Up
This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also a number step. 
 * Write a program to set to 1 the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
Input
•	The input data should be read from the console.
•	The number n stays at the first line.
•	The number step stays at the second line.
•	At each of the next n lines n bytes are given, each at a separate line. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. Print exactly n bytes, each at a separate line and in range [0..255], 
 * obtained by applying the bit inversions over the input sequence.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int[] bytes = new int[n];

        StringBuilder allBits = new StringBuilder();


        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            string eightBits = Convert.ToString(temp, 2).PadLeft(8, '0');

            allBits.Append(eightBits);
        }


        for (int j = 1; j < allBits.Length; j += step)
        {
            allBits[j] = '1';
        }
        string outputBits = allBits.ToString();
        for (int i = 0; i < n; i++)
        {
            string x = outputBits.Substring(i * 8, 8);
            bytes[i] = Convert.ToInt32(x, 2);
        }

        foreach (int number in bytes)
        {
            Console.WriteLine(number);
        }
    }
}
