// Problem 11. Bitwise: Extract Bit #3

/*  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.

Examples:
n 	    binary representation 	bit #3
5 	    00000000 00000101 	    0
0 	    00000000 00000000 	    0
15 	    00000000 00001111 	    1
5343 	00010100 11011111 	    1
62241 	11110011 00100001 	    0  */

using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        string input;
        int num = 0;

        string intro = @"This program will extract the third bit 
of any type int number of your choice.";

        Console.WriteLine(intro);

        do  // validates number input
        {
            Console.Write("\nPlease enter a number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        int mask = 1;

        // preparing the binary representation output
        string binary = Convert.ToString(num, 2).PadLeft(16, '0');
        string first = binary.Substring(0, 8);
        string second = binary.Substring(8);

        // left-centered formating of all numbers, inside virtual coulmns of X simbols: {0, -12}{1, -9}{2, -19}
        Console.WriteLine("\nn 	    binary representation 	bit #3\n{0, -12}{1, -9}{2, -19}{3}", num, first, second, ((num >> 3) & mask)); //extracts and prints third bit value
    }
}



/* Explanation:
 *     if num = 9           -->   00001001
 *     and mask = 1         -->   00000001
 *     
 *     num = num >> 3       -->   00000001
 *     mask                 -->   00000001
 *     (num >> 3) & mask    -->   00000001
 *     
 * and the program will print 1 for bit value
 * 
 *     if num = 4           -->   00000100
 *     and mask = 1         -->   00000001
 *     
 *     num = num >> 3       -->   00000000
 *     mask                 -->   00000001
 *     (num >> 3) & mask    -->   00000000
 *     
 * and the program will print 0 for bit value
 */
