/* Problem 5 – Knight Path
You are given a chess board of size 8 x 8, divided into 64 cells. Initially, the board is empty (all cells have a value of 0). 
 * You place a knight on the board which inverts the bits on all positions it lands on (0 -> 1; 1 -> 0). 
 * The initial position of the knight is [0, 0]. Each move will be defined by a combination of two directions, 
 * one vertical and one horizontal (example: "left up"). The knight moves according to the standard rules of chess – 
 * two positions in the first direction and then one position in the second direction (see the example below for reference). 
 * When the given command leads you out of the board don’t move the knight. The valid commands are: 
"left up", "left down", "right up", "right down", "up left", "up right", "down left", "down right".
When you receive the string "stop" from the console, you should stop moving the knight. There would be some 1s and 0s on the board. 
 * Each row of the board represents a binary integer number. Your task is to print all the rows, which are different from 0, to the console. 
 * To understand the task better check the example below.
Input
The input data is read from the console. 
•	It consists of a random number of lines. The input ends with the string "stop".
•	Each line will hold a string - representing the direction of the knight’s movement; the vertical and horizontal directions 
 * will be separated from each other by a single space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	On the only output line you must print the non-zero integers from the board.
•	Each row of the table represents an integer number in binary format.
•	If the whole board is with zeroes, you should print out "[Board is empty]".
Constraints
•	The number moves will be in the range [1…25].
•	The direction will consist of a combination of the following strings: "left", "right", "up", "down".
 */

using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

class NightPath
{

    static void Main()
    {
        int X = 7;
        int Y = 0;

        int[,] board = new int[8, 8]; // chess board
        board[Y, X] = 1; // initial position of the knight

        // the list will be storing all sets of incomming commands - in arrays
        List<string[]> directions = new List<string[]>();
        string[] commands = new string[2];
        string input = "";

        // read the input
        while (input != "stop")
        {
            input = Console.ReadLine();
            if (input != "stop")
            {
                commands = input.Split(' ').ToArray();
                directions.Add(commands);
            }
        }

        // apply all sets of commands
        foreach (string[] dir in directions)
        {
            Move(ref X, ref Y, board, dir);
        }

        // the chess field view is final
        // and we turn each row into a binary string
        List<string> results = new List<string>();
        List<int> numbers = new List<int>();
        StringBuilder tempStr = new StringBuilder();
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                tempStr.Append(board[row, col]);
            }
            results.Add(tempStr.ToString());
            tempStr.Clear();
        }

        // converting all binary rows into ints
        for (int i = 0; i < results.Count; i++)
        {
            int num = Convert.ToInt32(results[i], 2);
            numbers.Add(num);
        }
        // if the no int is > 0
        if (numbers.Max() == 0)
        {
            Console.WriteLine("[Board is empty]");
        }
        // else: printing all ints > 0
        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }

    // moving the knight
    private static void Move(ref int X, ref int Y, int[,] board, string[] commands)
    {
        int tempX = X;
        int tempY = Y;
        switch (commands[0])
        {
            case "left": tempX -= 2; break;
            case "right": tempX += 2; break;
            case "up": tempY -= 2; break;
            case "down": tempY += 2; break;
        }

        switch (commands[1])
        {
            case "left": tempX--; break;
            case "right": tempX++; break;
            case "up": tempY--; break;
            case "down": tempY++; break;
        }

        // applying the move only if it won't go out of the board
        if (tempX >= 0 && tempX <= 7 && tempY >= 0 && tempY <= 7)
        {
            X = tempX;
            Y = tempY;

            if (board[Y, X] == 1)
            {
                board[Y, X] = 0;
            }
            else
            {
                board[Y, X] = 1;
            }
        }
    }
}
