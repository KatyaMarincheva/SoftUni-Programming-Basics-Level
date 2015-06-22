/* Problem 17.	**– Volleyball
This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he 
 * is able to play only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, 
 * but not every weekend – only when he is not at work and only when he is not going to his hometown. 
 * Vladi goes at his hometown h weekends in the year. The other weekends are considered “normal”. 
 * Vladi is not at work in 3/4 of the normal weekends. When Vladi is at his hometown, he always plays 
 * volleyball with his old friends once, at Sunday. In addition, if the year is leap, 
 * Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends suitable for volleyball.
Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).
Input
The input data should be read from the console. It consists of three input values, each at separate line:
•	The string “leap” for leap year or “normal” for year that is not leap.
•	The number p – number of holidays in the year (which are not Saturday or Sunday).
•	The number h – number of weekends that Vladi spends in his hometown.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print an integer representing how many times Vladi plays volleyball for a year.
 */

using System;

class Volleyball
{
    static void Main()
    {
        // input
        string year = Console.ReadLine();
        double p = int.Parse(Console.ReadLine());
        double h = int.Parse(Console.ReadLine());

        // plays in 2/3 of the holidays = p * 2/ 3
        // and each Saturday = 48
        // but not every weekend – only when he is not at work and only when he is not going to his hometown = (48 - h)
        // Vladi goes at his hometown h weekends in the year
        // not at work in 3/4 of the normal weekends = (48 - h)* 3 / 4
        // at his hometown, he always plays at Sunday = h
        // if the year is leap, Vladi plays volleyball 15% more times additionally += (result * 15)/100
        // the year has exactly 48 weekends

        double result = p * 2/ 3 + (48 - h)* 3 / 4 + h;
        if (year == "leap")
        {
            result += (result * 15) / 100;
        }

        // the trick: doing all calculations with type double variables, rounding down to in at the very end
        Console.WriteLine((int)result);
    }
}

