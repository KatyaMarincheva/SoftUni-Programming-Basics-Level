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

public class FiveSpecialLetters
{
    public static void Main()
    {
        long minWeight = long.Parse(Console.ReadLine());
        long maxWeight = long.Parse(Console.ReadLine());

        int resultsCount = 0;
        for (char c1 = 'a'; c1 <= 'e'; c1++)
        {
            for (char c2 = 'a'; c2 <= 'e'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'e'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'e'; c4++)
                    {
                        for (char c5 = 'a'; c5 <= 'e'; c5++)
                        {
                            string word = "" + c1 + c2 + c3 + c4 + c5;
                            long weight = CalcWeight(word);
                            //Console.WriteLine(word + " " + weight);
                            if (weight >= minWeight && weight <= maxWeight)
                            {
                                if (resultsCount > 0)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(word);
                                resultsCount++;
                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.Write("No");
        }
    }

    static long CalcWeight(string word)
    {
        bool[] used = new bool[(int)'e' + 1];
        long weight = 0;
        int index = 1;
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if (!used[letter])
            {
                weight += index * CalcWeight(letter);
                index++;
                used[letter] = true;
            }
        }
        return weight;
    }

    static int CalcWeight(char letter)
    {
        switch (letter)
        {
            case 'a': return 5;
            case 'b': return -12;
            case 'c': return 47;
            case 'd': return 7;
            case 'e': return -32;
        }
        return 0;
    }
}

