/* Problem 5 – Half Byte Swapper
You are given four 32 bit integer numbers. Your task is to swap groups of 4 bits between the 4 numbers. 
 * You will be given series of commands. Commands end when the last command given is "End". 
 * Each command consists of 2 lines each holding 2 numbers separated by space. 
 * The first number in the command shows which number (0 -3) will be manipulated and the second number which group (0-7) of 4 bits will be swapped. The 2 lines in each command show the 2 numbers that will swap groups of 4 bits. Print the four numbers after all commands have been executed. 
See the examples on the right to understand you task better. 
Input
Input data is read from the console.
•	On the first 4 lines you will be given 4 32 bit integer numbers
•	On each of the next 2 lines will be a single command showing the 2 numbers and groups that will swap bits.
•	On the last line on the input will be given the command "End" indicting no more commands will be given
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	Print the 4 input numbers on separate line after all commands are executed
Constraints
•	The 4 input numbers will be in the range [0... 4, 294,967,295].
•	The first number in the command will be between [0-3] and the second between [0-7] 
 */

using System;
using System.Linq;

class BitSwapper
{
    static void Main()
    {
        // numbers input
        uint[] numbers = new uint[4];
        for (int i = 0; i < 4; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }

        // numbers to binary strings
        string[] binaries = new string[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            string temp = Convert.ToString(numbers[i], 2).PadLeft(32, '0');
            temp = ReverseString(temp);
            binaries[i] = temp;
        }

        // commands input and extracting the commands
        int[][] commands = new int[2][];
        while (true)
        {
            string input = Console.ReadLine();

            if (input != "End")
            {
                commands[0] = input.Split(' ').Select(int.Parse).ToArray();
                commands[1] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            else
            {
                break;
            }

            // concerned numbers, positions and half-bytes
            string num1 = binaries[commands[0][0]];
            string num2 = binaries[commands[1][0]];

            int hbn1 = commands[0][1];
            int hbn2 = commands[1][1];

            string piece1 = num1.Substring(hbn1 * 4, 4);
            string piece2 = num2.Substring(hbn2 * 4, 4);

            // swapping half-bytes between 2 numbers
            if (num1 != num2)
            {
                num1 = num1.Insert(hbn1 * 4, piece2);
                num1 = num1.Remove((hbn1 + 1) * 4, 4);

                num2 = num2.Insert(hbn2 * 4, piece1);
                num2 = num2.Remove((hbn2 + 1) * 4, 4);
                binaries[commands[0][0]] = num1;
                binaries[commands[1][0]] = num2;
            }
            else // between 2 positions in one number
            {
                num1 = num1.Insert(hbn1 * 4, piece2);
                num1 = num1.Remove((hbn1 + 1) * 4, 4);
                num1 = num1.Insert(hbn2 * 4, piece1);
                num1 = num1.Remove((hbn2 + 1) * 4, 4);
                binaries[commands[1][0]] = num1;
            }
        }

        // converting binary strings back to numbers and printing
        for (int i = 0; i < 4; i++)
        {
            string temp = binaries[i];
            temp = ReverseString(temp);
            uint number = BinaryToDecimal(temp);
            Console.WriteLine(number);
        }
    }


    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    private static uint BinaryToDecimal(string number)
    {
        uint decNumber = 0;
        uint index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (uint)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }
}

