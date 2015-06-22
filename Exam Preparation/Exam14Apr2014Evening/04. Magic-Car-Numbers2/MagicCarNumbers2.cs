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

class MagicCarNumbers2
{
    static int count = 0;

    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        for (int l1 = 0; l1 < letters.Length; l1++)
        {
            for (int l2 = 0; l2 < letters.Length; l2++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    CheckCarNumber("CA" + a + a + a + a + letters[l1] + letters[l2], magicWeight);
                    for (int b = 0; b <= 9; b++)
                    {
                        if (b != a)
                        {
                            CheckCarNumber("CA" + a + a + a + b + letters[l1] + letters[l2], magicWeight);
                            CheckCarNumber("CA" + a + b + b + b + letters[l1] + letters[l2], magicWeight);
                            CheckCarNumber("CA" + a + a + b + b + letters[l1] + letters[l2], magicWeight);
                            CheckCarNumber("CA" + a + b + a + b + letters[l1] + letters[l2], magicWeight);
                            CheckCarNumber("CA" + a + b + b + a + letters[l1] + letters[l2], magicWeight);
                        }
                    }
                }
            }
        }

        Console.WriteLine(count);
    }

    static void CheckCarNumber(string carNumber, int magicSum)
    {
        int weight = 0;
        foreach (var ch in carNumber)
        {
            if (ch >= '0' && ch <= '9')
            {
                weight += (ch - '0');
            }
            else
            {
                weight += (10 * (ch - 'A' + 1));
            }
        }

        if (weight == magicSum)
        {
            count++;
            //Console.WriteLine(carNumber);
        }
    }
}

