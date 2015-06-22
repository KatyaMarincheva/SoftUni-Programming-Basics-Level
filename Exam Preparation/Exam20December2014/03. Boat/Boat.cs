/* Problem 3 – Boat
We all know Popeye the Sailor Man. In this episode he was captured and thrown in a prison by Bluto on a lonely island 
 * in the middle of the Atlantic Ocean. He used his last spinach can to break out of the prison, but he still had to escape from the island. 
 * His only chance to survive and rescue his beloved Olive Oil is to somehow find a boat, but sadly the Animator doesn't know how to draw boats. 
 * Your task is to draw a boat by given N (the height and width of the sail) and bring this story to a happy ending.
Input
The input data should be read from the console.
On the only input line you have an integer number N, showing the height and width of the sail.
The body of the boat should be exactly (N – 1) / 2 lines high.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
You must print the boat on the console. Each row contains only characters "." (dot)  or "*" (asterisk).
The first row should have exactly one "*" in the middle (that is the top of the sail) and every next line should have two more.
The first row of the body should have exactly N * 2 "*" and every next line, two asterisk less. (see the example below)
Constraints
•	The number N will always be an odd integer number in the range [3…39].
 */

using System;

class Boat
{
    static void Main(string[] args)
    {
        // input
        int N = int.Parse(Console.ReadLine());

        // counts
        int sailHeight = N;
        int sailWidth = N;
        int bodyHeight = (N - 1) / 2;
        int bodyLengthCount = 2 * N;
        int frontdotsCount = N - 1;
        int backdotsCount = N;
        int sailCount = 1;

        // strings
        string frontdots = new string('.', frontdotsCount);
        string backdots = new string('.', backdotsCount);
        string sail = new string('*', sailCount);
        string body = new string('*', bodyLengthCount);

        // printing
        // upsail
        for (int i = 0; i < (sailHeight + 1)/2; i++)
        {
            frontdots = new string('.', frontdotsCount);
            sail = new string('*', sailCount);
            Console.WriteLine("{0}{1}{2}", frontdots, sail, backdots);
            frontdotsCount -= 2;
            sailCount += 2;
        }
        //downsail
        frontdotsCount += 4;
        sailCount -= 4;
        for (int j = 0; j < sailHeight/2; j++)
        {
            frontdots = new string('.', frontdotsCount);
            sail = new string('*', sailCount);
            Console.WriteLine("{0}{1}{2}", frontdots, sail, backdots);
            frontdotsCount += 2;
            sailCount -= 2;
        }

        // body
        frontdotsCount = 0;
        for (int k = 0; k < bodyHeight; k++)
        {
            frontdots = new string('.', frontdotsCount);
            body = new string('*', bodyLengthCount);
            Console.WriteLine("{0}{1}{0}", frontdots, body);
            bodyLengthCount -= 2;
            frontdotsCount++;
        }
    }
}

