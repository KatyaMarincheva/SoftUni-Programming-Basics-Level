//Problem 12. Extract Bit from Integer
/* Write an expression that extracts from given integer n the value of given bit at index p.

Examples:
n 	        binary representation 	p 	bit @ p
5 	        00000000 00000101 	    2 	1
0 	        00000000 00000000 	    9 	0
15 	        00000000 00001111 	    1 	1
5343 	    00010100 11011111 	    7 	1
62241 	    11110011 00100001 	    11 	0   */

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        string intro =
    @"This program extracts from given integer n 
the value of given bit at index p.";

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

        int mask = 1;
        // preparing the binary representation output
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        string first = binary.Substring(0, 8);
        string second = binary.Substring(8);

        // left-centered formating of all numbers, inside virtual coulmns of X simbols: {0, -12}{1, -9}{2, -19}
        Console.WriteLine("\nn 	binary representation 	p  bit @ p\n{0, -8}{1, -9}{2, -15}{3, -3}{4}", n, first, second, p, ((n >> p) & mask)); //extracts and prints third bit value
    }
}

