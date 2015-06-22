/* Problem 23.	** – Five Special Letters
We are given two numbers: start and end. Write a program to generate all sequences of 5 letters, each from the set { 'a', 'b', 'c', 'd', 'e' }, 
 * such that the weight of these 5 letters is a number in the range [start … end] inclusively. Print them in alphabetical order, in a single line, 
 * separated by a space.
The weight of a single letter is calculated as follows:  weight('a') = 5; weight('b') = -12;  weight('c') = 47;  weight('d') = 7;  weight('e') = -32. 
 * The weight of a sequence of letters c1c2…cn is the calculated by first removing all repeating letters (from right to left) and then calculate the formula:
weight(c1c2…cn) = 1*weight(c1) + 2*weight(c2) + … + n*weight(cn)
For example, the weight of "bcddc" is calculated as follows: First we remove the repeating letters and we get "bcd". Then we apply the formula: 
 * 1*weight('b') + 2*weight('c') + 3*weight('d') = 1*(-12) + 2*47 + 3*7 = 103. 
 * Another example: weight("cadea") = weight("cade") = 1*47 + 2*5 + 3*7 - 4*32 = -50.
Input
The input data should be read from the console. It will consist of 2 lines:
•	The number start stays at the first line.
•	The number end stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of strings in alphabetical order. 
 * Each string should be separated than the next string by a single space. In case no 5-letter strings exist with a weight in the specified range, 
 * print “No”.
Constraints
•	The numbers start and end will be an integers in the range [-10000…10000].
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        List<string> results = new List<string>();

        int resultsCount = 0;

        // building the 5-letter strings
        for (int d1 = 0; d1 < letters.Length; d1++)
        {
            for (int d2 = 0; d2 < letters.Length; d2++)
            {
                for (int d3 = 0; d3 < letters.Length; d3++)
                {
                    for (int d4 = 0; d4 < letters.Length; d4++)
                    {
                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            string temp = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4] + letters[d5];
                            
                            // calculating weight
                            int weight = CalcWeight(temp);

                            // checking if weight is within range
                            if (weight >= start && weight <= end)
                            {
                                // collecting the results
                                results.Add(temp);
                                resultsCount++;
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
        else
        {
            // sorting the results
            results.Sort();
            // printing
            Console.WriteLine(string.Join(" ", results));
        }
    }

    private static int CalcWeight(string str)
    {
        // removing duplicates
        str = new string(str.ToCharArray().Distinct().ToArray());
        int weight = 0;
        for (int i = 0; i < str.Length; i++ )
        {
            switch (str[i])
            {
                case 'a': weight += 5 * (i + 1); break;
                case 'b': weight -= 12 * (i + 1); break;
                case 'c': weight += 47 * (i + 1); break;
                case 'd': weight += 7 * (i + 1); break;
                case 'e': weight -= 32 * (i + 1); break;
            }
        }
        return weight;
    }
}

