/* Problem 3 – Car
You will be given an integer N. The width of the car is (3*N). The height of the car is (3*N/2-1).  
 * The roof height and the body height is exactly (N/2).  The car’s wheels height are (N/2-1). 
 * Check the examples below to understand your task better.
Input
•	Input data is read from the console.
•	The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a car of size N following the formulas above and the examples below.
Constraints
•	N will be a number between 6 and 36 and will be an even number.
 */

using System;

class Car
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int outCount = N;
        int roofCount = N;
        string outDots = new string('.', outCount);
        string roof = new string('*', roofCount);
        Console.WriteLine("{0}{1}{0}", outDots, roof);

        int inCount = N;
        string inDots = new string('.', inCount);
        for (int i = 0; i < N/2 -1; i++)
        {
            outCount--;
            outDots = new string('.', outCount);
            inDots = new string('.', inCount);
            Console.WriteLine("{0}*{1}*{0}", outDots, inDots);
            inCount += 2;
        }

        int partCount = N / 2 + 1;
        string part = new string('*', partCount);
        inDots = new string('.', inCount);
        Console.WriteLine("{0}{1}{0}", part, inDots);

        inCount = 3 * N - 2;
        inDots = new string('.', inCount);
        for (int i = 0; i < N/2 -2; i++)
        {
            Console.WriteLine("*{0}*", inDots);
        }

        Console.WriteLine(new string('*', 3 * N));

        int tyreCount = N / 2 - 1;
        outCount = N / 2;
        inCount = N - 2;
        outDots = new string('.', outCount);
        inDots = new string('.', inCount);
        string tyre = new string('.', tyreCount);

        for (int i = 0; i < N/2 -2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", outDots, tyre, inDots);
        }

        Console.WriteLine("{0}{1}{2}{1}{0}", outDots, part, inDots);

    }
}

