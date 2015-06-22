/* Problem 4 – Crossing Sequences
We’re dealing with two sequences: the Tribonacci sequence, where every number is the sum of the previous three, 
 * and the number spiral, defined by walking over a grid of numbers as a spiral (right, down, left, up, right, down, up, left, …) and writing down the current number every time we take a turn. Find the first number that appears in both sequences.
Example
Let the Tribonacci sequence start with 1, 2 and 3. It will therefore contain 
 * the numbers 1, 2, 3, 6, 11, 20, 37, 68, 125, 230, 423, 778, 1431, 2632, 4841, 8904, 16377, 30122, 55403, 101902, and so on.
Also, let the number spiral start with 5 and have a step of 2; it then contains 
 * the numbers 5, 7, 9, 13, 17, 23, 29, 37, etc. Since 37 is the first number 
 * that is both in the Tribonacci sequence and in the spiral, it is the answer.
Input
The input data should be read from the console.	
•	On the first three lines of input, you will read three integers, representing the three initial numbers of the Tribonacci sequence.
•	On the next two lines of input, you will read two integers, representing the initial number and the step of each grid cell for the number spiral.
The input data will always be valid and in the format described. There is no need to check it.
Output
The output must be printed on the console.
On the single line of output you must print the smallest number that appears in both sequences. 
 * If no number in the range [1 … 1 000 000] exists that appears in both sequences, print "No".
Constraints
•	All numbers in the input will be in the range [1 … 1 000 000].
 */

using System;
using System.Collections.Generic;

class CrossingSequences
{
    static void Main()
    {
        int tr1 = int.Parse(Console.ReadLine());
        int tr2 = int.Parse(Console.ReadLine());
        int tr3 = int.Parse(Console.ReadLine());

        int iniSpiral = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        List<int> tribonacciNums = TribonacciCalc(tr1, tr2, tr3);

        //Console.WriteLine(string.Join(" ", tribonacciNums));
        int result = 0;
        int newStep = step;
        int index = 0;
        while (iniSpiral <= 1000000)
        {
            if (tribonacciNums.Contains(iniSpiral))
            {
                result = iniSpiral;
                break;
            } 
            if (index > 0 && index % 2 == 0)
            {
                newStep += step;
            }
            iniSpiral += newStep;
            index++;         
        }

        if (result > 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static List<int> TribonacciCalc(int tr1, int tr2, int tr3)
    {
        List<int> tribonacci = new List<int>();

        int first = tr1;
        int second = tr2;
        int third = tr3;
        tribonacci.Add(first);
        tribonacci.Add(second);
        tribonacci.Add(third);
        int forth = 0;

        while (forth <= 1000000)
        {
            forth = first + second + third;
            tribonacci.Add(forth);
            first = second;
            second = third;
            third = forth;
        }
        return tribonacci;
    }
}

