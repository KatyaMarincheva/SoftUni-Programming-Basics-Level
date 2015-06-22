/* Problem 15.	* – House
Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.
The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and 
 * the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from the center (N+1)/2 
 * and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between the roofs’ end point 
 * and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.
Input
•	Input data is read from the console.
•	The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a house of size N following the formulas above and the examples below.
Constraints
•	N will be an odd number between 5 and 49.
 */

using System;

class House
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        // calculating the roof
        int roofSpaceOutCount = N / 2;
        int roofSpaceInCount = 1;

        for (int i = 0; i < N; i++)
        {
            // preparing the roof strings
            string roofSpaceOut = new string('.', roofSpaceOutCount);
            string roofSpaceIn = new string('.', roofSpaceInCount);

            // if first or last roof row: we won't need inner space symbols
            // only tiles +/- outer space 
            if (i + 1 == 1 || i == N / 2)
            {
                string roofTiles = new string('*', 1 + 2 * i);
                Console.WriteLine("{0}{1}{0}", roofSpaceOut, roofTiles);
            }

            // for any other roof row: we need outer space, tiles and inner space
            else if (i > 0 && i < N / 2)
            {
                Console.WriteLine("{0}*{1}*{0}", roofSpaceOut, roofSpaceIn);
            }

            // we need to keep increasing the inner space and decreasing the outer space
            // but only while we are still printing the roof
            if (i < N / 2)
            {
                roofSpaceOutCount--;
                roofSpaceInCount = 1 + 2 * i;
            }

            // we have passed the middle of the house
            // and we start printing the walls
            else if (i > N / 2 - 1 && i < N - 2)
            {
                // recalculating inner and outer space
                roofSpaceOutCount = N / 4;
                roofSpaceInCount = N - (2 * (N / 4) + 2);
                roofSpaceOut = new string('.', roofSpaceOutCount);
                roofSpaceIn = new string('.', roofSpaceInCount);
                Console.WriteLine("{0}*{1}*{0}", roofSpaceOut, roofSpaceIn);
            }
            // we have reached the house floor
            else if (i == N - 1)
            {
                Console.WriteLine("{0}{1}{0}", roofSpaceOut, new string('*', N - (2 * (N / 4))));
            }
        }
    }
}
