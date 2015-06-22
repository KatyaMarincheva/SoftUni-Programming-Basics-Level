/* Problem 22.	** – Arrow
SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it. 
 * Your task is to print a vertical arrow, which will be used to indicate the path to the new building in the city. 
 * This will help thousands of people to become software engineers. Please help them!
Input
The input data should be read from the console.
•	On the only line will hold and integer number N (always odd number), indicating the width of the arrow. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. Use the “#” (number sign) to mark the arrow and “.” (dot) for the rest. Follow the examples below.
Constraints
•	N will always be a positive odd number between 3 and 79 inclusive.
 */

using System;

class Arrow
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // counts
        int dotsOutCount = N/2;
        int dotsInCount = N - 2;
        string dotsOut = "";
        string dotsIn = "";

        int counter = 0;
        do
        {
            if (counter == 0)
            {
                dotsOut = new string('.', dotsOutCount);
                string arrowBase = new string('#', N);
                Console.WriteLine("{0}{1}{0}", dotsOut, arrowBase);
                counter++;
            }
            if (counter <= N - 2)
            {
                dotsIn = new string('.', dotsInCount);
                Console.WriteLine("{0}#{1}#{0}", dotsOut, dotsIn);
                counter++;
            }
            if (counter == N - 1)
            {
                string sides = new string('#', N / 2 + 1);
                Console.WriteLine("{0}{1}{0}", sides, dotsIn);
                counter++;
                dotsOutCount = 1;
                dotsInCount = (2 * N - 1) - 4;
            }
            if (counter > N - 1 && counter < 2 * N - 2)
            {
                dotsIn = new string('.', dotsInCount);
                dotsOut = new string('.', dotsOutCount);
                Console.WriteLine("{0}#{1}#{0}", dotsOut, dotsIn);
                dotsOutCount++;
                dotsInCount -= 2;
                counter++;
            }
            if (counter == 2 * N - 2)
            {
                dotsOut = new string('.', dotsOutCount);
                Console.WriteLine("{0}#{0}", dotsOut);
                counter++;
            }
        } while (counter < 2 * N - 1);
    }
}

