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
        int n = int.Parse(Console.ReadLine());
        string keyword = Console.ReadLine();
        int L = keyword.Length;
        keyword = keyword.ToLower();
        char[,] spiralMatrix = new char[n, n];

        int leftColumn = 0; 
        int rightColumn = n - 1; 
        int upperRow = 0; 
        int bottomRow = n - 1; 
        int count = 1; // from 1 to N*N
        do
        {
            for (int i = leftColumn; i <= rightColumn; i++) // filling the upper row
            {
                spiralMatrix[upperRow, i] = keyword[(count -1) % L];
                count++;
            }
            upperRow++; // we go one row down

            for (int i = upperRow; i <= bottomRow; i++) // filling the right column
            {
                spiralMatrix[i, rightColumn] = keyword[(count - 1) % L];
                count++;
            }
            rightColumn--; // we go to the next column

            for (int i = rightColumn; i >= leftColumn; i--) // filling bottom row
            {
                spiralMatrix[bottomRow, i] = keyword[(count - 1) % L];
                count++;
            }
            bottomRow--; // one row up 

            for (int i = bottomRow; i >= upperRow; i--) // filling the leftmost column
            {
                spiralMatrix[i, leftColumn] = keyword[(count - 1) % L];
                count++;
            }
            leftColumn++; ; // we go one column to the right

        } while (count <= n * n); // and continuing the spiral until count = n*n

        // prints the spiral matrix
        int Bestrow = 0;
        int weight = 0;
        for (int row = 0; row < n; row++)
        {
            int localWeight = 0;
            for (int col = 0; col < n; col++)
            {
                
                localWeight += (spiralMatrix[row, col] - 'a' + 1) * 10;
            }
            if (localWeight > weight)
            {
                weight = localWeight;
                Bestrow = row;
            }
        }

        Console.WriteLine("{0} - {1}", Bestrow, weight);
    }
}

