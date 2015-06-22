/* Problem 3 – Programmer DNA
The secret scientists from the institute of Bizarre Artificial Neurobiology or B.A.N 
 * have tried for years to find the DNA markers of the perfect programmer. 
 * The work is going well but after an incident with the printer in the institute it is impossible to print the latest discovery. 
 * That is why they have asked you to help them.
Your task is to make a program that can print simple DNA chains of various lengths. Simple DNA chains consist of sequence of diamond blocks 
 * containing only letters from A to G (see the example on the right).
Letters are chained alphabetically: A is followed by B, then C, D, E, F, G, then again A and so on. Each DNA block is with size 7.
Input
The input data should be read from the console.
•	On the first line an integer number N specifying the length of the DNA chain will be given.
•	On the second line the starting letter of the chain will be given (capital letter from A to G).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. Following the examples below print exactly N lines of the programmer's DNA. 
 * Use only capital letters from A to G and “.” for the empty space.
 */

using System;

class ProgrammerDNA
{
    static void Main()
    {
        int totalLength = int.Parse(Console.ReadLine());
        char printChar = char.Parse(Console.ReadLine());

        char spaceChar = '.';

        int blockSize = 7;
        int midPoint = blockSize / 2;
        int diff = 0;
        int diffCounter = 0;

        for (int counter = 0; counter < totalLength; counter++)
        {
            // Print Block
            for (int i = 0; i < blockSize; i++)
            {
                if (i >= midPoint - diff && i <= midPoint + diff)
                {
                    Console.Write(printChar);

                    // Change Letter
                    if (printChar == 'G')
                    {
                        printChar = 'A';
                    }
                    else
                    {
                        printChar++;
                    }
                }
                else
                {
                    Console.Write(spaceChar);
                }
            }

            if (diffCounter >= midPoint)
            {
                diff--;
            }
            else
            {
                diff++;
            }

            diffCounter++;

            if (diffCounter == blockSize)
            {
                diffCounter = 0;
                diff++;
            }

            Console.WriteLine();
        }
    }
}


