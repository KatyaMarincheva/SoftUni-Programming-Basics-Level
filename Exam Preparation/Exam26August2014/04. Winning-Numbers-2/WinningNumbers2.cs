/* Problem 4 – Winning Numbers
We are given a string S consisting of capital and non-capital letters. Every letter has a value equal to its position 
 * in the English alphabet (a=1, b=2, …, z=26). First you have to calculate the sum of all letters letSum. 
 * Then, find all 6-digits numbers in range [000 000 … 999 999] called winning numbers for which the following is true: 
 * the product of the first three digits is equal to the product of the second three digits, and both of those are equal to letSum. 
 * Your task is to print on the console all winning numbers.
Input
The input data should be read from the console. It consists of 1 line:
•	On the first line you will be given a string S which will only consist of lower and capital case letters.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of winning numbers in format abc-def in ascending order. 
 * Each winning number should stay alone on a separate line. In case there are no winning numbers, print “No”.
Constraints
•	The string S will have maximal length of 150 characters.
 */

using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        // Calculate the expected sum
        int letSum = 0;
        string inputUppercase = input.ToUpper();
        for (int i = 0; i < inputUppercase.Length; i++)
        {
            letSum += inputUppercase[i] - 'A' + 1;
        }

        // Find all winning numbers
        int count = 0;
        for (int i1 = 0; i1 <= 9; i1++)
        {
            for (int i2 = 0; i2 <= 9; i2++)
            {
                for (int i3 = 0; i3 <= 9; i3++)
                {
                    if (i1 * i2 * i3 == letSum)
                    {
                        for (int i4 = 0; i4 <= 9; i4++)
                        {
                            for (int i5 = 0; i5 <= 9; i5++)
                            {
                                for (int i6 = 0; i6 <= 9; i6++)
                                {
                                    if (i4 * i5 * i6 == letSum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                            i1, i2, i3, i4, i5, i6);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

