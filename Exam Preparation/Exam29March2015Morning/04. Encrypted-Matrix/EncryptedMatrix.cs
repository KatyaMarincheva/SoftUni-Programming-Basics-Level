/* Problem 4 – Encrypted matrix

Bogi and Acho love to play with numbers, so they invented a game to encrypt a message and create a diagonal matrix with it. 
 * Your task is to write a program, which helps Acho and Bogi convert a message into a number, encrypt it and fill a matrix with it. 
First you should convert the message into a number. This is done when you take the last digit of the ASCII code of each character 
 * in the message and add those digits next to each other. 
For example the string "Soft Uni" is converted to 31262505:
('S' => ASCII(83), 'o' => ASCII(111), 'f' => ASCII(102), 't' => ASCII(116), ' ' => ASCII(32),
'U' => ASCII(85), 'n' => ASCII(110), 'i' => ASCII(105)).
Then you should encrypt the converted number digit by digit. The formula is the following: If the digit is even or '0' - 
 * you should multiply it by itself. If the digit is odd – you should add to its value the neighboring digits. 
 * If there is a missing neighboring digit, you should add 0 instead of it.
If the result after the encrypting of a digit is a number with two digits, you should concatenate the result to the new number.
For example 31262505 is encrypted to 464364705:
3 => 3+0+1=4, 1 => 1+3+2=6, 2 => 2*2=4, 6 => 6*6=36, 2 => 2*2=4, 5 => 5+2+0=7, 0 => 0*0=0, 5 => 5+0+0=5.
Finally you should fill a square diagonal matrix with the encrypted number. The size of the matrix should be the same as the number of digits
 * in the encrypted number. The diagonal to be filled comes from the console as a character: '\' (backslash) represents the main diagonal; 
 * '/' (slash) means the anti-diagonal.
For example 464364705 is filled in the following two matrices:
\ (main diagonal)
/ (anti-diagonal)
4 0 0 0 0 0 0 0 0
0 6 0 0 0 0 0 0 0
0 0 4 0 0 0 0 0 0
0 0 0 3 0 0 0 0 0
0 0 0 0 6 0 0 0 0
0 0 0 0 0 4 0 0 0
0 0 0 0 0 0 7 0 0
0 0 0 0 0 0 0 0 0
0 0 0 0 0 0 0 0 5
 * 
0 0 0 0 0 0 0 0 5
0 0 0 0 0 0 0 0 0
0 0 0 0 0 0 7 0 0
0 0 0 0 0 4 0 0 0
0 0 0 0 6 0 0 0 0
0 0 0 3 0 0 0 0 0
0 0 4 0 0 0 0 0 0
0 6 0 0 0 0 0 0 0
4 0 0 0 0 0 0 0 0
Take note of the direction of the number in the anti-diagonal matrix.
Input
The input data should be read from the console.
On the first input line you have a string, containing the message.
On the second input line you have the direction as character: either '\' or '/'.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
You must print the matrix with a single space between the elements.
Constraints
•	The string length will be in the range [1-500].
 */

using System;
using System.Collections.Generic;
using System.Text;

class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        string diagonal = Console.ReadLine();

        // letters to digits (end of ASCII codes)
        StringBuilder inCode = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            int temp = (int)message[i];
            int digit = temp % 10;
            inCode.Append(digit);
        }

        // digits to string
        string num1 = inCode.ToString();
        //Console.WriteLine(num1);
        
        // if string is 1 char long: print
        if (num1.Length == 1)
        {
            Console.WriteLine(num1);
            return;
        }

        // string to int list 
        List<int> digits = new List<int>();
        for (int j = 0; j < num1.Length; j++)
        {
            digits.Add(num1[j] - '0');
        }

        //Console.WriteLine(string.Join("", digits));

        // encrypting digits
        List<int> encryptedDigits = new List<int>();
        for (int j = 0; j < digits.Count; j++)
        {
            if (digits[j] % 2 == 0)
            {
                encryptedDigits.Add(digits[j] * digits[j]);
            }
            else
            {
                if (j == 0)
                {
                    encryptedDigits.Add(digits[j] + digits[j + 1]);
                }
                else if (j == digits.Count - 1)
                {
                    encryptedDigits.Add(digits[j] + digits[j - 1]);
                }
                else if (j > 0 && j < digits.Count -1)
                {
                    encryptedDigits.Add(digits[j - 1] + digits[j] + digits[j + 1]);
                }
            }
        }

        // if some encrypted digits are no longer digits, consist of two digits
        for (int l = 0; l < encryptedDigits.Count; l++)
        {
            if (encryptedDigits[l] > 9)
            {
                int temp1 = encryptedDigits[l];
                string temp = encryptedDigits[l].ToString();
                encryptedDigits.Insert(l, temp[1] - '0');
                encryptedDigits.Insert(l, temp[0] - '0');
                encryptedDigits.Remove(temp1);
            }
        }
        //Console.WriteLine(string.Join("", encryptedDigits));

        // filling a matrix with the encrypted digits, diagonally
        int N = encryptedDigits.Count;
        int[,] matrix = new int[N, N];
      
        for (int k = 0; k < encryptedDigits.Count; k++)
        {
            matrix[k, k] = encryptedDigits[k];
        }

        // printing the matrix
        if (diagonal == "\\")
        {
            // forwards
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        else
        {
            // backwords
            for (int row = N - 1; row >= 0; row--)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

