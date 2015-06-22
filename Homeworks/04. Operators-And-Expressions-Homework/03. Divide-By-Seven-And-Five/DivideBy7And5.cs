//  Problem 3. Divide by 7 and 5

/* Write a Boolean expression that checks for given integer 
 * if it can be divided (without remainder) by 7 and 5 at the same time.
 * Examples:
 * n 	Divided by 7 and 5?
 * 3 	false
 * 0 	false
 * 5 	false
 * 7 	false
 * 35 	true
 * 140 	true 
 */

using System;

class DivideBy7And5
{
    static void Main()
    {
        string intro = @"This program checks for given integer 
if it can be divided (without remainder) 
by 7 and 5 at the same time.";
        Console.WriteLine(intro);

        string input;
        int num;

        do // validates number input
        {
            Console.Write("\nPlease, enter a type int number: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        // checks if the input number can be divided by 35 (both 5, and 7), and prints the check result
        Console.WriteLine("\n{0} can be divided by 7 AND 5 \nat the same time: {1}\n", num, ((num % 35 == 0) && num != 0));
    }
}

