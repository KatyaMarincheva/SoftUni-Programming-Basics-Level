/* Problem 4 – Chess Queens
We are given a chess board of size N * N. The only figures we have on the    
chess board are two queens. The queen in chess can move in horizontal, vertical and diagonal directions.
 * We are also given a number D which represents the distance between the two queens. 
 * The distance is measured by D squares away. All positions on the chessboard are represented with numbers and letters 
 * (a1, a2… a8, b1-b8, c1-c8, …, h1-h8). Example: if N=16, the numbers on the board will be represented with integers (1-16) and letters (a-o). 
 * Your task is to find all couples of queens where the queens stay either on the same vertical, horizontal or diagonal, at distance D. 
 * See the diagram aside to understand your task better. The green queens meet the condition of 2 blocks away but the red queens aren’t.
Input
The input data should be read from the console. It consists of 2 lines:
•	The first line holds an integer number N representing the width and height of the chess board.
•	The second line holds an integer number D representing the distance that we should be looking for.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of chess position in the format 
 * [quеen1X, quеen1Y  - quеen2X, quеen2Y]. The order of the output is not important. 
 * Each string should stay on a separate line. In case they are no valid positions print “No valid position”.
Constraints
•	The numbers N and D will be integers in the range [0…20].
 */

using System;
using System.Collections.Generic;

class ChessQueens
{
    private static List<string> results = new List<string>();
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        if (N - D < 2)
        {
            Console.WriteLine("No valid positions");
            return;
        }
        char start = 'a';
        // creating vertical list
        char[] letters = new char[N];
        for (int i = 0; i < N; i++)
        {
            letters[i] = start;
            start++;
        }

        // creating horizontal list
        string[] numbers = new string[N];
        for (int i = 0; i < N; i++)
        {
            numbers[i] = (i + 1).ToString();
        }
        //Console.WriteLine(string.Join(" ", numbers));

         //filling the matrix with values
        string[,] chessField = new string[N, N];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                chessField[row, col] = letters[row] +  numbers[col];
            }
        }


        for (int col = 0; col < N; col++)
        {
            CheckRow(N, D, col, chessField, results);
        }

        for (int row = 0; row < N; row++)
        {
            CheckCol(N, D, row, chessField);
        }

        for (int row = 0; row < N - D - 1; row++)
        {
            for (int col = 0; col < N - D - 1; col++)
            {
                string temp = chessField[row, col] + " - " + chessField[row + D + 1, col + D + 1];
                string reverse = chessField[row + D + 1, col + D + 1] + " - " + chessField[row, col];
                results.Add(temp);
                results.Add(reverse);
            }
        }

        for (int row = N - 1; row >= D + 1; row--)
        {
            for (int col = 0; col < N - D - 1; col++)
            {
                string temp = chessField[row, col] + " - " + chessField[row - D - 1, col + D + 1];
                string reverse = chessField[row - D - 1, col + D + 1] + " - " + chessField[row, col];
                results.Add(temp);
                results.Add(reverse);
            }
        }

        results.Sort();
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }

    }

    private static void CheckRow(int n, int D, int colIndex, string[,] matrix, List<string> results)
    {
        for (int row = 0; row < n - D - 1; row++)
        {
            string temp = matrix[row, colIndex] + " - " + matrix[row + D + 1, colIndex];
            string reverse = matrix[row + D + 1, colIndex] + " - " + matrix[row, colIndex];
            results.Add(temp);
            results.Add(reverse);
        }
    }

    private static void CheckCol(int n, int D, int rowIndex, string[,] matrix)
    {
        for (int col = 0; col < n - D - 1; col++)
        {
            string temp = matrix[rowIndex, col] + " - " + matrix[rowIndex, col + D + 1];
            string reverse = matrix[rowIndex, col + D + 1] + " - " + matrix[rowIndex, col];
            results.Add(temp);
            results.Add(reverse);
        }
    }
}

