/* Problem 4 – Spiral Matrix
We have to make a spiral matrix (n x n) defined by walking over a grid of letters as a spiral 
 * (right, down, left, up, and again - right, down, left, etc.). 
 * We start from the upper left corner of the matrix and fill each cell with a letter from a given keyword. 
 * We fill the cells starting with the first letter of the keyword; when we get to the last letter we return to the first letter again. 
 * The process is repeated until the matrix is fully filled. See the example below to better understand your task.
The weight of each letter is the product of its position in the English alphabet and the number 10 
 * (weight 'a' = 1*10 = 10, weight 'b' = 2*10 =20 … weight 'z' = 26*10 = 260). 
 * Find the index and the weight of the row with the biggest weight. If several rows have an equal weight, print the upper-most row.

Example
The matrix is 4x4 and the keyword is "SoftUni". The weight of every row is:
•	Row 0 = weight ('S') + weight ('o') + weight ('f') + weight ('t') = 600
•	Row 1 = weight ('U') + weight ('n') + weight ('I') + weight ('U') = 650
•	Row 2 = weight ('t') + weight ('o') + weight ('S') + weight ('n') = 680
•	Row 3 = weight ('f') + weight ('I') + weight ('S') + weight ('I') = 490
Therefore, the row with biggest weight is row 2 with a weight of 680.
Input
The input data should be read from the console.
•	On the first line of input, you will read a number n, representing the size of the matrix.
•	On the second line of input, you will read a string – the keyword.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output must be printed on the console.
On the only output line you must print the index and weight of the row with biggest weight in the format: "{row} - {weight}".
Constraints
•	The size of the matrix will be in the range [1…1000].
•	The keyword will contain only Latin upper- and lower-case letters: [a-z] [A-Z].
*/

using System;
using System.Linq;

class SpiralMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToLower();

        int[][] matrix = new int[size][];

        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
        }

        int row = 0;
        int col = 0;
        int letterIndex = 0;

        while (letterIndex < size * size)
        {
            while (col < size && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                col++;
                letterIndex++;
            }

            col--;
            row++;

            while (row < size && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                row++;
                letterIndex++;
            }

            row--;
            col--;

            while (col >= 0 && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                col--;
                letterIndex++;
            }

            col++;
            row--;

            while (row >= 0 && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                row--;
                letterIndex++;
            }

            row++;
            col++;
        }

        int maxSum = 0;
        int maxIndex = 0;

        for (int i = 0; i < size; i++)
        {
            int currentSum = matrix[i].Sum();
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxIndex = i;
            }
        }

        maxSum -= ('a' - 1) * size;
        maxSum *= 10;

        Console.WriteLine("{0} - {1}", maxIndex, maxSum);
    }
}

