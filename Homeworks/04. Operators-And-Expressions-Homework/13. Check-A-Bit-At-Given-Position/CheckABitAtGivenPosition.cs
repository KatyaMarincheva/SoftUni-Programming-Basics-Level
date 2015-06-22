// Problem 13. Check a Bit at Given Position

/* Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) in given integer number n, has value of 1.

Examples:
n 	        binary representation of n 	p 	bit @ p == 1
5 	        00000000 00000101 	        2 	true
0 	        00000000 00000000 	        9 	false
15 	        00000000 00001111 	        1 	true
5343 	    00010100 11011111 	        7 	true
62241 	    11110011 00100001 	        11 	false   */

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        string intro =
    @"This program returns if the bit at position p 
in given integer number n, has value of 1.";

        Console.WriteLine(intro);

        do  // validates input for n
        {
            Console.Write("\nPlease enter a value for n: ");
            inputN = Console.ReadLine();

        } while (!int.TryParse(inputN, out n));

        do  // validates input for p
        {
            Console.Write("\nPlease enter a value for p: ");
            inputP = Console.ReadLine();

        } while (!int.TryParse(inputP, out p));

        int mask = 1 << p;
        // preparing the binary representation output
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        string first = binary.Substring(0, 8);
        string second = binary.Substring(8);

        // left-centered formating of all numbers, inside virtual coulmns of X simbols: {0, -12}{1, -9}{2, -19}
        Console.WriteLine("\nn 	binary representation 	p  bit @ p == 1\n{0, -8}{1, -9}{2, -15}{3, -3}{4}", n, first, second, p, ((mask & n) == mask)); //extracts and prints third bit value
    }
}

