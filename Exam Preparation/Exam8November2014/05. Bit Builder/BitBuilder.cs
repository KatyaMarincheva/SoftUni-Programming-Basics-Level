/* Problem 5 – Bit Builder
Pesho is a nasty little brat who likes to do mischiefs all the time. 
 * You are given the task to keep him busy and thus have come up with a game you named Bit Builder. The rules of the game are as follows:
You are given a sequence of bits (an integer number) and Pesho chooses a position and issues an order in order to manipulate the given bit. 
 * If he says flip, you have to reverse the value of the bit. For example if the bit’s value is 1, it has to become 0. 
 * If Pesho’s order is remove, you have to remove the bit from the bit sequence (1 1100 1101  0 1110 0101). 
 * However, if he issues the order insert the bit 1 has to be inserted in the wanted position (0 1110 0101  1 1100 1101). 
 * If he issues the order skip, you don’t have to do anything with the given bit. Whenever Pesho says quit, the game ends.
Input
The input data should be read from the console. On the first line, you are given an integer number and on each of the next two lines, 
 * you have a bit position and an issued order.
The possible orders are as follows: “flip”, “remove”, “insert”, “skip”. On the last input line, you are given the order “quit”, 
 * which means that the game has ended.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
On the only output line print the bits of the number after the end of the game 
Constraints
•	The input number will be a 32-bit integer in the range [0 … 2 147 483 647].
•	The position will be in the range [0 … 31].
•	The maximum number of commands will be 30.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2).PadLeft(32, '0');
        binary = ReverseString(binary);
        //Console.WriteLine(binary);
        List<char> workCopy = binary.ToList();


        while (true)
        {
            string input = Console.ReadLine();
            int p;

            if (input != "quit")
            {
                p = int.Parse(input);
            }
            else
            {
                break;
            }        

            string command = Console.ReadLine();

            if (command == "flip")
            {
                if (workCopy[p] == '0')
                {
                    workCopy[p] = '1';
                }
                else
                {
                    workCopy[p] = '0';
                }
            }

            else if (command == "remove")
            {
                workCopy.RemoveAt(p);
            }
            else if (command == "insert")
            {
                workCopy.Insert(p, '1');
            }
        }

        workCopy.Reverse();
        binary = string.Join("", workCopy);
        number = BinaryToDecimal(binary);
        //Console.WriteLine(binary);
        Console.WriteLine(number);
    }

    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

        private static long BinaryToDecimal(string number)
    {
        long decNumber = 0;
        long index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (long)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }
}

