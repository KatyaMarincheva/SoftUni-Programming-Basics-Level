/* /* Problem 19.	*** Bits Inverter
This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution 
 * here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
Once Teodor played the following game: he started from a sequence of white and black balls 
 * and flipped the color of the 1st ball, then the color of the 4th ball, then the color of the 7th ball, etc. until the last ball. 
 * Flipping was performed by replacing a black b all with a white ball and vice versa. Teodor was a smart mathematician 
 * so he wanted to generalize his game in a formal way. This is what he invented.
You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  
 * You are given also a number step. Write a program to invert the bits at positions: 1, 1 + step, 1 + 2*step, ... 
 * Print the output as a sequence of bytes.
Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1.
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

class BitsInverter2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                index++;
                if (index % step == 1 || (step == 1))
                {
                    int mask = 1 << bitIndex;
                    num = num ^ mask;

                }
            }

            Console.WriteLine(num);
        }
    }
}

