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
        string S = Console.ReadLine();
        S = S.ToLower();
        int letSum = 0;
        for (int i = 0; i < S.Length; i++)
        {
            letSum += S[i] - 'a' + 1;
        }

        char[] chars = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int resultsCount = 0;
        for (int d1 = 0; d1 < 9; d1++)
        {
            for (int d2 = 0; d2 < 9; d2++)
            {
                for (int d3 = 0; d3 < 9; d3++)
                {
                    string first = "" + chars[d1] + chars[d2] + chars[d3];
                    int tempProd1 = digits[d1] * digits[d2] * digits[d3];

                    for (int d4 = 0; d4 < 9; d4++)
                    {
                        for (int d5 = 0; d5 < 9; d5++)
                        {
                            for (int d6 = 0; d6 < 9; d6++)
                            {
                                string second = "" + chars[d4] + chars[d5] + chars[d6];
                                int tempProd2 = digits[d4] * digits[d5] * digits[d6];

                                if (tempProd1 == tempProd2 && tempProd2 == letSum)
                                {

                                    Console.WriteLine("{0}-{1}", first, second);
                                    resultsCount++;

                                }

                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}

