/* Problem 3 – Star
You will be given an integer N. Your task is to draw a star on the console. The width of the star is (2*N+1). 
 * The height of the star is (N*2 - (N/2-1)). The top and the middle part height is exactly (N/2). 
 * The height of the legs is (N/2+1). Check the examples below to understand your task better.
Input
The input data is read from the console. The number N stays alone at the first line. 
 * The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a star of size N following the formulas above and the examples below.
Constraints
•	N will be a number between 6 and 36 and will be an even number.
 * 6	
......*......
.....*.*.....
....*...*....
****.....****
.*.........*.
..*.......*..
...*..*..*...
..*..*.*..*..
.*..*...*..*.
****.....****

 */

using System;

class Star
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int width = 2 * N + 1;
        int outCount = N;
        int inCount = 1;
        string outDots = new string('.', outCount);
        string inDots = new string('.', inCount);

        Console.WriteLine("{0}*{0}", outDots);

        for (int i = 0; i < N / 2 - 1; i++)
        {
            outCount--;
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            inCount += 2;
        }

        int rayCount = N / 2 + 1;
        string ray = new string('*', rayCount);
        inDots = new string('.', inCount);
        Console.WriteLine("{0}{1}{0}", ray, inDots);

        outCount = 1;
        inCount = width - 4;
        for (int i = 0; i < N / 2 - 1; i++)
        {
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            outCount++;
            inCount -= 2;
        }

        int legCount = N / 2 - 1;
        string leg = new string('.', legCount);
        outDots = new string('.', outCount);
        Console.WriteLine("{0}*{1}*{1}*{0}", outDots, leg);

        inCount = 1;
        for (int i = 0; i < N / 2 - 1; i++)
        {
            outCount--;
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", outDots, leg, inDots);
            inCount += 2;
        }

        inDots = new string('.', inCount);
        Console.WriteLine("{0}{1}{0}", ray, inDots);
    }
}

