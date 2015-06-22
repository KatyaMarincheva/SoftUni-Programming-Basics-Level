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
using System.Linq;

class NineDigitMagicNumbers
{
    static void Main(string[] args)
    {
        // input
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        // declarations
        // create and store all posible 3-digit combinations of the digits 1234567
        IEnumerable<string> combinations = CombinationsWithRepition("1234567", 3);
        List<string> workCopy = combinations.ToList();
        List<int> numbers = workCopy.Select(int.Parse).ToList();
        List<string> result = new List<string>();

        // logic
        for (int i = 0; i < numbers.Count; i++)
        { 
            // checking if our numbers list of combinations
            // contains the numbers (numbers[i] + diff) and (numbers[i] + diff + diff)
            // if yes...
            int temp1 = numbers[i] + diff;
            if (numbers.Contains(temp1))
            {
                int temp2 = temp1 + diff;
                if (numbers.Contains(temp2))
                {
                    // if yes... - calculating the sum of the digits of all 3 numbers 
                    int tempSum = 0;
                    for (int l = 1; l <= 3; l++)
                    {
                        tempSum += GetDigit(numbers[i], l);
                        tempSum += GetDigit(temp1, l);
                        tempSum += GetDigit(temp2, l);
                    }

                    // checking if the sum of the digits of all 3 numbers is eqal to the input sum value
                    if (tempSum == sum)
                    {
                        string x = workCopy[i] + temp1.ToString() + temp2.ToString();
                        // if yes, the combination of the three 3-digit number fors a 9-digit number
                        // and we add it to the result list
                        result.Add(x);
                    }
                }
            }
        }

        // printing
        if (result.Count > 0)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    #region Create all combinations with repetitions 7 choose 3
    static String Convert(string symbols, int number, int totalLen)
    {
        var result = "";
        var len = symbols.Length;
        var nullSym = symbols[0];
        while (number > 0)
        {
            var index = number % len;
            number = number / len;
            result = symbols[index] + result;
        }
        return result.PadLeft(totalLen, nullSym);
    }

    static IEnumerable<String> CombinationsWithRepition(string symbols, int len)
    {
        for (var i = 0; i < Math.Pow(symbols.Length, len); i++)
            yield return Convert(symbols, i, len);
    }

    #endregion

    // GetDigit method - splits an int into digits
    static int GetDigit(int number, int digit)
    {
        return (number / (int)Math.Pow(10, digit - 1)) % 10;
    }
}

