/* Problem 3 – Magic Wand
As we all know programmers often make mistakes in their code. They spend hours and hours trying to figure out where the problem is. 
 * Some are praying for the code to fix itself, others are searching for magical rainbow unicorns to help them with their problem. 
 * One day, the programmers Gesho and Posho discovered a way to build magic wands that solve their coding problems. 
 * Your task is to help Gesho and Posho to build a magic wand. 
Input
The input data should be read from the console. 
On the only input line you have an integer number N. The width of the wand is 3*N+2. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. You must print the magic wand on the console. 
Each row contains characters "." (dot) and "*" (asterisk).
Constraints
•	The number N will always be an odd integer number in the range [5…39].
 */

using System;
using System.Globalization;

class MagicWand
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // counts
        int topSidesCount = (3 * N + 2) / 2;
        int topInCount = 1;

        // strings 
        string topSides = new string('.', topSidesCount);
        string upperHeadIn = new string('.', topInCount);

        // printing
        Console.WriteLine("{0}*{0}", topSides);

        for (int i = 0; i < (N + 3)/2 -1; i++)
        {
            upperHeadIn = new string('.', topInCount);
            topSides = new string('.', topSidesCount - 1);
            Console.WriteLine("{0}*{1}*{0}", topSides, upperHeadIn);
            topSidesCount--;
            topInCount += 2;
        }

        upperHeadIn = new string('.', topInCount);
        string firstHands = new string('*', N);
        Console.WriteLine("{0}{1}{0}", firstHands, upperHeadIn);

        topInCount = 3 * N - 2;
        topSidesCount = 1;
        for (int j = 0; j < N/2; j++)
        {
            upperHeadIn = new string('.', topInCount);
            topSides = new string('.', topSidesCount);
            Console.WriteLine("{0}*{1}*{0}", topSides, upperHeadIn);
            topSidesCount++;
            topInCount -= 2;
        }

        topSidesCount -=2;
        int upperHeadMiddleCount = 0;
        topInCount = N;
        string headConst = new string('.', N / 2);
        string upperHeadMiddle = new string('.', upperHeadMiddleCount);

        for (int j = 0; j < N / 2; j++)
        {
            upperHeadIn = new string('.', topInCount);
            upperHeadMiddle = new string('.', upperHeadMiddleCount);
            topSides = new string('.', topSidesCount);
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", topSides, headConst, upperHeadMiddle, upperHeadIn);
            topSidesCount--;
            upperHeadMiddleCount++;
        }


        string secondHands = new string('*', (N + 1) / 2);
        upperHeadMiddle = new string('.', upperHeadMiddleCount);
        Console.WriteLine("{0}{1}*{2}*{1}{0}", secondHands, upperHeadMiddle, upperHeadIn);

        topSidesCount =N;
        topInCount = N;
        upperHeadIn = new string('.', topInCount);
        topSides = new string('.', topSidesCount);

        for (int k = 0; k < N; k++)
        {
            Console.WriteLine("{0}*{1}*{0}", topSides, upperHeadIn);
        }

        string wandBase = new string('*', N + 2);
        Console.WriteLine("{0}{1}{0}", topSides, wandBase);
    }
}

