/* Problem 17.	** – Bit Killer
You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.  You are given also a number step. 
 * Write a program to remove (kill) all the bits at positions: 1, 1 + step, 1 + 2*step, ... 
 * Print the output as a sequence of bytes. In case the last byte have less than 8 bits, add trailing zeroes at its right end. 
 * Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
Input
•	The input data should be read from the console.
•	The number n stays at the first line.
•	The number step stays at the second line.
•	At each of the next n lines n bytes are given, each at a separate line. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. Print the output bytes, each at a separate line.
Constraints
•	The number n will be an integer number in the range [1…100].
•	The number step will be an integer number in the range [1…20].
•	The n numbers will be integers in the range [0…255].
 */

using System;
using System.Text;

class BitKiller2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        StringBuilder allBits = new StringBuilder();
        StringBuilder resultBits = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            string eightBits = Convert.ToString(temp, 2).PadLeft(8, '0');

            allBits.Append(eightBits);
        }

        for (int j = 0; j < allBits.Length; j++)
        {
            if (j % step == 1 || step == 1 && j > 0)
            {
                continue;
            }
            else
            {
                resultBits.Append(allBits[j]);
            }
        }

        if (resultBits.Length % 8 != 0)
        {
            string padding = new string('0', 8 - resultBits.Length % 8);

            resultBits.Append(padding);
        }

        string outputBits = resultBits.ToString();
        for (int i = 0; i < resultBits.Length / 8; i++)
        {
            string x = outputBits.Substring(i * 8, 8);
            int number = Convert.ToInt32(x, 2);
            Console.WriteLine(number);
        }
    }
}

