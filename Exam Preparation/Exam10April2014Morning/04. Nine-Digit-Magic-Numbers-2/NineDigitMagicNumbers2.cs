/* Problem 18.	** Nine-Digit Magic Numbers
This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution 
 * here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of digits, 
 * as well as to split them into triples with special properties. Help her to calculate very special numbers called “nine-digit magic numbers”.
You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi, 
 * such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi.
 * Numbers holding these properties are also called “nine-digit magic numbers”.
Your task is to write a program to print these numbers in increasing order.
Input
•	The input data should be read from the console.
•	The number sum stays at the first line.
•	The number diff stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. Print all nine-digit magic numbers matching
 * given difference diff and given sum of digits sum, in increasing order, each at a separate line. In case no nine-digit magic numbers exits, print “No”.
 */

using System;
using System.Collections.Generic;

class NineDigitMagicNumbers2
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        Dictionary<int, int> numbers = new Dictionary<int, int>();
        char[] chars = { '1', '2', '3', '4', '5', '6', '7' };
        int[] digits = { 1, 2, 3, 4, 5, 6, 7 };

        int resultsCount = 0;
        for (int d1 = 0; d1 < 7; d1++)
        {
            for (int d2 = 0; d2 < 7; d2++)
            {
                for (int d3 = 0; d3 < 7; d3++)
                {
                    string first = "" + chars[d1] + chars[d2] + chars[d3];
                    int tempSum1 = digits[d1] + digits[d2] + digits[d3];
                    int num1 = int.Parse(first);

                    for (int d4 = 0; d4 < 7; d4++)
                    {
                        for (int d5 = 0; d5 < 7; d5++)
                        {
                            for (int d6 = 0; d6 < 7; d6++)
                            {
                                string second = "" + chars[d4] + chars[d5] + chars[d6];
                                int tempSum2 = digits[d4] + digits[d5] + digits[d6];
                                int num2 = int.Parse(second);

                                if (num2 == num1 + diff)
                                {
                                    for (int d7 = 0; d7 < 7; d7++)
                                    {
                                        for (int d8 = 0; d8 < 7; d8++)
                                        {
                                            for (int d9 = 0; d9 < 7; d9++)
                                            {
                                                string third = "" + chars[d7] + chars[d8] + chars[d9];
                                                int tempSum3 = digits[d7] + digits[d8] + digits[d9];
                                                int num3 = int.Parse(third);

                                                if (num3 == num2 + diff && tempSum1 + tempSum2 + tempSum3 == sum)
                                                {
                                                    Console.WriteLine(first + second + third);
                                                    resultsCount++;
                                                }
                                            }
                                        }
                                    }
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


