// Problem 19.** Spiral Matrix

/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix holding the numbers from 1 to n*n 
 * in the form of square spiral like in the examples below.

Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7
 */

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Please, enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        // as each cell of the square matrix will have (x, y) coordinates - 
        // we will need a two-dimentional array to store the values
        int[,] matrix = new int[n, n];

        // declarations
        int row = 0;
        int col = 0;

        // the most important part of this method is the change of the directions:
        // right -> down -> left -> up -> right etc.
        string direction = "right";
        int maxRotations = n * n;

        // this loop counts the number of numbers printed, and changes the direction
        // int two case: 
        // 1st if we have reached the end of the row;
        // 2nd, with further rotations, if a given position in the square spiral is already occupied by a number
        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                // with down direction it might seem that we can keep the value of the column constant,
                // this is not the case, as the Console.Write() method will try to do the next print on (column + 1)
                // that is why we need to constantly return it back with col--
                direction = "down"; 
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }
            // the above is how we move the cursor

            // the code below is allocation of i values into the square matrix
            matrix[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        Console.WriteLine();
        //printing the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

