/* Problem 3 – Plane
You will be given an integer N. The width of the rocklq is (3*N). The height of the plane is ((N * 3) – (N / 2)) and the width is (N * 3). 
 * Check the examples below to understand your task better.
Input
Input data is read from the console.
•	The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a picture of size N following the formulas above and the examples below.
Constraints
•	N will be a number between 5 and 31 and will be an odd number.
 */

using System;

class Plane
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int width = 3 * N;
        int height = (N * 3) - (N / 2);
        int outCount = N + N / 2;
        string outDots = new string('.', outCount);
        Console.WriteLine("{0}*{0}", outDots);

        int inCount = 1;
        string inDots = new string('.', inCount);

        for (int i = 0; i < height - 2 * N + 1; i++)
        {
            outCount--;
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            inCount += 2;
        }

        inCount += 2;
        for (int i = 0; i < height - 2 * N - 2; i++)
        {
            outCount -= 2;
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            inCount += 4;
        }

        int wingCount = N - 2;
        string wing = new string('.', wingCount);
        string corpus = new string('.', N);
        Console.WriteLine("*{0}*{1}*{0}*", wing, corpus);

        int underWingCount = 1;
        string underWing = new string('.', underWingCount);
        for (int i = 0; i < height - 2 * N - 2; i++)
        {
            wingCount -= 2;
            wing = new string('.', wingCount);
            underWing = new string('.', underWingCount);
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", wing, underWing, corpus);
            underWingCount += 2;
        }

        outCount = N - 1;
        inCount = N;
        for (int i = 0; i < N - 1; i++)
        {
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            outCount--;
            inCount += 2;
        }

        Console.WriteLine(new string('*', width));
    }
}

