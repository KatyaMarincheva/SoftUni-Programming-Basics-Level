// Problem 15.	* Joro, the Football Player
/* Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Joro plays in 1/2 of the holidays and once in the weekends, but not every weekend – only when he is not tired and only when he is not going to his hometown. Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”. Joro is tired in 1/3 of the normal weekends. When Joro is at his hometown, he always plays football with his old friends once, at Sunday. In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days. We assume the year has exactly 52 weekends.
Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number).
Input
The input data should be read from the console. It consists of three input values, each at separate line:
•	The string “t” for leap year or “f” for year that is not leap.
•	The number p – number of holidays in the year (which are not Saturday or Sunday).
•	The number h – number of weekends that Joro spends in his hometown.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print an integer representing how many times Joro plays football for a year.
 */

using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        // input
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        // declarations
        const int weekendsPerYear = 52;

        // logic
        // 1/2 of the holidays = p/2
        // twice in the weekends = weekendsPerYear * 2
        // not tired in 1/3 of the normal weekends = (weekendsPerYear * 2)/3
        // only when he is not going to his hometown = ((weekendsPerYear - h) * 2)/3
        // at his hometown, he always plays football with his old friends once, at Sunday += h
        int numberOfPlays = p / 2 + ((weekendsPerYear - h) * 2) / 3 + h; // in a normal year

        // if the year is leap, Joro plays football 3 more times additionally, in non-weekend days += 3
        if (year == "t")
        {
            numberOfPlays = p / 2 + ((weekendsPerYear - h) * 2) / 3 + h + 3;
        }

        // printing
        Console.WriteLine(numberOfPlays);
    }
}

