/* Problem 5 – Friend Bits
"Friend bits" are sequences of bits with the same value. All other bits are "alone bits". For example in 
 * the sequence 11101010011011010000111010110001 the friend bits (marked in grey, from left to right) are:
 * 111, 00, 11, 11, 0000, 111, 11 and 000. In the same sequence alone bits are: 0101, 0, 01, 010 and 1.
We are given a 32-bit integer n. Write a program that extracts all friend bits and all alone bits from n. 
 * Append all friend bits in the same order in which they appear in n and print their decimal representation f. 
 * Respectively, append all alone bits in the order in which they appear in n and print their decimal representation a.
Input
The input data should be read from the console. It holds the number n at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 2 lines: the numbers f and a.
Constraints
•	All input and output numbers should be unsigned 32-bit integers in the range [0 to 4 294 967 295].
 */

using System;

class FriendBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint friendBits = 0;
        uint aloneBits = 0;
        for (int i = 31; i >= 0; i--)
        {
            uint currentBit = (n >> i) & 1;

            bool hasLeftBit = (i < 31);
            uint leftBit = (n >> (i + 1)) & 1;
            bool sameLeftBit = hasLeftBit && (leftBit == currentBit);

            bool hasRightBit = (i > 0);
            uint rightBit = (n >> (i - 1)) & 1;
            bool sameRightBit = hasRightBit && (rightBit == currentBit);

            bool friendBit = sameLeftBit || sameRightBit;
            if (friendBit)
            {
                friendBits = (friendBits << 1) | currentBit;
            }
            else
            {
                aloneBits = (aloneBits << 1) | currentBit;
            }
        }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
    }
}
