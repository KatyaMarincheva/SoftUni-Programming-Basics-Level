/* Problem 1 – Inside the Building
In Absurdistan the buildings look like the figure on the right. They consist of 6 blocks of size h * h. 
 * Their bottom-left corner is located at the coordinates (0, 0). See the figure (for h = 2) to get a better idea.
Write a program that enters a size h and 5 points {x1, y1}, {x2, y2}, {x3, y3}, {x4, y4}, and {x5, y5} 
 * and prints for each of the points whether it is inside or outside of the building. Points at the building's border, like {0, 0}, 
 * are considered inside.
Input
The input data should be read from the console.
•	At the first line an integer number h specifying the size of the building will be given.
•	At the next 10 lines the numbers x1, y1, x2, y2, x3, y3, x4, y4, x5, y5 are given.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 5 lines. 
 * At each line print either "inside" or "outside" depending of where each of the 5 input points are located.
Constraints
•	All numbers in the input will be integers in the range [-1000 … 1000].
 */

using System;

class InsideTheBuilding14Apr2014
{
    static void Main()
    {
        // input
        int h = int.Parse(Console.ReadLine());

        int[,] matrix = new int[5, 2];

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        // printing the x, y values of the matrix
        //for (int row = 0; row < 5; row++)
        //{
        //    for (int col = 0; col < 2; col++)
        //    {
        //        Console.Write("{0,4} ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        for (int row = 0; row < 5; row++)
        {
            bool inside = IsInsideRectangle(h, matrix[row, 0], matrix[row, 1]);

            if (!inside)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }

    private static bool IsInsideRectangle(int h, int x, int y)
    {
        int r1Left = 0;
        int r1Bottom = 0;
        int r1Width = 3 * h;
        int r1Height = h;

        int r2Left = h;
        int r2Bottom = h;
        int r2Width = h;
        int r2Height = 3 * h;
        bool insideRectangle1 = (x >= r1Left) && (x <= (r1Left + r1Width)) && (y >= r1Bottom) && (y <= (r1Bottom + r1Height));
        bool insideRectangle2 = (x >= r2Left) && (x <= (r2Left + r2Width)) && (y >= r2Bottom) && (y <= (r2Bottom + r2Height));
        bool inside = insideRectangle1 | insideRectangle2;
        return inside;
    }
}


