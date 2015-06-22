/* Problem 7.	Matrix of Palindromes
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
Input	
3 6	
Output
aaa aba aca	ada aea afa
bbb bcb bdb	beb bfb bgb
ccc cec cdc	cfc cgc chc
 * 
2 3	
Output
aaa aba aca
bbb bcb bdb
1 1	
Output
aaa
1 3	
Output
aaa aba aca
 */

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class MatrixOfPalindromes
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a value for r: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        int c = int.Parse(Console.ReadLine());

        // create a list of palindromes
        List<string> palindromes = MakePalindromes();

        // fill the matrix with palindromes
        string[,] matrix = new string[r, c];
        int index = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = palindromes[index];
                index++;
            }
            index += 27 - c; // make sure each row starts with a next letter
        }

        // print the matrix
        PrintMatrix(r, c, matrix);
    }

    private static void PrintMatrix(int r, int c, string[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static List<string> MakePalindromes()
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<string> palindromes = new List<string>();

        for (int c1 = 0; c1 < letters.Length; c1++)
        {
            for (int c2 = 0; c2 < letters.Length; c2++)
            {
                for (int c3 = 0; c3 < letters.Length; c3++)
                {
                    string temp = "" + letters[c1] + letters[c2] + letters[c3];
                    if (PalindromeCheck(temp))
                    {
                        palindromes.Add(temp);
                    }
                }
            }
        }
        return palindromes;
    }

    private static bool PalindromeCheck(string s)
    {
        bool isPalindrome = false;
        // searching for regex matches where string == string reversed
        if (s == String.Join("", s.Reverse()))
        {
            isPalindrome = true;
        }
        return isPalindrome;
    }
}

