/* Problem 3 – Dumbbell

As we all know programmers are not bodybuilders and vice versa. But there is one exception. His name is Marcho Zukerberov.  
 * At the moment he is very busy learning how to code in the well-known language “C Diez” and he has only 30 minutes per day 
 * for training. Help Marcho break the rule of becoming an ordinary and overweight programmer by making him a dumbbell 
 * with the weight needed (N kg) for his “gouemi ruki chuek”. 
Input
The input data should be read from the console.
On the only input line you have an integer number N, showing the height of the dumbbell.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. 
The number of lines should be equal to the height N of the dumbbell.
Each line should hold exactly N x 3 symbols: "." (dot) , "*" (asterisk), "=" (equal sign) or “&” (ampersand).
The visible part of the dumbbell bar should be exactly N symbols.
Constraints
•	The number N will always be an odd integer number in the range [5…39].
 */

using System;

class Dumbbell
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // counts
        int outDotsCount = N / 2;
        int inDotsCount = N;
        int starsCount = N / 2;

        // strings
        string firstLast = new string('&', N / 2 + 1);
        string outDots = new string('.', outDotsCount);
        string inDots = new string('.', inDotsCount);
        string stars = new string('*', starsCount);
        string middle = new string('=', inDotsCount);

        // printing
        Console.WriteLine("{0}{1}{2}{1}{0}", outDots, firstLast, inDots);

        outDotsCount--;
        outDots = new string('.', outDotsCount);
        for (int i = 0; i < (N - 3) / 2; i++)
        {
            outDots = new string('.', outDotsCount);
            stars = new string('*', starsCount);
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", outDots, stars, inDots);
            outDotsCount--;
            starsCount++;
        }

        stars = new string('*', starsCount);
        Console.WriteLine("&{0}&{1}&{0}&", stars, middle);

        outDotsCount++;
        starsCount--;
        outDots = new string('.', outDotsCount);
        stars = new string('*', starsCount);
        for (int i = 0; i < (N - 3) / 2; i++)
        {
            outDots = new string('.', outDotsCount);
            stars = new string('*', starsCount);
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", outDots, stars, inDots);
            outDotsCount++;
            starsCount--;
        }

        outDots = new string('.', outDotsCount);
        Console.WriteLine("{0}{1}{2}{1}{0}", outDots, firstLast, inDots);
    }
}

