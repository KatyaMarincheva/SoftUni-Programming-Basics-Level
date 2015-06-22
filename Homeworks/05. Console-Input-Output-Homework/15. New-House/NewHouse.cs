/* Problem 15.	* – New House
This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.  You can test your solution here .
Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to 
 * the big city and start building houses. But his knowledge of how to do this is limited. Help Joro to design 
 * the façade of a beautiful house by printing it to the console. The house must have a roof and one floor. 
 * The roof must contains only the symbols ‘*’ and ‘-’ and the floor must contains the symbols ‘*’ and ‘|’ (see the examples below).
Input
•	The input data should be read from the console.
•	At the only input line you are given an integer number N (always an odd number) showing the height of the house (without the roof).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output should be printed on the console.
•	You should print the house on the console, just like in the examples below. 
 * Each row can contain only the following characters: “-” (dash), “*” (asterisk) and “|” (pipe). 
  */

using System;

class NewHouse
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // calculating the roof
        int roofSpaceCount = N / 2;
        // printing the roof
        for (int i = 0; i < N/2 + 1; i++)
        {
            string roofSpace = new string('-', roofSpaceCount);
            string roofTiles = new string('*', 1 + 2 * i );
            Console.WriteLine("{0}{1}{0}", roofSpace, roofTiles);
            roofSpaceCount--;
        }

        // calculating the floor
        string bricks = new string('*', N - 2);

        // printing the floor
        for (int j = 0; j < N; j++)
        {
            Console.WriteLine("|{0}|", bricks);
        }
    }
}

