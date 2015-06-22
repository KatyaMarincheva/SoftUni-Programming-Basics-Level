/* Problem 5 – X-Bits
You are given 8 integer numbers. Write a program to count all X-bits. X-bits are groups of 9 bits (3 rows x 3 columns) 
 * forming the letter "X". Your task is to count all X-bits and print their count on the console. 
 * Valid X-bits consist of 3 numbers where their corresponding bit indexes are exactly {"101", "010", "101"}. 
 * All other combinations like: {"111", "010", "101"} or {"111", "111", "111"} are invalid. 
 * All valid X-bits can be part of multiple X-bits (with overlapping). Check the example on the right to understand your task better.
Input
The input data should be read from the console. 
•	On the first 8 lines, you will be given 8 integers.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 1 line:
•	At the first line print the count of the X-bits.
Constraints
•	The 8 input integers will be in the range [0 … 2 147 483 647].
 */

using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                int temp1 = (numbers[i] >> j) & 7;
                int temp2 = (numbers[i + 1] >> j) & 7;
                int temp3 = (numbers[i + 2] >> j) & 7;
                if (temp1 == 5 && temp2 == 2 && temp3 == 5)
                {
                    count++;
                }
            }
        }
        

        Console.WriteLine(count);
    }
}

