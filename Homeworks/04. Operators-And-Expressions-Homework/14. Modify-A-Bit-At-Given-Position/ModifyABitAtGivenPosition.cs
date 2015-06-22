// Problem 14. Modify a Bit at Given Position

/* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

Examples:
n 	binary representation of n 	p 	v 	binary result 	    result
5 	    00000000 00000101 	    2 	0 	00000000 00000001 	1
0 	    00000000 00000000 	    9 	1 	00000010 00000000 	512
15 	    00000000 00001111 	    1 	1 	00000000 00001111 	15
5343 	00010100 11011111 	    7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	    11 	0 	11110011 00100001 	62241 */

using System; 

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        string inputV;
        int v;

        string intro = 
    @"This program will modify the number n 
to hold the value v at the position p
from the binary representation of n 
while preserving all other bits in n.";

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
        
        do  // validates input for v
        {
            Console.Write("\nPlease enter a bit value v (0 or 1): ");
            inputV = Console.ReadLine();

        } while (!int.TryParse(inputV, out v));

        int mask = 1 << p; // a mask with a bit 1 at the manipulation position
        // preparing the binary representation of the input number
        string binary1 = Convert.ToString(n, 2).PadLeft(16, '0');
        string first1 = binary1.Substring(0, 8);
        string second1 = binary1.Substring(8);

        // (0 | 1) = 1 and (1 | 1) = 1; we guarantee that with no matter what intitial value
        // the final one will be 1

        string binary2;
        string first2;
        string second2;
        int temp;
        if (v == 1) 
        {
            temp = n;
            n = n | mask;

            // preparing the binary representation of the output number
            binary2 = Convert.ToString(n, 2).PadLeft(16, '0');
            first2 = binary2.Substring(0, 8);
            second2 = binary2.Substring(8);
            // left-centered formating of all numbers, inside virtual coulmns of X simbols: {0, -12}{1, -9}{2, -19}
            Console.WriteLine("\nn 	binary representation  p  v  binary result        result\n{0, -8}{1, -9}{2, -14}{3, -3}{4, -3}{5, -9}{6, -12}{7}", 
                temp, first1, second1, p, v, first2, second2, n); 
        }

        // I will first set the bit value at the manipulation position to 1
        // after that, I will apply the ^(XOR) operator: 1 (in n) ^ 1 (in mask) = 0
        if (v == 0)
        {
            temp = n;
            n = n | mask;
            n = n ^ mask;

            // preparing the binary representation of the output number
            binary2 = Convert.ToString(n, 2).PadLeft(16, '0');
            first2 = binary2.Substring(0, 8);
            second2 = binary2.Substring(8);
            // left-centered formating of all numbers, inside virtual coulmns of X simbols: {0, -12}{1, -9}{2, -19}
            Console.WriteLine("\nn 	binary representation  p  v  binary result        result\n{0, -8}{1, -9}{2, -14}{3, -3}{4, -3}{5, -9}{6, -12}{7}", 
                temp, first1, second1, p, v, first2, second2, n); 
        }
    }
}
    
