/* Problem 5 – Bit Shooter
We are given a bit field in the form of 64-bit integer number. We shoot it 3 times. Each shoot has a center and a size. 
 * The shoot damages size bits around the shoot center (makes these bits 0). Finally, the bit field is split into left side (bits 63 … 32) 
 * and right side (bits 31 … 0). Write a program that calculates how many bits survive (have value 1) 
 * after the shoots in the left side and in the right side of the bit field. The bits are numbered as traditionally in programming: 
 * from right to left from 0 to 63.
Input
The input data should be read from the console. It will consist of exactly 4 lines:
•	At the first line you will have a 64-bit integer, corresponding to the bit field.
•	At each of the next 3 lines we have 2 numbers: shoot center and shoot size – integers, split by a space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consists of exactly 2 lines:
•	The first line print "left: …" and the number of alive bits in the left side.
•	The second line print "right: …" and the number of alive bits in the right side.
Constraints
•	The bit field will be a 64-bit integer in the range [0 … 18 446 744 073 709 551 615].
•	The values for the center will be integers will be integers in range [0 … 63].
•	The values for the size will be odd integers in range [1 … 99].
 */

using System;

class BitShooter2
{
    static void Main()
    {
        const int BITS = 64;

        ulong inputBits = ulong.Parse(Console.ReadLine());
        ulong shootedBits = 0;
        for (int i = 0; i < 3; i++)
        {
            string shoot = Console.ReadLine();
            string[] shootDetails = shoot.Split(' ');
            int shootCenter = int.Parse(shootDetails[0]);
            int shootSize = int.Parse(shootDetails[1]);
            int startBit = shootCenter - shootSize / 2;
            int endBit = shootCenter + shootSize / 2;
            for (int bit = startBit; bit <= endBit; bit++)
            {
                if (bit >= 0 && bit < BITS)
                {
                    shootedBits = shootedBits | ((ulong)1 << bit);
                }
            }
        }

        ulong aliveBits = inputBits & (~shootedBits);

        //Console.WriteLine(Convert.ToString((long)inputBits, 2).PadLeft(64,'0'));
        //Console.WriteLine(Convert.ToString((long)~shootedBits, 2).PadLeft(64, '0'));
        //Console.WriteLine(Convert.ToString((long)aliveBits, 2).PadLeft(64, '0'));

        ulong rightBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            rightBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        ulong leftBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            leftBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        Console.WriteLine("left: " + leftBits);
        Console.WriteLine("right: " + rightBits);
    }
}
