/* Problem 5 – Game of Bits

Vasko likes to play with odd and even numbers as well as bits. He has to make a game using bits 
 * but he really enjoys the course of Web Fundamentals so he doesn't have time to make the game. Please help him!
You have a 32-bit integer and commands: "Odd", "Even" or "Game Over!" When you read the "Odd" command 
 * you have to obtain a new number by extracting the values of all odd bit positions in the current number 
 * (positions are counted from right to left and the first bit has a position of 1).  When you read the "Even" command 
 * you have to extract the bits at even positions. When you read the command "Game Over!" 
 * you must print on the console the count of bits with value '1' in the final number.
Input
The input data should be read from the console. On the first line, you are given an integer number and on each of the next lines, 
 * you have an issued command.
The possible commands are as follows: "Odd" and "Even". On the last input line, 
 * you are given the order "Game Over!" which means that the game has ended.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
On the only output line you should print the final number before the “Game over” command and the count of bits with value 1. 
 * The output format is as follows: 
"<final number after bit’s extraction> -> <number of bits with value 1>"
Constraints
•	The input number will be a 32-bit integer in the range [0 … 4 294 967 295].
•	The minimum number of commands is 1.
•	The maximum number of commands will be 30.
 */

using System;
using System.Text;
using System.Linq;

class GameOfBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        //Console.WriteLine(binary);
        binary = ReverseString(binary);

        StringBuilder temp = new StringBuilder();
        string command = "";
        while (command != "Game Over!")
        {
            command = Console.ReadLine();

            if (command == "Game Over!")
            {
                //Console.WriteLine(binary);
                binary = ReverseString(binary);
                int count = binary.Count(c => c == '1');
                ulong final = BinaryToDecimal(binary);

                Console.WriteLine("{0} -> {1}", final, count);
            }

            if (command == "Odd")
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp.Append(binary[i]);
                    }
                }
            }
            else if (command == "Even")
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        temp.Append(binary[i]);
                    }
                }
            }

            binary = temp.ToString();
            temp.Clear();
            //Console.WriteLine(binary);

        }

    }

    private static ulong BinaryToDecimal(string number)
    {
        ulong decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (ulong)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }

    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

