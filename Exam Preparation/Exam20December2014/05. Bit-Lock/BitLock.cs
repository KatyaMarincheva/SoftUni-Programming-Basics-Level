/* Problem 5 – Bit Lock
Your task is to write a program that tests a new kind of security lock which uses bitwise operations. 
 * The lock itself can be represented as a table with 8 rows and 12 columns (see example below), where each cell contains a single bit (0 or 1). 
You will be given 8 integers (representing the rows of the table) on a single line, separated by a single space.
Afterwards, you will be given a series of commands, between 1 and 30, which will be in one of the following three formats: 
•	"check [col]", where [col] is a number. Upon receiving this command you'll need to check how many 1 bits there are in column [col] 
 * and print their amount on the console.
•	"end" denotes the end of input. Upon receiving this command you need to print all rows of the table (as numbers) on a single line, 
 * separated by a single space; print a space after the last number as well.
•	"[row] [direction] [rotations]", where [row] is a number; [direction] is a string, either "left" or "right"; and [rotations] is also a number. 
 * Upon receiving this command, you need to roll the bits at the specified row. Rolling once to the left means that all bits are moved once to the left, 
 * the bit at column 11 goes to column 0. Rolling once to the right means all bits are moved once to the right, the bit at column 0 goes to column 11. 
 * The number of rotations shows how many times you have to roll the bits on the specified row; it will be between 0 and 360 inclusive.
Input
The input data is read from the console. 
•	On the first line you will be given 8 integers, separated by a single space.
•	On the next lines you will be given commands in the described formats; the input ends when you receive the command "end".
Output
The output data must be printed on the console.
•	Upon receiving the command "check [col]" you need to print a single line containing a number.
•	Upon receiving "end" print the rows of the table as integers - on a single line, separated by a single space.
Constraints
•	The numbers representing the rows of the table will be integers in the range [0…4095].
•	[row] will be between [0…7] and [col] will be between [0…11], i.e. valid coordinates of the table.
 */

using System;
using System.Linq;


class BitLock
{
    static void Main()
    {
        // numbers input
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // numbers to binary strings
        // reversing the strings as strings are indexed from left to right
        // and binary numbers from right to left
        // and in a string we need to have the 0-postion bit right-most
        string[] binaries = new string[numbers.Length];
        for (int i = 0; i < binaries.Length; i++)
        {
            string temp = Convert.ToString(numbers[i], 2).PadLeft(12, '0');
            temp = ReverseString(temp);
            binaries[i] = temp;
        }

        // reading first command
        string input = Console.ReadLine();
        // implementing the commands
        // and reading the next commands if any
        while (input != "end")
        {
            string[] commands = input.Split(' ').ToArray();

            // if check command
            if (commands.Length == 2)
            {
                int X = int.Parse(commands[1]);
                int count = 0;
                foreach (string num in binaries)
                {
                    if (num[X] == '1')
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }

            // if rotation command
            else if (commands.Length == 3)
            {
                int X = int.Parse(commands[0]);
                int N = int.Parse(commands[2]);
                N = N % 12;
                if (commands[1] == "right")
                {
                    string substr = binaries[X].Substring(0, N);
                    binaries[X] = binaries[X].Remove(0, N);
                    binaries[X] = binaries[X] + substr;
                }
                else if (commands[1] == "left")
                {
                    string substr = binaries[X].Substring(binaries[X].Length - N, N);
                    binaries[X] = binaries[X].Remove(binaries[X].Length - N, N);
                    binaries[X] = substr + binaries[X];
                }
            }

            input = Console.ReadLine();
        }

        // printing
        for (int i = 0; i < binaries.Length; i++)
        {
            binaries[i] = ReverseString(binaries[i]);
            numbers[i] = Convert.ToInt32(binaries[i], 2);
            Console.Write("{0} ", numbers[i]);
        }
    }

    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    private static int BinaryToDecimal(string number)
    {
        int decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (int)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }
}

