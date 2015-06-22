// Problem 6. Print Numbers - Write a program to print the numbers 1, 101 and 1001, each at a separate line.

/* Logic: 
 * 
 * 1 = 10^0; 101 = 10^1 + "1"; 1001 = 10^2 + "1", etc. 
 * Please note that we do not add the number 1 to the power of 10, we just write the digit "1" next to it
 * 10 + 1 would be 11, this is why we need 10 + "1", just the digit written next to the power of 10
 * 
 * A second trick is the fact that we do not work on the previous member of the sequence, we just calculate every member of the sequence from scratch
 * the loop we use increases only the power of 10, it does not add to the previous sequence member
 * 
 * A last trick is the method Console.WriteLine() itself - it prints a string " something ", 
 * and between the quotation marks defining this string we can place both numbers and strings
 * we can even concatenate strings and numbers, see the example: Console.WriteLine("{0}" + 1, Math.Pow(10, i));
 * in both cases we have string + number, so the operation we perform is concatenation, not addition
 */

using System;

class PrintNumbers2
{
    static void Main(string[] args)
    {
        Console.Title = "Print Numbers 1";

        // at each step of the for loop we increase the power of 10 by 1
        for (int i = 0; i < 3; i++)
        {
            // for the first member of the sequence only, we print just the power of 10
            if (i == 0)
            {
                Console.WriteLine(Math.Pow(10, i));
            }
            // for every next member of the sequence - we write the digit "1" after the power of 10
            else
            {
                Console.WriteLine("{0}{1}", Math.Pow(10, i), 1);
                // Console.WriteLine("{0}" + 1, Math.Pow(10, i)); // you can uncomment and test this as well
            }
        }
    }
}
