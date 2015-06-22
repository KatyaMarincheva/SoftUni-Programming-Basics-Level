/* Problem 1 – Tic-Tac-Toe Power   
You are given tic-tac-toe board (3 columns and 3 rows) like the one the right. As inputs you will be given 
 * the X and Y coordinates of one of the cells. Each of the cells in the field has an index and a value 
 * (look at the examples on the right). You will be given the value of the first cell V (index1). 
 * Each of the next cells will have value greater by 1 than the previous. 
 * Example: if value=80, then index1=80, index2=81, index3=82, ..., index9=89. 
 * Your task is to print on the console the value of the cell C raised to the power of its index: C index. 
 * Look at comments in the examples below to understand your task better.
Input
The input data should be read from the console.
•	At the first line you will be given the X coordinate.
•	At the second line you will be given the Y coordinate.
•	At the third line an integer number V will be given, specifying the value of the first cell.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of 1 line:
•	Print the value C of the cell at position {X, Y} raised to the power of its index.
Constraints
•	The X and Y inputs will be integers in the range [0…2].
•	The V input will be an integer in the range [0…100].
 */

using System;

class TicTacToePower
{
    static void Main()
    {
        // matrix of indexes
        int[,] indexes = new int[3, 3];
        int counter = 1;
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                indexes[row, col] = counter;
                counter++;
            }
        }

        //for (int row = 0; row < 3; row++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //        Console.Write("{0} ", indexes[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());

        counter = V;
        int[,] values = new int[3, 3];
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                values[row, col] = counter;
                counter++;
            }
        }

        
        //for (int row = 0; row < 3; row++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //        Console.Write("{0} ", values[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        long C = PowerOf(values[Y, X], indexes[Y, X]);
        Console.WriteLine(C);
    }

    private static long PowerOf(int number, int power)
    {
        long result = number;
        for (int i = 2; i <= power; i++)
        {
            result = result * number;
        }

        return result;
    }
}

