/* Problem 4 – Magic Car Numbers
Cars in Sofia have registration numbers in format "CAabcdXY" where a, b, c and d are digits from 0 to 9 and X and Y are 
 * letters from the following subset of the Latin alphabet: 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T' and 'X'. 
 * Examples of car numbers from Sofia are "CA8517TX", "CA2277PC", "CA0710XC", "CA1111AC", while "CC7512FJ" in not valid car number from Sofia. 
 * Local people are keen to choose special numbers for their cars, know as magic car numbers. They calculate the weight of a car number as follows: 
 * they sum its digits and letters, assuming that letters have the following values: 'A'  10, 'B'  20, 'C'  30, 'E'  50, 'H'  80, 'K'  110, 
 * 'M'  130, 'P'  160, 'T'  200, 'X'  240. For example the weight("CA6511BM") = 30 + 10 + 6 + 5 + 1 + 1 + 20 + 130 = 203. 
 * A magic car number is a car number that has a special magic weight (e.g. 256 or 512 for developers) and its number is in some 
 * of the formats "CAaaaaXY", "CAabbbXY", "CAaaabXY", "CAaabbXY", "CAababXY" and "CAabbaXY", where a and b are two different digits 
 * and X and Y are letters from the Latin alphabet subset { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' }.
Your task is to write a program that calculates how many cars can be registered in Sofia for given magic weight.
Input
The input data should be read from the console. It will consist of a single value: the magic weight.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It is a single value: the number of cars matching given magic value.
Constraints
•	All input numbers will be integers in the range [1…1000].
 */

using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        char[] letterDigits = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        HashSet<string> results = new HashSet<string>();
        for (int d1 = 0; d1 < digits.Length; d1++)
        {
            for (int d2 = 0; d2 < digits.Length; d2++)
            {
                string middle0 = "" + digits[d1] + digits[d1] + digits[d1] + digits[d1];
                string middle1 = "" + digits[d1] + digits[d2] + digits[d2] + digits[d2];
                string middle2 = "" + digits[d2] + digits[d2] + digits[d2] + digits[d1];
                string middle3 = "" + digits[d1] + digits[d1] + digits[d2] + digits[d2];
                string middle4 = "" + digits[d1] + digits[d2] + digits[d1] + digits[d2];
                string middle5 = "" + digits[d1] + digits[d2] + digits[d2] + digits[d1];
                int weightMiddle12 = CalcWeight(middle1);

                int weightMiddle345 = CalcWeight(middle3);
                int weightMiddle0 = CalcWeight(middle0);
                for (int d5 = 0; d5 < letterDigits.Length; d5++)
                {
                    for (int d6 = 0; d6 < letterDigits.Length; d6++)
                    {
                        string right = "" + letterDigits[d5] + letterDigits[d6];
                        int weightRight = CalcWeight(right);
                        if (40 + weightMiddle0 + weightRight == magicWeight)
                        {
                            results.Add("CA" + middle0 + right);
                        }
                        if (40 + weightMiddle12 + weightRight == magicWeight)
                        {
                            results.Add("CA" + middle1 + right);
                            results.Add("CA" + middle2 + right);
                        }
                        if (40 + weightMiddle345 + weightRight == magicWeight)
                        {
                            results.Add("CA" + middle3 + right);
                            results.Add("CA" + middle4 + right);
                            results.Add("CA" + middle5 + right);
                        }
                    }
                }
            }
        }
        Console.WriteLine(results.Count);
    }

    private static int CalcWeight(string str)
    {
        int weight = 0;
        foreach (var ch in str)
        {
            if (Char.IsLetter(ch))
            {
                switch (ch)
                {
                    case 'A': weight += 10; break;
                    case 'B': weight += 20; break;
                    case 'C': weight += 30; break;
                    case 'E': weight += 50; break;
                    case 'H': weight += 80; break;
                    case 'K': weight += 110; break;
                    case 'M': weight += 130; break;
                    case 'P': weight += 160; break;
                    case 'T': weight += 200; break;
                    case 'X': weight += 240; break;
                }
            }

            else if (Char.IsDigit(ch))
            {
                switch (ch)
                {
                    case '0': weight += 0; break;
                    case '1': weight += 1; break;
                    case '2': weight += 2; break;
                    case '3': weight += 3; break;
                    case '4': weight += 4; break;
                    case '5': weight += 5; break;
                    case '6': weight += 6; break;
                    case '7': weight += 7; break;
                    case '8': weight += 8; break;
                    case '9': weight += 9; break;
                }
            }
        }
        return weight;
    }
}


